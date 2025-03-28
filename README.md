# Oaks-Guru
# Unity Developer Test

## 🟢 Project Overview
This project demonstrates a Unity scene using SOLID principles to ensure maintainable, scalable, and flexible code. It showcases object spawning, interaction using the Command Pattern, and drag-and-drop functionality.

---

## 🚀 Setup Instructions
1. **Clone the Repository:**
   ```bash
   git clone https://github.com/amankumarmatta/Oaks-Guru.git
   ```
2. **Open in Unity:**
   - Open Unity Hub and add the project folder.
   - Ensure Unity version 2021.3 or higher.

3. **Scene Setup:**
   - Open the "MainScene" from the Scenes folder.
   - Ensure Main Camera is tagged as "MainCamera".

4. **Play the Game:**
   - Click Play to start the application.
   - Use UI buttons to spawn objects.
   - Drag objects and drop them in the designated area.

---

## 🟢 Project Architecture
### SOLID Principles Applied:
1. **Single Responsibility Principle (SRP):** Each class has a single, focused responsibility (e.g., SpawnManager handles spawning).
2. **Open/Closed Principle (OCP):** Adding new shapes only requires extending the SpawnManager.
3. **Liskov Substitution Principle (LSP):** DraggableObject can be replaced by any object implementing drag logic.
4. **Interface Segregation Principle (ISP):** Interfaces like ICommand encapsulate object behavior.
5. **Dependency Inversion Principle (DIP):** Object interactions are controlled via abstractions.

---

## 🟢 Code Explanation
### 1. **SpawnManager.cs**
Handles object spawning using factory methods. Generates objects within the camera’s viewport and adheres to OCP by allowing easy shape extension.

### 2. **DraggableObject.cs**
Implements drag-and-drop functionality using Unity’s event interfaces. Restricts Y-axis movement during dragging.

### 3. **DropArea.cs**
Detects object drop events, disables further movement, and displays drop messages.

### 4. **Command Pattern**
The command pattern is used to encapsulate object interactions, making the code extensible.

---

## 🟢 Future Enhancements
- Add new shapes dynamically.
- Implement undo/redo functionality.
- Enhance UI/UX with animations.

---

## 🟢 Author
Created by Aman

