# Game details

# VR Moon Shooter Game Documentation
 
Welcome to the VR Moon Shooter game! This document outlines the game's features, gameplay mechanics, and scripts used in development. For further details, visit the GitHub repository: [Akash3121/VR-Moon-Shooter](https://github.com/Akash3121/VR-Moon-Shooter).
 
## Gameplay
 
In VR Moon Shooter, players explore the lunar surface, aiming to destroy asteroids to score points. The game leverages virtual reality to provide an immersive experience, making players feel like they are on the moon.

### Key Features
 
- **Asteroid Destruction**: Players can destroy incoming asteroids by shooting them.
- **Asteroid Movement**: Asteroids move and rotate, making them challenging targets.
- **Scoring System**: Players earn points for each asteroid destroyed.
- **Dynamic Spawning**: Asteroids spawn at random locations around the lunar surface.
- **Immersive Controls**: Utilizing VR controllers, players can navigate and interact with the game environment.

## Scripts Overview
 
### 1. AsteroidDestroyer
 
Handles the logic for destroying asteroids when they collide with bullets or the player's sphere.
 
#### Key Functions:
 
- `OnTriggerStay`: Activates the sphere and destroys asteroids or bullets upon collision.
 
### 2. AsteroidMovement
 
Controls the movement and rotation of asteroids.
 
#### Key Variables:
 
- `maxSpeed`, `minSpeed`: Define the speed range for asteroid movement.
- `rotationalSpeedMin`, `rotationalSpeedMax`: Define the rotation speed range.
 
### 3. AsteroidSpawner
 
Manages the spawning of asteroids within a defined lunar surface area.
 
#### Key Variables:
 
- `spawnerSize`: Size of the spawning area.
- `spawnRate`: Frequency of asteroid spawning.
 
### 4. BulletCollisionHandler
 
Manages the bullet's behavior upon collision with asteroids.
 
#### Key Functions:
 
- `OnTriggerEnter`: Triggers explosion effects and score updates on asteroid destruction.
 
### 5. ControllerGrab
 
Enables players to grab guns by pressing the respective buttons (button X on the left controller for the left gun, and button A on the right controller for the right gun).

### 6. GunController
 
Allows players to shoot bullets by clicking the index trigger on the gun. The bullets generated correspond to the respective controller.

### 7. ScoreManager
 
Manages the game's scoring system.
 
#### Key Functions:
 
- `AddScore`: Adds points to the score.
- `UpdateScoreUI`: Updates the UI with the current score.

## How to Play
 
- **Navigation**: Use the VR controller's joystick to move around on the moon's surface.
- **Grab Guns**: Press button X on the left controller to grab the left gun, and button A on the right controller to grab the right gun.
- **Shooting**: Click the index trigger on the gun to shoot bullets at asteroids.
- **Scoring**: Earn points for each asteroid destroyed.
- **Avoid Collisions**: Maneuver to avoid colliding with asteroids.
 
## Additional Information
 
For a more detailed breakdown of the scripts, assets, and updates, please refer to the GitHub repository: [VR Moon Shooter on GitHub](https://github.com/Akash3121/VR-Moon-Shooter).
 
This documentation provides an overview of the VR Moon Shooter game, its key features, and the scripts used in its development. For any additional information or updates, please visit the provided GitHub link.