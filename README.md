# 🎯 Plinko Game

A Unity-based Plinko-style game where players drop disks onto a rotating peg board and score points depending on which bin the disk lands in.

This repository contains the Unity project: scenes, C# scripts, TextMesh Pro assets, prefabs and project settings needed to run and extend the game.

---

## 🕹️ Features

* Disk drop / Plinko gameplay using Unity 2D physics
* Rotating board mechanics with clamp and lock functionality
* Score tracking and UI display using TextMesh Pro
* Limited number of disks (lives) and scene transition when disks run out
* Modular C# scripts for game flow, disk movement, scoring and UI

---

## 📁 Project structure (important files)

```
Plinko-Game-main/
├── Assets/
│   ├── Scenes/
│   │   ├── Scene1/                 # Main gameplay scripts & scene assets
│   │   │   ├── BoardRotation.cs
│   │   │   ├── DiskRemaining.cs
│   │   │   ├── GameManagement.cs
│   │   │   ├── add10points.cs
│   │   │   ├── diskMovement.cs
│   │   │   └── score.cs
│   │   └── Scene2/                 # Secondary/end scene (scene transition target)
│   ├── TextMesh Pro/               # TextMesh Pro assets & example scripts
│   └── Settings/                   # Project and rendering settings (URP etc.)
├── Packages/                       # Unity package manifest + lock
├── ProjectSettings/                # Unity project settings
├── LICENSE
└── .gitignore
```

---

## ⚙️ Requirements

* Unity Hub and a Unity Editor version compatible with `ProjectSettings/ProjectVersion.txt`. Open that file to find the exact version used to create this project.
* TextMesh Pro (included via Unity packages listed in `Packages/manifest.json`).

---

## ⚙️ Installation & setup

1. Clone the repository:

```bash
git clone https://github.com/<your-username>/Plinko-Game.git
```

2. Open Unity Hub → **Add** → choose the project folder.
3. Open the main scene located under `Assets/Scenes/Scene1/` and press **Play**.

> Tip: If Unity prompts to upgrade packages or the project, check the `ProjectVersion.txt` and install the matching Unity Editor version to avoid compatibility issues.

---

## ▶️ How to play

* Spawn / drop a disk using the in-scene control or configured input.
* The disk will fall, bounce on pegs and eventually land in a scoring bin.
* Score displays update in real time. When disks run out, the game transitions to Scene2.
* Time your drops and (optionally) use board rotation to influence the disk path.

---

## 🔧 Key scripts (quick reference)

* `GameManagement.cs` — central manager: spawns disks, tracks references to score and disk managers, and handles scene transitions.
* `BoardRotation.cs` — handles board rotation, clamping rotation within limits, and resetting lock state.
* `diskMovement.cs` — controls disk physics behaviour and collision response after drop.
* `DiskRemaining.cs` — tracks remaining disks (lives) and updates the UI display.
* `add10points.cs` — scoring trigger that increments score when disks collide with scoring regions.
* `score.cs` — manages the score value and updates the score UI.

For a full per-file analysis of the `.cs` files in the project, see the `plinko_cs_summaries.md` included in the project or request a separate developer document.

---

## 🛠️ Tech stack

* Unity Engine (C#) — MonoBehaviour scripts
* TextMesh Pro — UI text rendering
* Unity 2D Physics (Physics2D)
* Universal Render Pipeline (URP) — project assets indicate URP use

---

## 📈 Suggested future improvements

* Add sound effects and background music
* Implement persistent high scores (PlayerPrefs, JSON or a small backend)
* Add particle effects and visual polish for collisions and scoring
* Create difficulty levels and more varied boards
* Add mobile-friendly input support and on-screen controls

---

## 🤝 Contribution guidelines

Contributions are welcome. Suggested workflow:

1. Fork the repository
2. Create a new branch: `git checkout -b feature/<your-feature>`
3. Commit changes: `git commit -m "Add feature"`
4. Push and open a pull request

Please include descriptive commit messages and keep PRs focused.

---

## 📄 License

This repository contains a `LICENSE` file — please consult it for the exact license terms (MIT or other).

---

## ⚠️ Notes & caveats

* Some files in the project were summarized from the available code excerpts. A few source files contain literal `...` placeholders; if you want a full line-by-line audit, provide complete, untruncated files.
* If you want me to write the README directly to the repository, create commits, or generate images/GIFs/screenshots, I can produce those assets next.

---

## 👨‍💻 Author / Contact

Developed by **Jean-David Pallares** — replace with your real name and GitHub profile.

---
