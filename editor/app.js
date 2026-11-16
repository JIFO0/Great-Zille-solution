/**
 * JIFOCC RPi4B NARRATIVE & CONVERSATION STUDIO
 * High-Tech Branching Flow Graph & Dialogue Engine
 * Zero Emojis - Pure SVG & Vector Telemetry
 */

function initTheme() {
  const saved = localStorage.getItem('gz_editor_theme') || 'suzerain';
  applyTheme(saved);
}

function applyTheme(theme) {
  if (theme === 'telemetry') {
    document.documentElement.removeAttribute('data-theme');
  } else {
    document.documentElement.setAttribute('data-theme', 'suzerain');
  }
  const label = document.getElementById('theme-toggle-label');
  if (label) {
    label.textContent = theme === 'telemetry' ? 'THEME: TELEMETRY' : 'THEME: SUZERAIN';
  }
  localStorage.setItem('gz_editor_theme', theme);
}

function toggleTheme() {
  const current = localStorage.getItem('gz_editor_theme') || 'suzerain';
  const next = current === 'suzerain' ? 'telemetry' : 'suzerain';
  applyTheme(next);
}
window.toggleTheme = toggleTheme;

function initLanguage() {
  const saved = localStorage.getItem('gz_editor_lang') || 'en';
  applyLanguage(saved);
}

function applyLanguage(lang) {
  document.documentElement.setAttribute('lang', lang);
  const label = document.getElementById('lang-toggle-label');
  if (label) {
    label.textContent = lang === 'pl' ? 'LANG: PL' : 'LANG: EN';
  }
  localStorage.setItem('gz_editor_lang', lang);
}

function toggleLanguage() {
  const current = localStorage.getItem('gz_editor_lang') || 'en';
  const next = current === 'en' ? 'pl' : 'en';
  applyLanguage(next);
  showToast(next === 'en' ? 'Language set to English' : 'Język zmieniony na Polski', 'success');
}
window.toggleLanguage = toggleLanguage;

document.addEventListener('DOMContentLoaded', () => {
  initTheme();
  initLanguage();
});

let appState = {
  currentTab: 'conversations', // conversations, decisions, reports, situations
  activeFilter: 'all',        // all, MODNEW, MODEDIT, Rizia, Sordland
  viewMode: 'tree',           // 'tree' or 'list'
  treeOrientation: 'horizontal', // 'horizontal' (LTR parallel lanes) or 'vertical' (TTB branching tree)
  showOnlyModLines: false,
  searchQuery: '',
  selectedTagFilter: '',
  catalog: [],
  decisions: [],
  reports: [],
  situations: [],
  variables: {},
  actors: {},
  activeItem: null,
  activeItemFull: null,
  activeSelectedNodeId: null,
  highlightedScenarioNodeId: null,
  pendingTagTargetInput: null,

  // Pan & Zoom state for visual tree
  treeZoom: 1.0,
  treePanX: 40,
  treePanY: 40,
  isPanning: false,
  panStartX: 0,
  panStartY: 0
};

// SVG ICON TEMPLATES (NO EMOJIS)
const ICONS = {
  player: `<svg width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><path d="M12 2l3 7h7l-5.5 4.5 2 7.5L12 17l-6.5 4 2-7.5L2 9h7l3-7z"/></svg>`,
  council: `<svg width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><path d="M12 22s8-4 8-10V5l-8-3-8 3v7c0 6 8 10 8 10z"/></svg>`,
  foreign: `<svg width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><circle cx="12" cy="12" r="10"/><line x1="2" y1="12" x2="22" y2="12"/><path d="M12 2a15.3 15.3 0 0 1 4 10 15.3 15.3 0 0 1-4 10 15.3 15.3 0 0 1-4-10 15.3 15.3 0 0 1 4-10z"/></svg>`,
  narrator: `<svg width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><path d="M4 19.5A2.5 2.5 0 0 1 6.5 17H20"/><path d="M6.5 2H20v20H6.5A2.5 2.5 0 0 1 4 19.5v-15A2.5 2.5 0 0 1 6.5 2z"/></svg>`,
  choice: `<svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><line x1="6" y1="3" x2="6" y2="15"/><circle cx="18" cy="6" r="3"/><circle cx="6" cy="18" r="3"/><path d="M18 9a9 9 0 0 1-9 9"/></svg>`,
  link: `<svg width="11" height="11" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><line x1="5" y1="12" x2="19" y2="12"/><polyline points="12 5 19 12 12 19"/></svg>`,
  trash: `<svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><polyline points="3 6 5 6 21 6"/><path d="M19 6v14a2 2 0 0 1-2 2H7a2 2 0 0 1-2-2V6m3 0V4a2 2 0 0 1 2-2h4a2 2 0 0 1 2 2v2"/></svg>`,
  check: `<svg width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><polyline points="20 6 9 17 4 12"/></svg>`,
  alert: `<svg width="14" height="14" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><circle cx="12" cy="12" r="10"/><line x1="12" y1="8" x2="12" y2="12"/><line x1="12" y1="16" x2="12.01" y2="16"/></svg>`
};

document.addEventListener('DOMContentLoaded', () => {
  initApp();
  setupKeyboardShortcuts();
});

async function initApp() {
  showToast('Inicjalizacja systemu JIFOCC...', 'info');
  try {
    const [manifestRes, catalogRes, decisionsRes, reportsRes, situationsRes, variablesRes, actorsRes] = await Promise.all([
      fetch('/api/manifest').then(r => r.json()).catch(() => ({})),
      fetch('/api/catalog').then(r => r.json()).catch(() => []),
      fetch('/api/decisions').then(r => r.json()).catch(() => []),
      fetch('/api/reports').then(r => r.json()).catch(() => []),
      fetch('/api/situations').then(r => r.json()).catch(() => []),
      fetch('/api/variables').then(r => r.json()).catch(() => ({})),
      fetch('/api/actors').then(r => r.json()).catch(() => ({}))
    ]);

    appState.catalog = catalogRes;
    appState.decisions = decisionsRes;
    appState.reports = reportsRes;
    appState.situations = situationsRes;
    appState.variables = variablesRes;
    appState.actors = actorsRes;

    document.getElementById('count-conversations').textContent = catalogRes.length;
    document.getElementById('count-decisions').textContent = decisionsRes.length;
    document.getElementById('count-reports').textContent = reportsRes.length;
    document.getElementById('count-situations').textContent = situationsRes.length;
    document.getElementById('count-tags').textContent = Object.keys(variablesRes).length;

    populateSidebarTagFilter();
    renderSidebarList();

    // Default select first MODNEW or MODEDIT scene
    const defaultItem = catalogRes.find(c => c.modStatus === 'MODNEW') || catalogRes.find(c => c.modStatus === 'MODEDIT') || catalogRes[0];
    if (defaultItem) {
      selectItem(defaultItem);
    }

    showToast('Suzerain database loaded successfully!', 'success');
  } catch (err) {
    console.error('Initialization error:', err);
    showToast('Data loading error: ' + err.message, 'error');
  }
}

// ================= VIEW MODE & TABS =================

function setViewMode(mode) {
  appState.viewMode = mode;
  document.getElementById('btn-view-tree').classList.toggle('active', mode === 'tree');
  document.getElementById('btn-view-list').classList.toggle('active', mode === 'list');
  if (appState.activeItemFull && appState.currentTab === 'conversations') {
    renderConversationWorkspace(appState.activeItemFull);
  }
}

function toggleModOnlyFilter() {
  appState.showOnlyModLines = !appState.showOnlyModLines;
  const btn = document.getElementById('btn-toggle-modonly');
  btn.classList.toggle('active', appState.showOnlyModLines);
  if (appState.activeItemFull && appState.currentTab === 'conversations') {
    renderConversationWorkspace(appState.activeItemFull);
  }
}

function switchMainTab(tabName) {
  appState.currentTab = tabName;
  appState.activeItem = null;
  appState.activeItemFull = null;
  closeInspectorDrawer();

  document.querySelectorAll('.hud-tab').forEach(t => {
    t.classList.toggle('active', t.getAttribute('data-tab') === tabName);
  });

  document.getElementById('view-mode-toggle').style.display = (tabName === 'conversations') ? 'flex' : 'none';
  document.getElementById('btn-toggle-modonly').style.display = (tabName === 'conversations') ? 'flex' : 'none';

  appState.searchQuery = '';
  document.getElementById('global-search-input').value = '';

  renderSidebarList();

  document.getElementById('workspace-header').style.display = 'none';
  document.getElementById('workspace-content').innerHTML = `
    <div style="display:flex; flex-direction:column; align-items:center; justify-content:center; height:100%; color:var(--text-dim); gap:10px;">
      <div style="font-family:var(--font-mono); font-size:14px; letter-spacing:1px;">JIFOCC // WYBIERZ POZYCJE Z PANELU BOCZNEGO</div>
    </div>
  `;

  const items = getCurrentItemsList();
  if (items.length > 0) selectItem(items[0]);
}

function setFilter(filterName) {
  appState.activeFilter = filterName;
  document.querySelectorAll('.f-btn').forEach(c => {
    c.classList.toggle('active', c.getAttribute('data-filter') === filterName);
  });
  renderSidebarList();
}

function handleSearchInput() {
  appState.searchQuery = document.getElementById('global-search-input').value.trim();
  renderSidebarList();
}

function handleTagFilterChange() {
  appState.selectedTagFilter = document.getElementById('sidebar-tag-filter').value;
  renderSidebarList();
}

function populateSidebarTagFilter() {
  const sel = document.getElementById('sidebar-tag-filter');
  sel.innerHTML = '<option value="">Wszystkie tagi (Prerequisites)...</option>';

  const varNames = Object.keys(appState.variables).sort();
  const prioritized = varNames.filter(v => v.startsWith('Zille_') || v.startsWith('RiziaDLC.Resources_'));
  const others = varNames.filter(v => !v.startsWith('Zille_') && !v.startsWith('RiziaDLC.Resources_'));

  if (prioritized.length > 0) {
    const grp = document.createElement('optgroup');
    grp.label = 'TAGI GREAT ZILLE & ZASOBY';
    prioritized.forEach(name => {
      const opt = document.createElement('option');
      opt.value = name;
      opt.textContent = name;
      grp.appendChild(opt);
    });
    sel.appendChild(grp);
  }

  const grpOthers = document.createElement('optgroup');
  grpOthers.label = 'ZMIENNE BAZOWE (12,800+)';
  others.slice(0, 150).forEach(name => {
    const opt = document.createElement('option');
    opt.value = name;
    opt.textContent = name;
    grpOthers.appendChild(opt);
  });
  sel.appendChild(grpOthers);
}

// ================= SIDEBAR LIST RENDERING =================

function getCurrentItemsList() {
  if (appState.currentTab === 'conversations') return appState.catalog;
  if (appState.currentTab === 'decisions') return appState.decisions;
  if (appState.currentTab === 'reports') return appState.reports;
  if (appState.currentTab === 'situations') return appState.situations;
  return [];
}

