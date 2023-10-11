![image](https://github.com/sacibytes/unity3d-ar-alien-pop/assets/143756133/540da200-2cd6-45f6-939c-58586cfd2db1)

![Alien_Pop](search-ms:displayname=Search%20Results%20in%20Quick%20access&crumb=System.Generic.String%3A(alien%20pop)&crumb=location:%3A%3A{679F85CB-0220-4080-B29B-5540CC05AAB6})

## Table of Contents
- [Summary of Game](#summary-of-game)
- [User Manual](#user-manual)
- [Design & Implementation](#design--implementation)
  - [Implementation](#implementation)
  - [Design](#design)
- [Assets Used in Project](#assets-used-in-project)

## Summary of Game

"Alien Pop" is an AR game where players must defend Earth from a comical alien invasion. Players tap on the ground to position the 3D environment, featuring a red spaceship and surrounding buildings and trees. The objective is to pop alien characters that spawn around the spaceship. There are two types of aliens: Slime Aliens (red, tap twice to pop) and TurtleShell Aliens (blue, tap three times to pop). Players must avoid tapping on the Gas Bomb, which results in point deduction. The game's goal is to accrue the highest score, and players can choose to play for fun or aim for a specific objective.

## User Manual

1. **Game Menu:**
   - Click the "PLAY" button to start the game.
   - Click the "HOW TO PLAY" button to view game instructions and rules.
   - Click the "QUIT" button to exit the game.

2. **Popping Characters:**
   - Slime Alien: Tap twice to pop (1 point).
   - TurtleShell Alien: Tap three times to pop (2 points).
   - Avoid Gas Bomb: Tapping results in point deduction (2 points).

3. **Scoring:**
   - Popping Aliens: Gain points.
   - Tapping Gas Bomb: Lose points.


### Implementation

- **Vuforia Engine:** Used for AR tracking and recognition.
- **AR Core:** Enables AR experiences and environmental perception.
- **Ground Plane:** Utilized for placing 3D environment and interacting with it.
- **XR Plug-in Management:** Simplifies XR plug-in management for Unity.

### Design

- Three scenes: Main Menu, How to Play, and Pop Game.
- Canvas used for UI elements.
- Game assets include buildings, trees, spaceship, and aliens.

### Assets Used in Project

- Cartoon Buildings
- BearStudio Low Poly Pine Trees
- 3D Red Spaceship


