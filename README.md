# 🏃‍♂️ Kachujin Endless Runner Unity 3D

A fast-paced **3D Endless Runner Game** built with **Unity 6 (2023+)**, featuring smooth controls, lane-based movement, jumping, and crouching mechanics — inspired by classics like *Temple Run* and *Subway Surfers*.

---

## 🎮 Features

- 🧍 **Automatic Forward Movement** — Player runs forward infinitely.
- ⬅️➡️ **Lane Switching** — Move left and right within defined boundaries.
- 🦘 **Jump & Crouch Mechanics** — Responsive player controls.
- 🎬 **Character Animation** — Integrated with Animator for smooth transitions.
- 🌄 **Environment System** — Modular ground tiles, obstacles, and scenery.
- ⚡ **Simple Game Loop** — Easy to expand with scoring and difficulty scaling.

---

## 🧩 Project Setup

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/Shammas-satti-00/Endless-Runner-Unity-3d.git
```

### 2️⃣ Open in Unity
- Open **Unity Hub**
- Click **Add Project → From Disk**
- Select the cloned folder
- Recommended Version: **Unity 2023.2+ (Unity 6)**

### 3️⃣ Run the Game
- Open the main scene (e.g., `MainScene.unity`)
- Press **▶️ Play** in the Unity Editor

---

## 🎮 Controls

| Action | Key |
|:-------|:----|
| Move Left | `A` or `←` |
| Move Right | `D` or `→` |
| Jump | `Space` |
| Crouch | `Left Ctrl` |

---

## ⚙️ Scripts Overview

| Script | Description |
|:--------|:-------------|
| **PlayerMove.cs** | Handles movement, jumping, and lane switching |
| **LevelBoundary.cs** | Sets left and right boundaries for the player |
| **GameManager.cs** *(optional)* | Manages start, pause, and restart logic |

---

## 🎨 Animator Parameters

| Parameter | Type | Description |
|:-----------|:------|:-------------|
| `Speed` | Float | Controls running animation speed |
| `IsGrounded` | Bool | True when on the ground |
| `Jump` | Trigger | Activates jump animation |
| `IsCrouching` | Bool | Activates crouch animation |

---

## 🧱 Folder Structure

```
Assets/
├── Scenes/
│   └── MainScene.unity
├── Scripts/
│   ├── PlayerMove.cs
│   ├── LevelBoundary.cs
│   └── GameManager.cs
├── Materials/
├── Models/
├── Animations/
└── Prefabs/
```

---

## 🧠 How It Works

- The **PlayerMove** script continuously moves the player forward.
- Input keys control horizontal movement and jump/crouch states.
- The **Animator Controller** handles animation blending between idle, run, jump, and crouch.
- **Level boundaries** ensure the player stays within playable lanes.

---

## 🚀 Future Enhancements

- Add collectible items (coins, gems)
- Add procedural obstacle spawning
- Introduce scoring and difficulty scaling
- Add sound effects and background music
- Implement mobile touch controls (swipe gestures)

---

## 🧑‍💻 Developer Info

**Author:** Shammas Satti  
**Repository:** [Endless Runner Unity 3d](https://github.com/Shammas-satti-00/Endless-Runner-Unity-3d)  
**Engine:** Unity 6 (2023+)  
**Language:** C#

---

## 🪪 License

This project is released under the [MIT License](LICENSE).  
Feel free to use, modify, and distribute for educational or commercial purposes.

---

### 💬 Credits

Developed by **Shammas Satti**   
Powered by **Unity 6 / 2023 LTS**