function renderSidebarList() {
  const container = document.getElementById('sidebar-items-list');
  const items = getCurrentItemsList();
  const query = appState.searchQuery.toLowerCase();
  const filter = appState.activeFilter;
  const tagFilter = appState.selectedTagFilter.toLowerCase();

  const filtered = items.filter(it => {
    if (filter === 'MODNEW' && it.modStatus !== 'MODNEW') return false;
    if (filter === 'MODEDIT' && it.modStatus !== 'MODEDIT') return false;
    if (filter === 'Rizia' && it.pack !== 'Rizia') return false;
    if (filter === 'Sordland' && it.pack !== 'Sordland') return false;

    if (tagFilter) {
      const r_vars = (it.readVariables || []).map(v => v.toLowerCase());
      const w_vars = (it.writtenVariables || []).map(v => v.toLowerCase());
      const cond = (it.condition || '').toLowerCase();
      if (!r_vars.includes(tagFilter) && !w_vars.includes(tagFilter) && !cond.includes(tagFilter)) {
        return false;
      }
    }

    if (query) {
      const title = (it.title || '').toLowerCase();
      const id = String(it.id || it.name || '').toLowerCase();
      const desc = (it.description || '').toLowerCase();
      const turn = (it.turn || '').toLowerCase();
      if (!title.includes(query) && !id.includes(query) && !desc.includes(query) && !turn.includes(query)) {
        return false;
      }
    }
    return true;
  });

  if (filtered.length === 0) {
    container.innerHTML = `
      <div style="padding: 24px 10px; text-align: center; color: var(--text-dim); font-family: var(--font-mono); font-size: 11px;">
        BRAK WYNIKOW DLA PODANYCH FILTROW
      </div>
    `;
    return;
  }

  container.innerHTML = filtered.map(it => {
    const isSelected = appState.activeItem && String(appState.activeItem.id) === String(it.id);
    let badgeHtml = '';
    if (it.modStatus === 'MODNEW') badgeHtml = '<span class="badge badge-modnew">MODNEW</span>';
    else if (it.modStatus === 'MODEDIT') badgeHtml = '<span class="badge badge-modedit">MODEDIT</span>';
    else badgeHtml = '<span class="badge badge-vanilla">GAME</span>';

    const snippet = it.description || it.modNote || (it.entriesCount ? `${it.entriesCount} dialogue nodes` : '');
    const turnText = it.turn ? `${it.turn}` : (it.pack || '');

    return `
      <div class="item-row ${isSelected ? 'selected' : ''}" onclick="selectItemById('${it.id}')">
        <div class="item-top">
          <span class="item-name" title="${escapeHtml(it.title)}">${escapeHtml(it.title)}</span>
          ${badgeHtml}
        </div>
        <div class="item-info">
          <span>${escapeHtml(turnText)}</span>
          <span>//</span>
          <span>ID: ${it.id}</span>
        </div>
        ${snippet ? `<div class="item-preview">${escapeHtml(snippet)}</div>` : ''}
      </div>
    `;
  }).join('');
}

function selectItemById(id) {
  const items = getCurrentItemsList();
  const item = items.find(it => String(it.id) === String(id));
  if (item) selectItem(item);
}

// ================= SELECT ITEM & WORKSPACE =================

async function selectItem(item) {
  appState.activeItem = item;
  closeInspectorDrawer();
  renderSidebarList();

  const header = document.getElementById('workspace-header');
  header.style.display = 'flex';

  document.getElementById('active-item-title').textContent = item.title;
  document.getElementById('active-item-id').textContent = item.id;
  document.getElementById('active-item-turn').textContent = `${item.turn || item.pack || '-'}`;

  const badgeEl = document.getElementById('active-item-badge');
  badgeEl.className = 'badge';
  if (item.modStatus === 'MODNEW') {
    badgeEl.classList.add('badge-modnew');
    badgeEl.textContent = 'MODNEW';
  } else if (item.modStatus === 'MODEDIT') {
    badgeEl.classList.add('badge-modedit');
    badgeEl.textContent = 'MODEDIT';
  } else {
    badgeEl.classList.add('badge-vanilla');
    badgeEl.textContent = 'GRA';
  }

  const noteEl = document.getElementById('active-item-note');
  noteEl.textContent = item.modNote ? `// ${item.modNote}` : '';

  document.getElementById('btn-add-line').style.display = (appState.currentTab === 'conversations') ? 'flex' : 'none';
  document.getElementById('btn-add-choice').style.display = (appState.currentTab === 'conversations') ? 'flex' : 'none';
  document.getElementById('btn-add-option').style.display = (appState.currentTab === 'decisions') ? 'flex' : 'none';

  const contentArea = document.getElementById('workspace-content');
  contentArea.innerHTML = '<div style="padding: 40px; text-align: center; color: var(--neon-cyan); font-family: var(--font-mono);">LADOWANIE STRUKTURY...</div>';

  if (appState.currentTab === 'conversations') {
    await loadConversationWorkspace(item.id);
  } else if (appState.currentTab === 'decisions') {
    renderDecisionWorkspace(item);
  } else if (appState.currentTab === 'reports') {
    renderReportWorkspace(item);
  } else if (appState.currentTab === 'situations') {
    renderSituationWorkspace(item);
  }
}

// ================= CONVERSATION WORKSPACE =================

async function loadConversationWorkspace(convId) {
  try {
    const res = await fetch(`/api/conversation?id=${convId}`);
    if (!res.ok) throw new Error('Nie znaleziono pliku');
    const convData = await res.json();
    appState.activeItemFull = convData;

    const entries = convData.entries || [];
    const choices = entries.filter(e => e.isPlayer);
    const nEl = document.getElementById('active-item-nodes-count');
    if (nEl) nEl.textContent = entries.length;
    const cEl = document.getElementById('active-item-choices-count');
    if (cEl) cEl.textContent = choices.length;

    renderConversationWorkspace(convData);
  } catch (err) {
    document.getElementById('workspace-content').innerHTML = `
      <div style="padding: 40px; text-align:center; color: var(--neon-crimson); font-family: var(--font-mono);">
        BLAD ODCZYTU PLIKU: ${err.message}
      </div>
    `;
  }
}

function renderConversationWorkspace(conv) {
  const container = document.getElementById('workspace-content');
  container.innerHTML = '';

  let entries = conv.entries || [];
  if (appState.showOnlyModLines) {
    entries = entries.filter(e => e.isModInjected || e.isModEdited);
  }

  if (appState.viewMode === 'tree') {
    renderFlowTreeView(container, conv, entries);
  } else {
    renderCardListView(container, conv, entries);
  }
}

// ================= INTERACTIVE BRANCHING FLOW TREE ENGINE =================

const SCENARIO_THEMES = [
  { id: 'ALFA',    color: '#c4a661', glow: 'none', badge: 'SCENARIO_1', label: 'Path 1' },
  { id: 'BETA',    color: '#c9903e', glow: 'none', badge: 'SCENARIO_2', label: 'Path 2' },
  { id: 'GAMMA',   color: '#6b946b', glow: 'none', badge: 'SCENARIO_3', label: 'Path 3' },
  { id: 'DELTA',   color: '#8c6d46', glow: 'none', badge: 'SCENARIO_4', label: 'Path 4' },
  { id: 'EPSILON', color: '#9e3f3f', glow: 'none', badge: 'SCENARIO_5', label: 'Path 5' },
  { id: 'ZETA',    color: '#567d8c', glow: 'none', badge: 'SCENARIO_6', label: 'Path 6' },
  { id: 'ETA',     color: '#b07648', glow: 'none', badge: 'SCENARIO_7', label: 'Path 7' },
  { id: 'THETA',   color: '#8a687c', glow: 'none', badge: 'SCENARIO_8', label: 'Path 8' }
];

let currentGraphTopology = {
  forwardChildren: {},
  incomingParents: {}
};

function setTreeOrientation(orient) {
  appState.treeOrientation = orient;
  if (appState.activeItemFull && appState.currentTab === 'conversations') {
    renderConversationWorkspace(appState.activeItemFull);
  }
}

function frameTreeToStart() {
  const container = document.getElementById('tree-view-container');
  if (!container || !appState.activeItemFull) return;
  const entries = appState.activeItemFull.entries || [];
  if (entries.length === 0) return;

  const root = entries.find(e => e.id === 0) || entries.find(e => e.isRoot) || entries[0];
  const rootPos = (currentGraphTopology.positions && currentGraphTopology.positions[root.id]) || { x: 60, y: 60 };

  const cw = container.clientWidth || 1000;
  const ch = container.clientHeight || 700;

  appState.treeZoom = 0.95;
  if (appState.treeOrientation === 'horizontal') {
    appState.treePanX = 60;
    appState.treePanY = Math.max(40, (ch / 2) - (rootPos.y + 55) * appState.treeZoom);
  } else {
    appState.treePanX = Math.max(40, (cw / 2) - (rootPos.x + 120) * appState.treeZoom);
    appState.treePanY = 60;
  }
  applyTreeTransform();
}

function jumpToFirstBranch() {
  if (!appState.activeItemFull || !appState.activeItemFull.entries) return;
  const entries = appState.activeItemFull.entries;
  const branchEntry = entries.find(e => (e.outgoing || []).length > 1) || entries[0];
  if (!branchEntry) return;

  const card = document.getElementById(`tree-card-${branchEntry.id}`);
  if (card) {
    const container = document.getElementById('tree-view-container');
    if (!container) return;
    const cw = container.clientWidth || 1000;
    const ch = container.clientHeight || 700;
    const cardLeft = parseFloat(card.style.left) || 0;
    const cardTop = parseFloat(card.style.top) || 0;
    appState.treePanX = (cw / 2) - (cardLeft + 125) * appState.treeZoom;
    appState.treePanY = (ch / 2) - (cardTop + 55) * appState.treeZoom;
    applyTreeTransform();
    card.classList.add('active-tree-node');
    openNodeInspector(branchEntry.id);
  }
}

function searchNodeInScene(query) {
  const q = (query || '').trim().toLowerCase();
  document.querySelectorAll('.tree-node-card').forEach(c => c.classList.remove('search-matched'));
  if (!q || !appState.activeItemFull) return;

  const entries = appState.activeItemFull.entries || [];
  const matched = entries.filter(e => {
    const idStr = String(e.id);
    const speaker = (e.speaker || '').toLowerCase();
    const text = (e.dialogueText || '').toLowerCase();
    const menu = (e.menuText || '').toLowerCase();
    return idStr === q || idStr.includes(q) || speaker.includes(q) || text.includes(q) || menu.includes(q);
  });

  if (matched.length > 0) {
    matched.forEach(m => {
      const card = document.getElementById(`tree-card-${m.id}`);
      if (card) card.classList.add('search-matched');
    });

    // Pan to first match
    const firstCard = document.getElementById(`tree-card-${matched[0].id}`);
    if (firstCard) {
      const container = document.getElementById('tree-view-container');
      if (container) {
        const cw = container.clientWidth || 1000;
        const ch = container.clientHeight || 700;
        const cardLeft = parseFloat(firstCard.style.left) || 0;
        const cardTop = parseFloat(firstCard.style.top) || 0;
        appState.treePanX = (cw / 2) - (cardLeft + 125) * appState.treeZoom;
        appState.treePanY = (ch / 2) - (cardTop + 55) * appState.treeZoom;
        applyTreeTransform();
      }
    }
  }
}

