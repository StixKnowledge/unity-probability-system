# Unity Probability Logic System

A reusable probability-based random selection system built with Unity and C#.  
This project demonstrates how to create percentage-based outcomes using random number generation.

The system can be applied to:
- Loot drop systems
- Enemy spawning
- Critical hit mechanics
- Random events
- Procedural generation
- Reward systems
- Dialogue/event chances
- Any feature that requires probability logic

---

## Features
- Simple and reusable probability logic
- Adjustable percentage chances
- Beginner-friendly implementation
- Easy integration into any Unity project
- Inspector customization support

---

## How It Works

The script generates a random number between 0 and 100.

If the generated value is lower than the configured probability:
- Trigger Outcome A

Otherwise:
- Trigger Outcome B

Example:
- Probability = 20
- Result:
  - 20% chance → Rare Outcome
  - 80% chance → Common Outcome

---

## Example Logic

```csharp
float roll = Random.Range(0f, 100f);

if (roll < probability)
{
    // Success outcome
}
else
{
    // Default outcome
}
```

---

## Requirements
- Unity 2021 or newer
- Basic understanding of C# and Unity

---

## Setup Instructions

### 1. Create a Unity Project
Open Unity Hub and create a new project.

---

### 2. Create the Script
Create a new C# script named:

```text
ProbabilityManager
```

Paste the provided code into the script.

---

### 3. Attach the Script
- Create an empty GameObject
- Attach the script to the GameObject

---

### 4. Configure Probability
Inside the Unity Inspector:
- Adjust the probability value using the slider

Example:
- 10 → Rare occurrence
- 50 → Balanced chance
- 80 → Frequent occurrence

---

## Example Use Cases

### Loot Drop System
- 5% Legendary Item
- 95% Normal Item

### Enemy Spawning
- 20% Strong Enemy
- 80% Normal Enemy

### Critical Hit System
- 15% Critical Hit Chance

### Random Events
- Weather changes
- Random encounters
- Bonus rewards

### Procedural Generation
- Rare room generation
- Special biome appearance
- Random obstacles

---

## Future Improvements
- Multiple weighted outcomes
- Dynamic probability scaling
- Probability tables
- Editor tools
- Object pooling integration
- ScriptableObject support

---

## License
This project is open-source and free to use for learning and personal projects.

---

## Author
Created by StixKnowledge
