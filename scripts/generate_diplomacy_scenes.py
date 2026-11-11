import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from build_all_dialogues import generate_diplomacy_scenes

if __name__ == "__main__":
    generate_diplomacy_scenes()