function renderFlowTreeView(container, conv, entries) {
  const isHorizontal = appState.treeOrientation !== 'vertical';

  const treeContainer = document.createElement('div');
  treeContainer.className = 'tree-view-container';
  treeContainer.id = 'tree-view-container';

  // Enhanced HUD Controls Overlay with Orientation, Home, Jump, Search, Zoom
  const hudControls = document.createElement('div');
  hudControls.className = 'tree-hud-controls';
  hudControls.innerHTML = `
    <div class="tree-orient-toggle-group">
      <button class="tree-orient-btn ${isHorizontal ? 'active' : ''}" onclick="setTreeOrientation('horizontal')" title="Horizontal Layout: Parallel scenario lanes from left to right">
        <svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><line x1="4" y1="6" x2="20" y2="6"/><line x1="4" y1="12" x2="20" y2="12"/><line x1="4" y1="18" x2="20" y2="18"/></svg>
        <span>LANES LTR</span>
      </button>
      <button class="tree-orient-btn ${!isHorizontal ? 'active' : ''}" onclick="setTreeOrientation('vertical')" title="Vertical Layout: Decision tree from top to bottom">
        <svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><line x1="6" y1="4" x2="6" y2="20"/><line x1="12" y1="4" x2="12" y2="20"/><line x1="18" y1="4" x2="18" y2="20"/></svg>
        <span>TREE TTB</span>
      </button>
    </div>

    <button class="tree-home-btn" onclick="frameTreeToStart()" title="Center camera on tree start (Home)">
      <svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"/><polyline points="9 22 9 12 15 12 15 22"/></svg>
      <span>START</span>
    </button>

    <button class="tree-jump-btn" onclick="jumpToFirstBranch()" title="Jump to first story branch">
      <svg width="12" height="12" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><polyline points="13 17 18 12 13 7"/><polyline points="6 17 11 12 6 7"/></svg>
      <span>JUMP TO CHOICE</span>
    </button>

    <div class="tree-search-wrap" title="Search lines in current scene (ID, speaker, keyword)">
      <input type="text" class="tree-search-input" placeholder="Search in scene..." oninput="searchNodeInScene(this.value)">
      <svg viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2"><circle cx="11" cy="11" r="8"/><line x1="21" y1="21" x2="16.65" y2="16.65"/></svg>
    </div>

    <button class="tree-ctrl-btn" onclick="zoomTreeAtPoint(1.15)" title="Zoom in (or mouse wheel)">+</button>
    <button class="tree-ctrl-btn" onclick="zoomTreeAtPoint(0.85)" title="Zoom out (or mouse wheel)">-</button>
    <div class="zoom-telemetry-pill" id="tree-zoom-val" onclick="resetTreeZoom()" title="Click to reset to 100%">100%</div>
    <button class="tree-ctrl-btn" onclick="fitTreeToView()" title="Fit entire tree to screen" style="width: auto; padding: 0 8px; font-family: var(--font-mono); font-size: 10px;">FIT</button>
  `;
  treeContainer.appendChild(hudControls);

  const canvas = document.createElement('div');
  canvas.className = 'tree-canvas';
  canvas.id = 'tree-canvas';

  const svgLayer = document.createElementNS('http://www.w3.org/2000/svg', 'svg');
  svgLayer.setAttribute('class', 'tree-svg-layer');
  svgLayer.id = 'tree-svg-layer';

  // Define Arrowhead Markers for All Scenarios & Standard Connectors
  const defs = document.createElementNS('http://www.w3.org/2000/svg', 'defs');
  let markersHtml = `
    <marker id="arrow-cyan" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="6" markerHeight="6" orient="auto-start-reverse">
      <path d="M 0 1 L 10 5 L 0 9 z" fill="#c4a661"/>
    </marker>
    <marker id="arrow-amber" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="6" markerHeight="6" orient="auto-start-reverse">
      <path d="M 0 1 L 10 5 L 0 9 z" fill="#c9903e"/>
    </marker>
    <marker id="arrow-purple" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="6" markerHeight="6" orient="auto-start-reverse">
      <path d="M 0 1 L 10 5 L 0 9 z" fill="#8c6d46"/>
    </marker>
    <marker id="arrow-dim" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="6" markerHeight="6" orient="auto-start-reverse">
      <path d="M 0 1 L 10 5 L 0 9 z" fill="#4a402d"/>
    </marker>
  `;
  SCENARIO_THEMES.forEach((thm, idx) => {
    markersHtml += `
      <marker id="arrow-scenario-${idx}" viewBox="0 0 10 10" refX="8" refY="5" markerWidth="6" markerHeight="6" orient="auto-start-reverse">
        <path d="M 0 1 L 10 5 L 0 9 z" fill="${thm.color}"/>
      </marker>
    `;
  });
  defs.innerHTML = markersHtml;
  svgLayer.appendChild(defs);
  canvas.appendChild(svgLayer);

  const nodesLayer = document.createElement('div');
  nodesLayer.className = 'tree-nodes-layer';
  nodesLayer.id = 'tree-nodes-layer';
  canvas.appendChild(nodesLayer);

  treeContainer.appendChild(canvas);
  container.appendChild(treeContainer);

  // Pan & Zoom Event Listeners (Cursor-Anchored & Fluid)
  setupTreeInteractions(treeContainer, canvas);

  // Compute Layout Positions (Parallel Scenario Lanes Engine - Zero Exponential Overflows)
  const layout = computeTreeLayout(entries, appState.treeOrientation);
  const nodePositions = layout.positions;
  const nodeScenarios = layout.nodeScenarios;
  const edgeThemes = layout.edgeThemes;
  const backlinkEdges = layout.backlinkEdges;
  const isConvergenceHub = layout.isConvergenceHub;

  currentGraphTopology.positions = nodePositions;
  currentGraphTopology.forwardChildren = layout.forwardChildren;
  currentGraphTopology.incomingParents = layout.incomingParents;

  const nodeWidth = isHorizontal ? 250 : 240;
  const nodeHeight = isHorizontal ? 105 : 115;

  // Render Node Cards
  entries.forEach(e => {
    const pos = nodePositions[e.id] || { x: 60, y: 60 };
    const card = document.createElement('div');
    const isPlayer = e.isPlayer || e.actorId === 95 || e.actorId === 93;
    const isHub = isConvergenceHub[e.id];
    const scenarioTheme = nodeScenarios[e.id];

    let cardClass = 'tree-node-card';
    if (e.isModInjected) cardClass += ' tree-mod-injected';
    else if (e.isModEdited) cardClass += ' tree-mod-edited';
    if (isPlayer) cardClass += ' tree-player-choice';

    card.className = cardClass;
    card.id = `tree-card-${e.id}`;
    card.style.left = `${pos.x}px`;
    card.style.top = `${pos.y}px`;
    card.style.width = `${nodeWidth}px`;
    card.style.minHeight = `${nodeHeight}px`;

    // Apply scenario-specific border accent if in a scenario track
    if (scenarioTheme && !isHub && !e.isModInjected && !e.isModEdited) {
      if (isHorizontal) {
        card.style.borderLeft = `3px solid ${scenarioTheme.color}`;
      } else {
        card.style.borderTop = `3px solid ${scenarioTheme.color}`;
      }
    }

    const snippet = e.dialogueText || e.menuText || (e.title === 'START' ? 'SCENE START NODE' : 'Logic node');
    const speakerDisplay = isPlayer ? 'Player_Romus' : (e.speaker || `Actor_${e.actorId}`);

    let modBadge = '';
    if (e.isModInjected) modBadge = '<span class="badge badge-modnew" style="font-size:8px;">MOD_INJECTED</span>';
    else if (e.isModEdited) modBadge = '<span class="badge badge-modedit" style="font-size:8px;">MOD_EDITED</span>';

    let scenarioBadge = '';
    if (scenarioTheme && !isHub) {
      scenarioBadge = `<span class="scenario-pill" style="color:${scenarioTheme.color}; border-color:${scenarioTheme.color};">${scenarioTheme.badge}</span>`;
    } else if (isHub) {
      scenarioBadge = `<span class="hub-pill">ZBIEG (HUB)</span>`;
    }

    let condPill = '';
    if (e.conditions && e.conditions.trim()) {
      condPill = `<span class="tree-cond-pill" title="Condition: ${escapeHtml(e.conditions)}">WAR: ${escapeHtml(e.conditions.slice(0, 18))}</span>`;
    }

    let scriptPill = '';
    if (e.userScript && e.userScript.trim()) {
      scriptPill = `<span class="tree-script-pill" title="Skrypt: ${escapeHtml(e.userScript)}">SKR: ${escapeHtml(e.userScript.slice(0, 18))}</span>`;
    }

    card.innerHTML = `
      <div class="tree-card-header">
        <span class="tree-speaker-tag ${isPlayer ? 'speaker-player' : ''}">[#${e.id}] ${escapeHtml(speakerDisplay)}</span>
        <div style="display:flex; align-items:center; gap:4px;">
          ${scenarioBadge}
          ${modBadge}
        </div>
      </div>
      <div class="tree-card-body">${escapeHtml(snippet)}</div>
      ${(condPill || scriptPill) ? `<div style="display:flex; gap:4px; margin-top:4px;">${condPill}${scriptPill}</div>` : ''}
      <div class="tree-card-footer">
        <span>${isPlayer ? 'WYBOR GRACZA' : (isHub ? 'WSPOLNY HUB' : 'DIALOG')}</span>
        <span>${(e.outgoing || []).length} BRANCHES</span>
      </div>
    `;

    // Hover to highlight full scenario path
    card.addEventListener('mouseenter', () => {
      highlightScenarioPath(e.id);
    });
    card.addEventListener('mouseleave', () => {
      clearScenarioHighlight();
    });

    // Click to inspect node (prevented if user was panning/dragging)
    card.addEventListener('click', (ev) => {
      ev.stopPropagation();
      if (appState.didDrag) return;
      openNodeInspector(e.id);
    });

    nodesLayer.appendChild(card);
  });

  // Render SVG Branching Connector Curves
  entries.forEach(e => {
    const srcPos = nodePositions[e.id];
    if (!srcPos) return;

    (e.outgoing || []).forEach(dstId => {
      const dstPos = nodePositions[dstId];
      if (!dstPos) return;

      const edgeKey = `${e.id}->${dstId}`;
      const isBacklink = backlinkEdges.has(edgeKey);
      const theme = edgeThemes[edgeKey] || nodeScenarios[dstId];

      let pathD = '';
      if (isHorizontal) {
        // Horizontal LTR: Left-to-right flow
        const x1 = srcPos.x + nodeWidth;
        const y1 = srcPos.y + nodeHeight / 2;
        const x2 = dstPos.x;
        const y2 = dstPos.y + nodeHeight / 2;

        if (isBacklink || x2 <= x1) {
          const loopHeight = Math.min(100, Math.abs(y2 - y1) + 60);
          pathD = `M ${x1} ${y1} C ${x1 + 60} ${y1 + loopHeight}, ${x2 - 60} ${y2 + loopHeight}, ${x2} ${y2}`;
        } else {
          const dx = Math.max(50, (x2 - x1) * 0.45);
          pathD = `M ${x1} ${y1} C ${x1 + dx} ${y1}, ${x2 - dx} ${y2}, ${x2} ${y2}`;
        }
      } else {
        // Vertical TTB: Top-to-bottom flow
        const x1 = srcPos.x + nodeWidth / 2;
        const y1 = srcPos.y + nodeHeight;
        const x2 = dstPos.x + nodeWidth / 2;
        const y2 = dstPos.y;

        if (isBacklink || y2 <= y1) {
          const loopWidth = Math.min(120, Math.abs(x2 - x1) + 80);
          pathD = `M ${x1} ${y1} C ${x1 + loopWidth} ${y1 + 40}, ${x2 + loopWidth} ${y2 - 40}, ${x2} ${y2}`;
        } else {
          const dy = Math.max(45, (y2 - y1) * 0.45);
          pathD = `M ${x1} ${y1} C ${x1} ${y1 + dy}, ${x2} ${y2 - dy}, ${x2} ${y2}`;
        }
      }

      const path = document.createElementNS('http://www.w3.org/2000/svg', 'path');
      path.setAttribute('d', pathD);
      path.setAttribute('id', `edge-${e.id}-${dstId}`);

      let edgeClass = 'tree-edge';
      if (isBacklink) {
        edgeClass += ' edge-backlink';
        path.setAttribute('marker-end', 'url(#arrow-purple)');
      } else if (e.isPlayer) {
        edgeClass += ' edge-choice';
        path.setAttribute('marker-end', theme ? `url(#arrow-scenario-${SCENARIO_THEMES.indexOf(theme)})` : 'url(#arrow-amber)');
      } else {
        path.setAttribute('marker-end', theme ? `url(#arrow-scenario-${SCENARIO_THEMES.indexOf(theme)})` : 'url(#arrow-cyan)');
      }

      if (theme) {
        path.style.stroke = theme.color;
      }

      path.setAttribute('class', edgeClass);
      svgLayer.appendChild(path);
    });
  });

  // Automatically frame the tree so the start is ALWAYS immediately visible at screen start!
  frameTreeToStart();
  setTimeout(() => frameTreeToStart(), 40);
}

