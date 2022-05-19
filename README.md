# HTL-VRProject with XRInteractionToolkit !Template!

### Project description: 
This project serves as sample project for spatial audio. 
Explore sound in its basics in virtual reality (VR).

### Development platform: 
OS: Windows 10, Game Engine: Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit 1.0.0-pre.8, XR Plugin Management 4.2.1, Oculus XR Plugin 1.10.0.

## Software/Hardware Requirements: 
Oculus hardware requirements https://support.oculus.com/248749509016567/
You need a VR headset in this case an Oculus Rift/Quest/Quest2

Examples: https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples

When downlaoded, you have compile time errors in the project. To solve them install the XR interaction toolkit package via the Package Manager. (!Enable in Advanced Settings Preview Packages).

### Target platform: 
Oculus Rift/S; Quest/2

### Visuals: 
Screenshots (concept and experience), Video

![SkizzeMaze](https://user-images.githubusercontent.com/28704310/159113247-e0cfe023-79fb-4ffd-b76f-342c55d93ef2.png)

### Third party material: 

For testing without a headset, use the XR Device Simulator (included in the xr interaction toolkit package):  https://www.youtube.com/watch?v=d4bTpkvBwrs

## Minigame 1:

Der Spieler betritt einen Raum, die Tür schließt sich hinter ihm und es findet sich ein Bild an der Wand mit 3 verschiedenen Eier Kombinationen. Vor der anderen Wand befinden sich zwei Körbe mit 'Rezepten' darüber. Aus einem weiteren Korb muss man sich das richtige Eier-resultat suchen und in die jeweiligen Körbe geben.

## Minigame 1 Programmieren:

Collided der Player (check Tag) mit dem Collider in dem jeweiligen Raum so schließt sich die Tür.
OnCollisionEnter - Collidiert das richtige Ei mit dem richtigen Collider (Korb)?
If every collision true - Die Tür öffnet sich wieder und der Player kann sich wieder in das Labyrinth begeben.

## Minigame 2:

## Minigame 2 Programmieren:

## Funktionen Standpoint 2. Milestone:
1. Timer 30 Minuten
2. Vogelgetswitscher Random Timer
3. 1. Minigame fertig - Tür schließt und öffnet sich

### Limitations/Problems: 

Copyright by smeerws :)
