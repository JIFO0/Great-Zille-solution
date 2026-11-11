import os
import re

def fix_file_quotes(path):
    with open(path, 'r', encoding='utf-8') as f:
        lines = f.readlines()

    fixed_lines = []
    for line in lines:
        # If line has Variable[..."] = ...
        # Replace Variable["foo"] with Variable[\"foo\"] inside C# string literals
        # Also replace ""Something"" with "\"Something\""
        l = line
        
        # Replace "" at start/end of string argument
        # Pattern like: " ""Text"" " -> " \"Text\" "
        # Or: (""Text"" -> ("\"Text\""
        l = re.sub(r'\((\s*)""', r'(\1"\\"', l)
        l = re.sub(r',(\s*)""', r',\1"\\"', l)
        l = re.sub(r'""(\s*),', r'\\"\1,', l)
        l = re.sub(r'""(\s*)\)', r'\\"\1)', l)
        
        # Replace Variable["..."] inside strings
        # e.g. Variable["foo"] -> Variable[\"foo\"]
        def repl_var(m):
            return 'Variable[\\"' + m.group(1) + '\\"]'
        l = re.sub(r'Variable\["([^"]+)"\]', repl_var, l)

        # Replace = "something" inside userScript strings
        # e.g. = "Force"; -> = \\"Force\\";
        def repl_val(m):
            return '= \\"' + m.group(1) + '\\";'
        l = re.sub(r'=\s*"([A-Za-z0-9_]+)";', repl_val, l)

        # Also replace \" inside already quoted lines if broken
        fixed_lines.append(l)

    with open(path, 'w', encoding='utf-8') as f:
        f.writelines(fixed_lines)
    print(f"Fixed {path}")

for p in [
    'src/GreatZilleSolution/ZilleDialogueSystem.cs',
    'src/GreatZilleSolution/ZilleDialogueSystem.WarScenes.cs',
    'src/GreatZilleSolution/ZilleDialogueSystem.DiplomacyScenes.cs',
    'src/GreatZilleSolution/ZilleDialogueSystem.TreatyScenes.cs'
]:
    fix_file_quotes(p)