// ================= PARALLEL SCENARIO LANE LAYOUT ENGINE =================

function computeTreeLayout(entries, orientation = 'horizontal') {
  const isHorizontal = orientation !== 'vertical';
  const nodeMap = {};
  entries.forEach(e => { nodeMap[e.id] = e; });

  const root = entries.find(e => e.id === 0) || entries.find(e => e.isRoot) || entries[0];
  const rootId = root ? root.id : (entries[0] ? entries[0].id : 0);

  // 1. Forward DAG vs Backlink Loop Cycle Detection
  const visited = new Set();
  const forwardChildren = {};
  const incomingParents = {};
  const backlinkEdges = new Set();

  entries.forEach(e => {
    forwardChildren[e.id] = [];
    incomingParents[e.id] = [];
  });

  function dfs(nid, pathSet) {
    visited.add(nid);
    const node = nodeMap[nid];
    if (!node) return;
    const outgoing = node.outgoing || [];
    outgoing.forEach(dstId => {
      if (!nodeMap[dstId]) return;
      if (pathSet.has(dstId)) {
        backlinkEdges.add(`${nid}->${dstId}`);
      } else if (visited.has(dstId)) {
        forwardChildren[nid].push(dstId);
        incomingParents[dstId].push(nid);
      } else {
        forwardChildren[nid].push(dstId);
        incomingParents[dstId].push(nid);
        const nextPath = new Set(pathSet);
        nextPath.add(nid);
        dfs(dstId, nextPath);
      }
    });
  }

  if (nodeMap[rootId]) {
    dfs(rootId, new Set([rootId]));
  }

  // Cover any disconnected / orphan nodes
  entries.forEach(e => {
    if (!visited.has(e.id)) {
      dfs(e.id, new Set([e.id]));
    }
  });

  // 2. Assign Stages (Topological depth along primary progression axis)
  const stages = {};
  entries.forEach(e => { stages[e.id] = 0; });
  let changed = true;
  for (let iter = 0; iter < entries.length + 5 && changed; iter++) {
    changed = false;
    for (const [src, children] of Object.entries(forwardChildren)) {
      const srcStage = stages[src];
      children.forEach(dst => {
        if (stages[dst] < srcStage + 1) {
          stages[dst] = srcStage + 1;
          changed = true;
        }
      });
    }
  }

  // Identify Convergence Hubs (nodes with >1 incoming forward parents)
  const isConvergenceHub = {};
  entries.forEach(e => {
    if ((incomingParents[e.id] || []).length > 1) {
      isConvergenceHub[e.id] = true;
    }
  });

  // 3. Scenario Color & Track Propagation
  const nodeScenarios = {};
  const edgeThemes = {};

  entries.forEach(e => {
    const children = forwardChildren[e.id] || [];
    if (children.length > 1) {
      children.forEach((cId, idx) => {
        const theme = SCENARIO_THEMES[idx % SCENARIO_THEMES.length];
        edgeThemes[`${e.id}->${cId}`] = theme;

        const queue = [cId];
        const branchVisited = new Set();
        while (queue.length > 0) {
          const curr = queue.shift();
          if (branchVisited.has(curr)) continue;
          branchVisited.add(curr);

          if (isConvergenceHub[curr]) {
            continue;
          }

          nodeScenarios[curr] = theme;
          (forwardChildren[curr] || []).forEach(nxt => {
            edgeThemes[`${curr}->${nxt}`] = theme;
            queue.push(nxt);
          });
        }
      });
    }
  });

  // 4. Parallel Track Allocation (Linear Non-Exponential Tracking)
  const tracks = {};
  let nextFreeTrack = 0;

  function assignTracks() {
    const queue = [rootId];
    tracks[rootId] = 0;
    const trackVisited = new Set();

    while (queue.length > 0) {
      const nid = queue.shift();
      if (trackVisited.has(nid)) continue;
      trackVisited.add(nid);

      const myTrack = tracks[nid] !== undefined ? tracks[nid] : 0;
      const ch = forwardChildren[nid] || [];

      if (ch.length === 1) {
        const c = ch[0];
        if (tracks[c] === undefined) {
          tracks[c] = myTrack;
        }
        queue.push(c);
      } else if (ch.length > 1) {
        // Multi-choice branching: allocate distinct parallel scenario tracks!
        ch.forEach((c, idx) => {
          if (tracks[c] === undefined) {
            if (idx === 0) {
              tracks[c] = myTrack;
            } else {
              nextFreeTrack += 1;
              tracks[c] = nextFreeTrack;
            }
          }
          queue.push(c);
        });
      }
    }
  }

  assignTracks();

  // 5. Hub Centering: Convergence hubs are centered across all incoming branch tracks
  entries.forEach(e => {
    const parents = incomingParents[e.id] || [];
    if (parents.length > 1) {
      const pTracks = parents.filter(p => tracks[p] !== undefined).map(p => tracks[p]);
      if (pTracks.length > 0) {
        tracks[e.id] = pTracks.reduce((a, b) => a + b, 0) / pTracks.length;
      }
    }
  });

  // Allocate any unplaced orphan nodes
  entries.forEach(e => {
    if (tracks[e.id] === undefined) {
      nextFreeTrack += 1;
      tracks[e.id] = nextFreeTrack;
    }
  });

  // 6. Stage Grouping & Collision Clearance
  const stageBuckets = {};
  Object.entries(stages).forEach(([nid, st]) => {
    if (!stageBuckets[st]) stageBuckets[st] = [];
    stageBuckets[st].push(Number(nid));
  });

  const lanePos = {};
  Object.values(stageBuckets).forEach(nids => {
    nids.sort((a, b) => tracks[a] - tracks[b]);
    let currY = 0.0;
    nids.forEach((nid, i) => {
      const targetTrack = tracks[nid];
      if (i > 0 && targetTrack < currY + 1.0) {
        currY += 1.0;
      } else {
        currY = Math.max(currY, targetTrack);
      }
      lanePos[nid] = currY;
    });
  });

  // 7. Calculate Raw (X, Y) Coordinates
  const colStep = isHorizontal ? 320 : 260;
  const rowStep = isHorizontal ? 145 : 175;

  const rawPos = {};
  entries.forEach(e => {
    const st = stages[e.id] || 0;
    const lp = lanePos[e.id] || 0;
    if (isHorizontal) {
      rawPos[e.id] = { x: st * colStep, y: lp * rowStep };
    } else {
      rawPos[e.id] = { x: lp * colStep, y: st * rowStep };
    }
  });

  // 8. MATHEMATICAL NORMALIZATION: Minimum coordinates are ALWAYS shifted to (60, 60)
  const minX = Math.min(...Object.values(rawPos).map(p => p.x));
  const minY = Math.min(...Object.values(rawPos).map(p => p.y));

  const positions = {};
  entries.forEach(e => {
    positions[e.id] = {
      x: rawPos[e.id].x - minX + 60,
      y: rawPos[e.id].y - minY + 60
    };
  });

  return {
    positions,
    nodeScenarios,
    edgeThemes,
    backlinkEdges,
    isConvergenceHub,
    forwardChildren,
    incomingParents
  };
}

// ================= SCENARIO PATH HIGHLIGHTING =================

function highlightScenarioPath(selectedNodeId) {
  appState.highlightedScenarioNodeId = selectedNodeId;
  const { forwardChildren, incomingParents } = currentGraphTopology;
  if (!forwardChildren || !incomingParents) return;

  const ancestors = new Set();
  const upQueue = [selectedNodeId];
  while (upQueue.length > 0) {
    const curr = upQueue.shift();
    ancestors.add(curr);
    (incomingParents[curr] || []).forEach(p => {
      if (!ancestors.has(p)) upQueue.push(p);
    });
  }

  const descendants = new Set();
  const downQueue = [selectedNodeId];
  while (downQueue.length > 0) {
    const curr = downQueue.shift();
    descendants.add(curr);
    (forwardChildren[curr] || []).forEach(c => {
      if (!descendants.has(c)) downQueue.push(c);
    });
  }

  const activePathNodes = new Set([...ancestors, ...descendants]);

  document.querySelectorAll('.tree-node-card').forEach(card => {
    const nid = Number(card.id.replace('tree-card-', ''));
    if (activePathNodes.has(nid)) {
      card.classList.add('scenario-active');
      card.classList.remove('scenario-dimmed');
    } else {
      card.classList.add('scenario-dimmed');
      card.classList.remove('scenario-active');
    }
  });

  document.querySelectorAll('.tree-edge').forEach(edge => {
    const parts = edge.id.replace('edge-', '').split('-');
    const src = Number(parts[0]);
    const dst = Number(parts[1]);
    if (activePathNodes.has(src) && activePathNodes.has(dst)) {
      edge.classList.add('scenario-active');
      edge.classList.remove('scenario-dimmed');
    } else {
      edge.classList.add('scenario-dimmed');
      edge.classList.remove('scenario-active');
    }
  });
}

