# Observer System Showcase

## Assignment: Observer Pattern Implementation in Unity

This project demonstrates the implementation of the Observer Pattern in Unity using a decoupled and modular architecture. The system is designed so that multiple independent components react to changes in player health without being directly dependent on the Health class.

---

## Unity Version
Unity 2022.3.62f3


---

## Objective
To implement a health system where multiple observer systems (UI, Audio, Logging) respond to health changes in a clean, decoupled manner.

---

## Observer Pattern Implementation

### Subject (Observable)
- **Health.cs**
- Maintains:
  - currentHealth
  - maxHealth
- Public Methods:
  - TakeDamage(int amount)
  - Heal(int amount)
- Notifies all subscribed observers whenever health changes.

---

### Interfaces

#### IHealthSubject
- Handles:
  - Subscribe(IHealthObserver observer)
  - Unsubscribe(IHealthObserver observer)
  - NotifyObservers()

#### IHealthObserver
- Implemented by all observer systems.
- Receives updates when health changes.

---

## Observers Implemented

### Health UI
- Updates health display (bar/text) based on current health.

### Audio System
- Plays appropriate sound effects when:
  - Damage is taken
  - Healing occurs

### Logger
- Logs health changes to the Unity Console.

---

## How to Test

1. Open the project in Unity.
2. Load the Game scene.
3. Enter Play Mode.
4. Trigger health changes by movint to red zone to take damage and green zones to heal, you can move using W,A,S,D.
5. Observe:
   - UI updates
   - Audio feedback
   - Console logs

---

## Architecture Highlights

- Decoupled system design
- Interface-driven implementation
- Dynamic subscription and unsubscription
- Separation of concerns across components
- No direct dependencies between observers and the Health system

---

## Bonus Feature
- GameOver system triggered when health reaches zero

---

## Notes / Limitations
- UI and audio are simplified for demonstration purposes

---

## Author
Shobhit