function clearScenarioHighlight() {
  if (appState.activeSelectedNodeId) return;
  appState.highlightedScenarioNodeId = null;
  document.querySelectorAll('.tree-node-card').forEach(c => {
    c.classList.remove('scenario-active', 'scenario-dimmed');
  });
  document.querySelectorAll('.tree-edge').forEach(e => {
    e.classList.remove('scenario-active', 'scenario-dimmed');
  });
}

// ================= FLUID PAN & CURSOR-ANCHORED ZOOM ENGINE =================

let isTreePanning = false;
let panStartX = 0;
let panStartY = 0;
let initialPanX = 0;
let initialPanY = 0;
let isSpaceKeyPressed = false;

function setupTreeInteractions(container, canvas) {
  // Track spacebar for pan tool
  window.addEventListener('keydown', (e) => {
    if (e.code === 'Space' && !e.target.matches('input, textarea')) {
      isSpaceKeyPressed = true;
      container.style.cursor = 'grab';
    }
    // Keyboard navigation shortcuts
    if (!e.target.matches('input, textarea')) {
      if (e.key === '=' || e.key === '+') {
        e.preventDefault();
        zoomTreeAtPoint(1.15);
      } else if (e.key === '-' || e.key === '_') {
        e.preventDefault();
        zoomTreeAtPoint(0.85);
      } else if (e.key === '0') {
        e.preventDefault();
        resetTreeZoom();
      } else if (e.key === 'h' || e.key === 'H') {
        e.preventDefault();
        frameTreeToStart();
      } else if (e.key === 'f' || e.key === 'F') {
        e.preventDefault();
        fitTreeToView();
      } else if (e.key === 'ArrowRight') {
        e.preventDefault();
        appState.treePanX -= 80;
        applyTreeTransform();
      } else if (e.key === 'ArrowLeft') {
        e.preventDefault();
        appState.treePanX += 80;
        applyTreeTransform();
      } else if (e.key === 'ArrowDown') {
        e.preventDefault();
        appState.treePanY -= 80;
        applyTreeTransform();
      } else if (e.key === 'ArrowUp') {
        e.preventDefault();
        appState.treePanY += 80;
        applyTreeTransform();
      }
    }
  });

  window.addEventListener('keyup', (e) => {
    if (e.code === 'Space') {
      isSpaceKeyPressed = false;
      if (!isTreePanning) container.style.cursor = '';
    }
  });

  // MOUSE DOWN: Start Pan
  container.addEventListener('mousedown', (e) => {
    // Check if middle click or spacebar or clicking canvas background
    const isMiddleClick = (e.button === 1);
    const isLeftOnBackground = (e.button === 0 && !e.target.closest('.tree-node-card') && !e.target.closest('.tree-hud-controls'));
    const isSpaceDrag = (e.button === 0 && isSpaceKeyPressed);

    if (isMiddleClick || isLeftOnBackground || isSpaceDrag) {
      isTreePanning = true;
      appState.didDrag = false;
      panStartX = e.clientX;
      panStartY = e.clientY;
      initialPanX = appState.treePanX;
      initialPanY = appState.treePanY;
      container.classList.add('panning');
      e.preventDefault();
    }
  });

  // MOUSE MOVE: Pan smoothly
  window.addEventListener('mousemove', (e) => {
    if (!isTreePanning) return;
    const dx = e.clientX - panStartX;
    const dy = e.clientY - panStartY;

    if (Math.hypot(dx, dy) > 4) {
      appState.didDrag = true;
    }

    appState.treePanX = initialPanX + dx;
    appState.treePanY = initialPanY + dy;
    applyTreeTransform();
  });

  // MOUSE UP: Stop Pan
  window.addEventListener('mouseup', () => {
    if (isTreePanning) {
      isTreePanning = false;
      container.classList.remove('panning');
      container.style.cursor = isSpaceKeyPressed ? 'grab' : '';
      setTimeout(() => { appState.didDrag = false; }, 50);
    }
  });

  // WHEEL: CURSOR-ANCHORED ZOOM & TOUCHPAD PANNING
  container.addEventListener('wheel', (e) => {
    e.preventDefault();

    if (e.ctrlKey) {
      // Touchpad Pinch-to-Zoom
      const factor = Math.exp(-e.deltaY * 0.01);
      zoomTreeAtPoint(factor, e.clientX, e.clientY);
    } else if (Math.abs(e.deltaX) > 0 || (e.shiftKey && Math.abs(e.deltaY) > 0)) {
      // Touchpad Two-Finger Pan or Shift+Scroll
      const dx = e.shiftKey ? e.deltaY : e.deltaX;
      const dy = e.shiftKey ? 0 : e.deltaY;
      appState.treePanX -= dx;
      appState.treePanY -= dy;
      applyTreeTransform();
    } else {
      // Standard Mouse Wheel: Zoom Directly Towards Cursor!
      const factor = e.deltaY < 0 ? 1.12 : 0.89;
      zoomTreeAtPoint(factor, e.clientX, e.clientY);
    }
  }, { passive: false });
}

// Cursor-Anchored Zoom Formula (Figma / Miro style)
function zoomTreeAtPoint(factor, clientX, clientY) {
  const container = document.getElementById('tree-view-container');
  if (!container) return;
  const rect = container.getBoundingClientRect();

  const cx = (clientX !== undefined ? clientX : rect.left + rect.width / 2) - rect.left;
  const cy = (clientY !== undefined ? clientY : rect.top + rect.height / 2) - rect.top;

  const oldZoom = appState.treeZoom;
  const newZoom = Math.min(2.5, Math.max(0.15, oldZoom * factor));
  if (Math.abs(newZoom - oldZoom) < 0.001) return;

  // Exact point on the canvas under mouse pointer before zooming
  const wx = (cx - appState.treePanX) / oldZoom;
  const wy = (cy - appState.treePanY) / oldZoom;

  // New pan coordinates so the exact same canvas point remains under cursor
  appState.treeZoom = newZoom;
  appState.treePanX = cx - wx * newZoom;
  appState.treePanY = cy - wy * newZoom;

  applyTreeTransform();
}

function resetTreeZoom() {
  const container = document.getElementById('tree-view-container');
  if (!container) return;
  zoomTreeAtPoint(1.0 / appState.treeZoom, undefined, undefined);
  appState.treeZoom = 1.0;
  applyTreeTransform();
}

function fitTreeToView() {
  const container = document.getElementById('tree-view-container');
  if (!container || !currentGraphTopology.positions) return;

  const posList = Object.values(currentGraphTopology.positions);
  if (posList.length === 0) return;

  const nodeWidth = 250;
  const nodeHeight = 115;
  const maxX = Math.max(...posList.map(p => p.x)) + nodeWidth + 60;
  const maxY = Math.max(...posList.map(p => p.y)) + nodeHeight + 60;

  const cw = container.clientWidth || 1000;
  const ch = container.clientHeight || 700;

  const scaleX = (cw - 80) / maxX;
  const scaleY = (ch - 80) / maxY;
  appState.treeZoom = Math.min(1.0, Math.max(0.18, Math.min(scaleX, scaleY)));

  appState.treePanX = 40;
  appState.treePanY = 40;
  applyTreeTransform();
}

function applyTreeTransform() {
  const canvas = document.getElementById('tree-canvas');
  if (canvas) {
    canvas.style.transform = `translate(${appState.treePanX}px, ${appState.treePanY}px) scale(${appState.treeZoom})`;
  }

  // Update background grid position on container
  const container = document.getElementById('tree-view-container');
  if (container) {
    const gridScale = Math.max(12, 24 * appState.treeZoom);
    container.style.backgroundPosition = `${appState.treePanX}px ${appState.treePanY}px`;
    container.style.backgroundSize = `${gridScale}px ${gridScale}px, ${gridScale * 5}px ${gridScale * 5}px, ${gridScale * 5}px ${gridScale * 5}px`;
  }

  // Update Zoom Telemetry indicator
  const zoomPill = document.getElementById('tree-zoom-val');
  if (zoomPill) {
    zoomPill.textContent = `${Math.round(appState.treeZoom * 100)}%`;
  }
}

// ================= QUICK NODE INSPECTOR DRAWER =================

function openNodeInspector(entryId) {
  appState.activeSelectedNodeId = entryId;
  const entry = appState.activeItemFull.entries.find(e => e.id === entryId);
  if (!entry) return;

  // Highlight card in tree
  document.querySelectorAll('.tree-node-card').forEach(c => c.classList.remove('active-tree-node'));
  const activeCard = document.getElementById(`tree-card-${entryId}`);
  if (activeCard) activeCard.classList.add('active-tree-node');

  // Highlight scenario path across tree
  highlightScenarioPath(entryId);

  // Highlight connecting edges
  document.querySelectorAll('.tree-edge').forEach(ed => ed.classList.remove('highlighted'));
  (entry.outgoing || []).forEach(dstId => {
    const ed = document.getElementById(`edge-${entry.id}-${dstId}`);
    if (ed) ed.classList.add('highlighted');
  });

  const drawer = document.getElementById('node-inspector-drawer');
  drawer.classList.add('open');

  const isPlayer = entry.isPlayer || entry.actorId === 95 || entry.actorId === 93;

  document.getElementById('drawer-body-content').innerHTML = `
    <div>
      <div class="field-label">
        <span>NODE ID [${entry.id}] // SPEAKER:</span>
      </div>
      <select class="node-input-txt" onchange="updateNodeSpeaker(${entry.id}, this.value)">
        ${renderActorOptions(entry.actorId)}
      </select>
    </div>

    <div>
      <label style="display: flex; align-items: center; gap: 8px; font-family: var(--font-mono); font-size: 11px; cursor: pointer;">
        <input type="checkbox" ${isPlayer ? 'checked' : ''} onchange="toggleNodePlayerChoice(${entry.id}, this.checked)">
        <span>PLAYER CHOICE (PLAYER_CHOICE)</span>
      </label>
    </div>

    <div>
      <label class="field-label">CHARACTER LINE (DIALOGUE_TEXT):</label>
      <textarea class="node-text-area" oninput="updateNodeField(${entry.id}, 'dialogueText', this.value); refreshTreeCardSnippet(${entry.id});">${escapeHtml(entry.dialogueText || '')}</textarea>
    </div>

    <div style="display: ${isPlayer ? 'block' : 'none'};" id="drawer-menu-wrap-${entry.id}">
      <label class="field-label">PLAYER MENU OPTION (MENU_TEXT):</label>
      <input type="text" class="node-input-txt" value="${escapeHtml(entry.menuText || '')}" oninput="updateNodeField(${entry.id}, 'menuText', this.value); refreshTreeCardSnippet(${entry.id});" placeholder="e.g. &quot;Zille must return to the Kingdom.&quot;">
    </div>

    <div>
      <div class="field-label">
        <span>CONDITION (PREREQUISITE / CONDITION):</span>
      </div>
      <div style="display:flex; gap:6px;">
        <input type="text" id="drawer-cond-input-${entry.id}" class="node-input-txt code-field" value="${escapeHtml(entry.conditions || '')}" oninput="updateNodeField(${entry.id}, 'conditions', this.value)">
        <button class="btn-tag-insert" onclick="openTagPicker('drawer-cond-input-${entry.id}', ${entry.id}, 'conditions')">TAG</button>
      </div>
    </div>

    <div>
      <div class="field-label">
        <span>SCRIPT EFFECT (USERSCRIPT):</span>
      </div>
      <div style="display:flex; gap:6px;">
        <input type="text" id="drawer-script-input-${entry.id}" class="node-input-txt code-field" value="${escapeHtml(entry.userScript || '')}" oninput="updateNodeField(${entry.id}, 'userScript', this.value)">
        <button class="btn-tag-insert" onclick="openTagPicker('drawer-script-input-${entry.id}', ${entry.id}, 'userScript')">VAR</button>
      </div>
    </div>

    <div>
      <div class="field-label">NEXT NODES (OUTGOING_LINKS):</div>
      <input type="text" class="node-input-txt code-field" value="${(entry.outgoing || []).join(', ')}" onchange="updateNodeOutgoingLinks(${entry.id}, this.value)" placeholder="e.g. 20, 21, 22">
    </div>

    <div style="display:flex; justify-content:space-between; margin-top:14px; padding-top:12px; border-top:1px solid var(--border-dim);">
      <button class="btn-act" onclick="deleteDialogueNode(${entry.id})" style="border-color: var(--neon-crimson); color: var(--neon-crimson);">DELETE NODE</button>
      <button class="btn-act btn-save-master" onclick="saveCurrentItem()">SAVE (CTRL+S)</button>
    </div>
  `;
}

function refreshTreeCardSnippet(entryId) {
  const card = document.getElementById(`tree-card-${entryId}`);
  const entry = appState.activeItemFull.entries.find(e => e.id === entryId);
  if (card && entry) {
    const body = card.querySelector('.tree-card-body');
    if (body) body.textContent = entry.dialogueText || entry.menuText || '';
  }
}

function closeInspectorDrawer() {
  appState.activeSelectedNodeId = null;
  const drawer = document.getElementById('node-inspector-drawer');
  if (drawer) drawer.classList.remove('open');
  document.querySelectorAll('.tree-node-card').forEach(c => c.classList.remove('active-tree-node'));
  document.querySelectorAll('.tree-edge').forEach(ed => ed.classList.remove('highlighted'));
  clearScenarioHighlight();
}

// ================= CARD LIST VIEW =================

function renderCardListView(container, conv, entries) {
  const listContainer = document.createElement('div');
  listContainer.className = 'list-view-container';

  if (!entries || entries.length === 0) {
    listContainer.innerHTML = `
      <div style="padding: 40px; text-align: center; color: var(--text-dim); font-family: var(--font-mono);">
        BRAK WEZLOW DIALOGOWYCH W TYM WIDOKU
      </div>
    `;
    container.appendChild(listContainer);
    return;
  }

  listContainer.innerHTML = entries.map(entry => {
    const isPlayer = entry.isPlayer || entry.actorId === 95 || entry.actorId === 93;
    const isNarrator = entry.actorId === 10;
    let cardClass = 'node-card';
    if (entry.isModInjected) cardClass += ' node-mod-injected';
    else if (entry.isModEdited) cardClass += ' node-mod-edited';
    if (isPlayer) cardClass += ' node-player';
    else if (isNarrator) cardClass += ' node-narrator';
    else cardClass += ' node-council';

    let modIndicator = '';
    if (entry.isModInjected) {
      modIndicator = `<span class="badge badge-injected">[MOD_INJECTED]</span>`;
    } else if (entry.isModEdited) {
      modIndicator = `<span class="badge badge-modedit">[MOD_EDITED]</span>`;
    }

    const outgoingLinksHtml = (entry.outgoing || []).map(destId => `
      <span class="link-pill" onclick="scrollToNode(${destId})" title="Jump to [#${destId}]">
        ${ICONS.link} [${destId}]
      </span>
    `).join(' ');

    return `
      <div class="${cardClass}" id="node-entry-${entry.id}">
        <div class="node-top-bar">
          <div class="node-speaker-ctrl">
            <div class="actor-icon-box">${isPlayer ? ICONS.player : (isNarrator ? ICONS.narrator : ICONS.council)}</div>
            <select class="speaker-select" onchange="updateNodeSpeaker(${entry.id}, this.value)">
              ${renderActorOptions(entry.actorId)}
            </select>
            <span class="node-id-lbl">[#${entry.id}]</span>
            ${modIndicator}
            <label style="display: flex; align-items: center; gap: 6px; font-family: var(--font-mono); font-size: 10px; cursor: pointer;">
              <input type="checkbox" ${isPlayer ? 'checked' : ''} onchange="toggleNodePlayerChoice(${entry.id}, this.checked)">
              <span>PLAYER_CHOICE</span>
            </label>
          </div>
          <div>
            <button class="tree-ctrl-btn" onclick="deleteDialogueNode(${entry.id})" title="Delete node">${ICONS.trash}</button>
          </div>
        </div>

        <div>
          <label class="field-label">CHARACTER LINE (DIALOGUE_TEXT):</label>
          <textarea class="node-text-area" oninput="updateNodeField(${entry.id}, 'dialogueText', this.value)">${escapeHtml(entry.dialogueText || '')}</textarea>
        </div>

        <div style="display: ${isPlayer ? 'block' : 'none'};" id="menu-text-wrap-${entry.id}">
          <label class="field-label">PLAYER MENU OPTION (MENU_TEXT):</label>
          <input type="text" class="node-input-txt" value="${escapeHtml(entry.menuText || '')}" oninput="updateNodeField(${entry.id}, 'menuText', this.value)" placeholder="e.g. &quot;Zille must return to the Kingdom.&quot;">
        </div>

        <div>
          <div class="field-label">
            <span>UNLOCK CONDITION (PREREQUISITE / CONDITIONS):</span>
          </div>
          <div style="display: flex; gap: 6px;">
            <input type="text" id="cond-input-${entry.id}" class="node-input-txt code-field" value="${escapeHtml(entry.conditions || '')}" oninput="updateNodeField(${entry.id}, 'conditions', this.value)" placeholder="e.g. Variable['RiziaDLC.Resources_Budget'] >= 2">
            <button class="btn-tag-insert" onclick="openTagPicker('cond-input-${entry.id}', ${entry.id}, 'conditions')">TAG</button>
          </div>
        </div>

        <div>
          <div class="field-label">
            <span>SCRIPT EFFECT (USERSCRIPT):</span>
          </div>
          <div style="display: flex; gap: 6px;">
            <input type="text" id="script-input-${entry.id}" class="node-input-txt code-field" value="${escapeHtml(entry.userScript || '')}" oninput="updateNodeField(${entry.id}, 'userScript', this.value)" placeholder="e.g. Variable['Zille_War_Alfa'] = true;">
            <button class="btn-tag-insert" onclick="openTagPicker('script-input-${entry.id}', ${entry.id}, 'userScript')">VAR</button>
          </div>
        </div>

        <div class="outgoing-nav-row">
          <span>NEXT NODES:</span>
          <div style="display: flex; gap: 4px; flex-wrap: wrap;">
            ${outgoingLinksHtml || '<span style="color: var(--text-dim); font-size: 10px;">[KONIEC SCIEZKI]</span>'}
          </div>
          <input type="text" style="width: 130px; margin-left: auto;" class="node-input-txt code-field" value="${(entry.outgoing || []).join(', ')}" onchange="updateNodeOutgoingLinks(${entry.id}, this.value)" placeholder="e.g. 20, 21">
        </div>
      </div>
    `;
  }).join('');

  container.appendChild(listContainer);
}

function renderActorOptions(currentActorId) {
  const commonActors = [
    { id: 95, name: 'Player_Romus' },
    { id: 10, name: 'Narrator' },
    { id: 68, name: 'Hugo Toras' },
    { id: 73, name: 'Lucita Azaro' },
    { id: 80, name: 'Elena Werner' },
    { id: 70, name: 'Laurento Esquibel' },
    { id: 81, name: 'Titus Gordion' },
    { id: 75, name: 'Manus Sazon' },
    { id: 98, name: 'Angelica Sazon' },
    { id: 77, name: 'Wiktor Smolak' },
    { id: 99, name: 'Patricio Alvarez' },
    { id: 78, name: 'Emmerich Hegel' },
    { id: 92, name: 'Beatrice Livingston' },
    { id: 64, name: 'Queen Mother Estela' },
    { id: 79, name: 'Princess Vina' }
  ];

  return commonActors.map(a => `<option value="${a.id}" ${Number(currentActorId) === a.id ? 'selected' : ''}>${a.name}</option>`).join('');
}

function updateNodeSpeaker(entryId, newActorId) {
  const entry = appState.activeItemFull.entries.find(e => e.id === entryId);
  if (entry) {
    entry.actorId = Number(newActorId);
    entry.speaker = appState.actors[newActorId] || `Actor_${newActorId}`;
    entry.isModEdited = true;
    renderConversationWorkspace(appState.activeItemFull);
  }
}

function toggleNodePlayerChoice(entryId, isChecked) {
  const entry = appState.activeItemFull.entries.find(e => e.id === entryId);
  if (entry) {
    entry.isPlayer = isChecked;
    if (isChecked) {
      entry.actorId = 95;
      entry.speaker = 'Player_Romus';
    }
    entry.isModEdited = true;
    renderConversationWorkspace(appState.activeItemFull);
  }
}

function updateNodeField(entryId, fieldName, value) {
  const entry = appState.activeItemFull.entries.find(e => e.id === entryId);
  if (entry) {
    entry[fieldName] = value;
    entry.isModEdited = true;
  }
}

function updateNodeOutgoingLinks(entryId, csvValue) {
  const entry = appState.activeItemFull.entries.find(e => e.id === entryId);
  if (entry) {
    const list = csvValue.split(',').map(s => parseInt(s.trim())).filter(n => !isNaN(n));
    entry.outgoing = list;
    entry.isModEdited = true;
    renderConversationWorkspace(appState.activeItemFull);
  }
}

function addNewDialogueNode(isPlayerChoice) {
  if (!appState.activeItemFull) return;
  const entries = appState.activeItemFull.entries;
  const maxId = entries.length > 0 ? Math.max(...entries.map(e => e.id)) : 0;
  const newId = maxId + 1;

  const newEntry = {
    id: newId,
    actorId: isPlayerChoice ? 95 : 10,
    speaker: isPlayerChoice ? 'Player_Romus' : 'Narrator',
    title: isPlayerChoice ? `Choice_${newId}` : `Line_${newId}`,
    dialogueText: isPlayerChoice ? 'Nowy wybor dialogowy Romusa...' : 'Nowa kwestia dialogowa...',
    menuText: isPlayerChoice ? '"Nowy wybor dialogowy Romusa..."' : '',
    conditions: '',
    userScript: '',
    outgoing: [],
    isPlayer: isPlayerChoice,
    isModInjected: true,
    isModEdited: true,
    isRoot: false
  };

  // Automatically link to currently selected node if active
  if (appState.activeSelectedNodeId) {
    const parentNode = entries.find(e => e.id === appState.activeSelectedNodeId);
    if (parentNode) {
      parentNode.outgoing = parentNode.outgoing || [];
      if (!parentNode.outgoing.includes(newId)) {
        parentNode.outgoing.push(newId);
      }
      parentNode.isModEdited = true;
    }
  }

  entries.push(newEntry);
  renderConversationWorkspace(appState.activeItemFull);
  openNodeInspector(newId);
  showToast(`Dodano nowy wezel [#${newId}]`, 'info');
}

function deleteDialogueNode(entryId) {
  if (!appState.activeItemFull) return;
  if (!confirm(`Potwierdz usuniecie wezla [#${entryId}]?`)) return;
  appState.activeItemFull.entries = appState.activeItemFull.entries.filter(e => e.id !== entryId);
  // Clean up any references in other nodes' outgoing links
  appState.activeItemFull.entries.forEach(e => {
    if (e.outgoing) {
      e.outgoing = e.outgoing.filter(id => id !== entryId);
    }
  });
  closeInspectorDrawer();
  renderConversationWorkspace(appState.activeItemFull);
  showToast(`Usunieto wezel [#${entryId}]`, 'info');
}

function scrollToNode(entryId) {
  if (appState.viewMode === 'tree') {
    openNodeInspector(entryId);
    const card = document.getElementById(`tree-card-${entryId}`);
    if (card) {
      appState.treePanX = -parseInt(card.style.left) + 200;
      appState.treePanY = -parseInt(card.style.top) + 200;
      applyTreeTransform();
    }
  } else {
    const el = document.getElementById(`node-entry-${entryId}`);
    if (el) {
      el.scrollIntoView({ behavior: 'smooth', block: 'center' });
      el.style.borderColor = 'var(--neon-cyan)';
      setTimeout(() => { el.style.borderColor = ''; }, 1500);
    }
  }
}

// ================= DECISION / REPORT / SITUATION WORKSPACES =================

function renderDecisionWorkspace(dec) {
  appState.activeItemFull = JSON.parse(JSON.stringify(dec));
  const container = document.getElementById('workspace-content');

  const optionsHtml = (appState.activeItemFull.options || []).map((opt, idx) => `
    <div style="background:var(--bg-deep); border:1px solid var(--border-dim); border-radius:4px; padding:12px; display:flex; flex-direction:column; gap:8px;">
      <div style="display:flex; justify-content:space-between; align-items:center;">
        <span style="font-family:var(--font-mono); font-size:11px; font-weight:700; color:var(--neon-amber);">OPTION #${idx + 1}</span>
        <button class="tree-ctrl-btn" onclick="deleteDecisionOption(${idx})">${ICONS.trash}</button>
      </div>

      <div>
        <label class="field-label">DECISION BUTTON TEXT:</label>
        <input type="text" class="node-input-txt" value="${escapeHtml(opt.text || '')}" oninput="updateDecisionOption(${idx}, 'text', this.value)">
      </div>

      <div>
        <div class="field-label">UNLOCK CONDITION (CONDITION):</div>
        <div style="display:flex; gap:6px;">
          <input type="text" id="dec-opt-cond-${idx}" class="node-input-txt code-field" value="${escapeHtml(opt.condition || '')}" oninput="updateDecisionOption(${idx}, 'condition', this.value)">
          <button class="btn-tag-insert" onclick="openTagPicker('dec-opt-cond-${idx}', null, null, (tag) => { updateDecisionOption(${idx}, 'condition', tag); })">TAG</button>
        </div>
      </div>

      <div>
        <div class="field-label">EFFECT / INSTRUCTION:</div>
        <textarea class="node-text-area code-field" style="min-height:45px;" oninput="updateDecisionOption(${idx}, 'instruction', this.value)">${escapeHtml(opt.instruction || '')}</textarea>
      </div>
    </div>
  `).join('');

  container.innerHTML = `
    <div class="list-view-container">
      <div class="pane-block">
        <div class="pane-title">DECISION PARAMETERS</div>
        <div>
          <label class="field-label">DECISION TITLE:</label>
          <input type="text" class="node-input-txt" value="${escapeHtml(dec.title || '')}" oninput="appState.activeItemFull.title = this.value">
        </div>
        <div>
          <label class="field-label">NARRATIVE DESCRIPTION:</label>
          <textarea class="node-text-area" style="min-height:80px;" oninput="appState.activeItemFull.description = this.value">${escapeHtml(dec.description || '')}</textarea>
        </div>
        <div>
          <div class="field-label">APPEARANCE CONDITION (STORY_FRAGMENT_CONDITION):</div>
          <div style="display:flex; gap:6px;">
            <input type="text" id="dec-main-cond" class="node-input-txt code-field" value="${escapeHtml(dec.condition || '')}" oninput="appState.activeItemFull.condition = this.value">
            <button class="btn-tag-insert" onclick="openTagPicker('dec-main-cond', null, null, (tag) => { appState.activeItemFull.condition = tag; document.getElementById('dec-main-cond').value = tag; })">TAG</button>
          </div>
        </div>
      </div>

      <div class="pane-block">
        <div class="pane-title">
          <span>CHOICE OPTIONS</span>
          <button class="btn-act" onclick="addNewDecisionOption()">+ OPTION</button>
        </div>
        <div style="display:flex; flex-direction:column; gap:10px;">
          ${optionsHtml || '<p style="color:var(--text-dim); font-family:var(--font-mono); font-size:11px;">BRAK OPCJI</p>'}
        </div>
      </div>
    </div>
  `;
}

function updateDecisionOption(idx, field, value) {
  if (appState.activeItemFull && appState.activeItemFull.options && appState.activeItemFull.options[idx]) {
    appState.activeItemFull.options[idx][field] = value;
  }
}

function addNewDecisionOption() {
  if (!appState.activeItemFull) return;
  appState.activeItemFull.options = appState.activeItemFull.options || [];
  appState.activeItemFull.options.push({ text: 'Nowa opcja decyzji...', condition: '', instruction: '' });
  renderDecisionWorkspace(appState.activeItemFull);
}

function deleteDecisionOption(idx) {
  if (!appState.activeItemFull || !appState.activeItemFull.options) return;
  appState.activeItemFull.options.splice(idx, 1);
  renderDecisionWorkspace(appState.activeItemFull);
}

function renderReportWorkspace(rep) {
  appState.activeItemFull = JSON.parse(JSON.stringify(rep));
  const container = document.getElementById('workspace-content');

  container.innerHTML = `
    <div class="list-view-container">
      <div class="pane-block">
        <div class="pane-title">STAFF / PRESS REPORT EDITOR</div>
        <div>
          <label class="field-label">REPORT TITLE:</label>
          <input type="text" class="node-input-txt" value="${escapeHtml(rep.title || '')}" oninput="appState.activeItemFull.title = this.value">
        </div>
        <div>
          <label class="field-label">REPORT CONTENT:</label>
          <textarea class="node-text-area" style="min-height:100px;" oninput="appState.activeItemFull.description = this.value">${escapeHtml(rep.description || '')}</textarea>
        </div>
        <div>
          <label class="field-label">GAME TURN:</label>
          <input type="number" class="node-input-txt" style="width:100px;" value="${rep.turn || -1}" oninput="appState.activeItemFull.turn = parseInt(this.value)">
        </div>
        <div>
          <div class="field-label">ACTIVATING VARIABLE (IS_ENABLED_VARIABLE):</div>
          <div style="display:flex; gap:6px;">
            <input type="text" id="rep-cond-input" class="node-input-txt code-field" value="${escapeHtml(rep.condition || '')}" oninput="appState.activeItemFull.condition = this.value">
            <button class="btn-tag-insert" onclick="openTagPicker('rep-cond-input', null, null, (tag) => { appState.activeItemFull.condition = tag; document.getElementById('rep-cond-input').value = tag; })">TAG</button>
          </div>
        </div>
      </div>
    </div>
  `;
}

function renderSituationWorkspace(sit) {
  appState.activeItemFull = JSON.parse(JSON.stringify(sit));
  const container = document.getElementById('workspace-content');

  container.innerHTML = `
    <div class="list-view-container">
      <div class="pane-block">
        <div class="pane-title">COUNTRY SITUATION // MODIFIER EDITOR</div>
        <div>
          <label class="field-label">SITUATION TITLE:</label>
          <input type="text" class="node-input-txt" value="${escapeHtml(sit.title || '')}" oninput="appState.activeItemFull.title = this.value">
        </div>
        <div>
          <label class="field-label">NATIONAL IMPACT DESCRIPTION:</label>
          <textarea class="node-text-area" style="min-height:80px;" oninput="appState.activeItemFull.description = this.value">${escapeHtml(sit.description || '')}</textarea>
        </div>
        <div style="display:flex; gap:12px;">
          <div style="flex:1;">
            <label class="field-label">SEVERITY:</label>
            <select class="node-input-txt" onchange="appState.activeItemFull.severity = this.value">
              <option value="VeryGood" ${sit.severity === 'VeryGood' ? 'selected' : ''}>VeryGood (Bardzo Dobra)</option>
              <option value="Good" ${sit.severity === 'Good' ? 'selected' : ''}>Good (Dobra)</option>
              <option value="Medium" ${sit.severity === 'Medium' ? 'selected' : ''}>Medium (Neutral)</option>
              <option value="Bad" ${sit.severity === 'Bad' ? 'selected' : ''}>Bad (Zla)</option>
              <option value="VeryBad" ${sit.severity === 'VeryBad' ? 'selected' : ''}>VeryBad (Krytyczna)</option>
            </select>
          </div>
          <div style="flex:1;">
            <label class="field-label">CATEGORY:</label>
            <input type="text" class="node-input-txt" value="${escapeHtml(sit.category || '')}" oninput="appState.activeItemFull.category = this.value">
          </div>
        </div>
        <div>
          <div class="field-label">ACTIVATING VARIABLE (IS_ENABLED_VARIABLE):</div>
          <div style="display:flex; gap:6px;">
            <input type="text" id="sit-cond-input" class="node-input-txt code-field" value="${escapeHtml(sit.condition || '')}" oninput="appState.activeItemFull.condition = this.value">
            <button class="btn-tag-insert" onclick="openTagPicker('sit-cond-input', null, null, (tag) => { appState.activeItemFull.condition = tag; document.getElementById('sit-cond-input').value = tag; })">TAG</button>
          </div>
        </div>
      </div>
    </div>
  `;
}

// ================= SAVE & DEPLOY OPERATIONS =================

async function saveCurrentItem() {
  if (!appState.activeItemFull) return;
  showToast('Zapisywanie modyfikacji...', 'info');

  try {
    let endpoint = '';
    if (appState.currentTab === 'conversations') endpoint = '/api/conversation/save';
    else if (appState.currentTab === 'decisions') endpoint = '/api/decision/save';
    else if (appState.currentTab === 'reports') endpoint = '/api/report/save';
    else if (appState.currentTab === 'situations') endpoint = '/api/situation/save';

    const res = await fetch(endpoint, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(appState.activeItemFull)
    });

    const data = await res.json();
    if (!res.ok || !data.success) throw new Error(data.message || 'Blad zapisu');

    if (appState.activeItem.modStatus === 'VANILLA') {
      appState.activeItem.modStatus = 'MODEDIT';
    }
    const badgeEl = document.getElementById('active-item-badge');
    badgeEl.className = 'badge badge-modedit';
    badgeEl.textContent = 'MODEDIT';

    renderSidebarList();
    showToast(data.syncedToGame ? 'Zapisano i zsynchronizowano z katalogiem gry!' : 'Zapisano w repozytorium!', 'success');
  } catch (err) {
    showToast('Blad zapisu: ' + err.message, 'error');
  }
}

async function deployModToGame() {
  showToast('Wymuszona synchronizacja z silnikiem gry...', 'info');
  try {
    const res = await fetch('/api/deploy', { method: 'POST' });
    const data = await res.json();
    if (data.success && data.syncedToGame) {
      showToast('All overrides successfully deployed to game directory!', 'success');
    } else {
      showToast('Zsynchronizowano pliki lokalne moda.', 'info');
    }
  } catch (err) {
    showToast('Blad: ' + err.message, 'error');
  }
}

// ================= PREREQUISITES & TAGS =================

function openTagManagerModal() {
  document.getElementById('tag-manager-modal').classList.add('active');
  filterTagManagerList();
}

function filterTagManagerList() {
  const container = document.getElementById('tag-manager-list');
  const query = document.getElementById('tag-search-box').value.trim().toLowerCase();

  const varEntries = Object.entries(appState.variables);
  const filtered = varEntries.filter(([name, info]) => {
    if (!query) return true;
    return name.toLowerCase().includes(query) || (info.description || '').toLowerCase().includes(query);
  }).slice(0, 80);

  container.innerHTML = filtered.map(([name, info]) => `
    <div style="padding: 6px 8px; border-bottom: 1px solid rgba(255,255,255,0.05); display: flex; justify-content: space-between; align-items: center;">
      <div>
        <div style="font-family: var(--font-mono); font-size: 11px; font-weight: 700; color: var(--neon-cyan);">
          ${escapeHtml(name)}
          ${info.isCustom ? '<span class="badge badge-modnew" style="margin-left: 6px; font-size: 8px;">CUSTOM</span>' : ''}
        </div>
        <div style="font-family: var(--font-mono); font-size: 10px; color: var(--text-dim);">${escapeHtml(info.category || 'OGOLNE')} // DOMYSLNIE: ${escapeHtml(info.defaultValue || 'None')} (${info.type || 'Text'})</div>
        ${info.description ? `<div style="font-size: 10px; color: var(--text-muted);">${escapeHtml(info.description)}</div>` : ''}
      </div>
      <button class="btn-tag-add" onclick="filterByThisTag('${escapeHtml(name)}')">FILTRUJ</button>
    </div>
  `).join('');
}

function filterByThisTag(tagName) {
  closeModal('tag-manager-modal');
  appState.selectedTagFilter = tagName;
  document.getElementById('sidebar-tag-filter').value = tagName;
  renderSidebarList();
  showToast(`Filtrowanie tagu: ${tagName}`, 'info');
}

function openCreateTagModal() {
  closeModal('tag-manager-modal');
  document.getElementById('create-tag-modal').classList.add('active');
}

async function submitNewTag() {
  const name = document.getElementById('new-tag-name').value.trim();
  const type = document.getElementById('new-tag-type').value;
  const defaultValue = document.getElementById('new-tag-default').value.trim();
  const category = document.getElementById('new-tag-category').value.trim();
  const desc = document.getElementById('new-tag-desc').value.trim();

  if (!name) return alert('Wymagana nazwa tagu!');

  try {
    const res = await fetch('/api/prerequisites/create', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ name, type, defaultValue, category, description: desc })
    });
    const data = await res.json();
    if (!res.ok || !data.success) throw new Error(data.message || 'Blad tworzenia');

    appState.variables[name] = data.tag;
    populateSidebarTagFilter();
    closeModal('create-tag-modal');
    showToast(`Utworzono tag: ${name}`, 'success');
  } catch (err) {
    alert('Blad: ' + err.message);
  }
}

// TAG PICKER
let activePickerCallback = null;

function openTagPicker(targetInputId, entryId = null, fieldName = null, customCallback = null) {
  appState.pendingTagTargetInput = document.getElementById(targetInputId);
  activePickerCallback = customCallback;
  document.getElementById('insert-tag-modal').classList.add('active');
  document.getElementById('picker-tag-search').value = '';
  filterTagPickerList(entryId, fieldName);
}

function filterTagPickerList(entryId = null, fieldName = null) {
  const container = document.getElementById('picker-tag-list');
  const query = document.getElementById('picker-tag-search').value.trim().toLowerCase();

  const varEntries = Object.entries(appState.variables);
  const filtered = varEntries.filter(([name, info]) => {
    if (!query) return true;
    return name.toLowerCase().includes(query) || (info.description || '').toLowerCase().includes(query);
  }).slice(0, 50);

  container.innerHTML = filtered.map(([name, info]) => `
    <div style="padding: 6px 8px; background: var(--bg-card); border: 1px solid var(--border-dim); border-radius: 4px; cursor: pointer; display: flex; justify-content: space-between; align-items: center;" onclick="insertChosenTag('${escapeHtml(name)}', ${entryId}, '${fieldName}')">
      <div>
        <div style="font-family: var(--font-mono); font-size: 11px; color: var(--neon-cyan); font-weight: 700;">${escapeHtml(name)}</div>
        <div style="font-family: var(--font-mono); font-size: 9px; color: var(--text-dim);">${escapeHtml(info.category || '')} (${info.type || 'Text'})</div>
      </div>
      <button class="btn-tag-insert">WSTAW</button>
    </div>
  `).join('');
}

function insertChosenTag(tagName, entryId, fieldName) {
  const formatted = `Variable["${tagName}"]`;
  if (activePickerCallback) {
    activePickerCallback(tagName);
  } else if (appState.pendingTagTargetInput) {
    appState.pendingTagTargetInput.value = formatted;
    if (entryId !== null && fieldName !== null) {
      updateNodeField(entryId, fieldName, formatted);
    }
  }
  closeModal('insert-tag-modal');
  showToast(`Wstawiono: ${tagName}`, 'info');
}

// ================= MODALS & HELPERS =================

function closeModal(modalId) {
  const modal = document.getElementById(modalId);
  if (modal) modal.classList.remove('active');
}

function setupKeyboardShortcuts() {
  document.addEventListener('keydown', (e) => {
    if ((e.ctrlKey || e.metaKey) && e.key === 's') {
      e.preventDefault();
      saveCurrentItem();
    }
    if (e.key === 'Escape') {
      document.querySelectorAll('.modal-shield').forEach(m => m.classList.remove('active'));
      closeInspectorDrawer();
    }
  });
}

function showToast(message, type = 'info') {
  const shelf = document.getElementById('toast-shelf');
  const toast = document.createElement('div');
  toast.className = `toast-msg toast-${type}`;
  toast.innerHTML = `
    <span>${type === 'success' ? ICONS.check : (type === 'error' ? ICONS.alert : ICONS.choice)}</span>
    <span>${escapeHtml(message)}</span>
  `;
  shelf.appendChild(toast);
  setTimeout(() => {
    toast.style.opacity = '0';
    toast.style.transform = 'translateY(10px)';
    setTimeout(() => toast.remove(), 250);
  }, 3500);
}

function escapeHtml(str) {
  if (!str) return '';
  return String(str)
    .replace(/&/g, '&amp;')
    .replace(/</g, '&lt;')
    .replace(/>/g, '&gt;')
    .replace(/"/g, '&quot;')
    .replace(/'/g, '&#039;');
}


// ============================================================================
// SETTINGS & DECOMPILER
// ============================================================================
async function openSettingsModal() {
  const modal = document.getElementById('settings-modal');
  const input = document.getElementById('suzerain-path-input');
  const out = document.getElementById('decompile-output');
  if (out) out.style.display = 'none';
  try {
    const res = await fetch('/api/config');
    const cfg = await res.json();
    if (input && cfg.suzerain_path) input.value = cfg.suzerain_path;
  } catch (e) {
    console.error('Failed to load config:', e);
  }
  if (modal) modal.style.display = 'flex';
}

async function saveSuzerainPath() {
  const input = document.getElementById('suzerain-path-input');
  const path = input ? input.value.trim() : '';
  try {
    const res = await fetch('/api/config', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ suzerain_path: path })
    });
    const data = await res.json();
    if (data.status === 'ok') {
      if (typeof showToast === 'function') showToast('Zapisano ścieżkę Suzeraina!', 'success');
    } else {
      alert('Błąd zapisu: ' + (data.message || 'Nieznany błąd'));
    }
  } catch (e) {
    alert('Błąd połączenia z serwerem: ' + e);
  }
}

async function runDecompiler() {
  const input = document.getElementById('suzerain-path-input');
  const btn = document.getElementById('btn-run-decompile');
  const out = document.getElementById('decompile-output');
  const path = input ? input.value.trim() : '';
  if (btn) { btn.disabled = true; btn.textContent = '⏳ Dekompilacja trwa...'; }
  if (out) { out.style.display = 'block'; out.textContent = 'Uruchamianie dekompilatora UnityPy...'; }
  try {
    await saveSuzerainPath();
    const res = await fetch('/api/decompile', {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ suzerain_path: path })
    });
    const data = await res.json();
    if (out) out.textContent = data.output || data.message || JSON.stringify(data);
    if (data.status === 'ok') {
      if (typeof showToast === 'function') showToast('Dekompilacja zakończona! Odśwież stronę.', 'success');
    } else {
      if (typeof showToast === 'function') showToast('Błąd dekompilacji!', 'error');
    }
  } catch (e) {
    if (out) out.textContent = 'Błąd: ' + e;
  } finally {
    if (btn) { btn.disabled = false; btn.textContent = '📦 Dekompiluj dane z gry (UnityPy)'; }
  }
}
