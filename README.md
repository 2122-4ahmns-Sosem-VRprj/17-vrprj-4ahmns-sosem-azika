## Ablauf
Das Spiel dreht sich darum das der Spieler herausfinden muss was in dem Labyrinth mit den Eiern der Osterbäckerei geschehen ist. Wände um die Map herum halten den Spieler davor auf sich einfach zum Ausgang zu begeben. Der Spieler betritt das Labyrinth und muss das Minigame finden, eine Art mathematische Aufgabe, jedoch mit Eiern. Der Spieler ist im Raum des Rätsels eingeschlossen bis er das Rätsel löst und kann sich dann zum Ausgang begeben. 

## Auditive Gestaltung
Auditive Elemente werden vorrangig eingesetzt, um dem Spiel Stimmung zu geben. Die Musik matcht mit dem Gefühl in den jeweiligen Szenen in der sich der Player befindet (Intro, Main Scene, Failed Scene, Outro). Und auch um dem Spiel etwas Realismus zu geben.
Sounds Used:
Intro: Stardew Valley – Cloud Country Soundtrack
Main Scene: Animal Crossing Ambient Music, Vogelgezwitscher (Zufällig getimed)
Outro: Stardew Valley – A Stillness in der Rain
You Failed: Stardew Valley – A sad Story

![IntroScene](https://user-images.githubusercontent.com/72389411/172862383-bfaf8acc-81d0-493e-b20d-506122c5dfac.JPG)
![fromtop](https://user-images.githubusercontent.com/72389411/172862415-76147670-ba81-48cd-b10e-b52bbb866bd4.JPG)
![mainscenepov](https://user-images.githubusercontent.com/72389411/172862425-a38030a9-c4c7-4e5a-964b-7a97c9087c24.JPG)
![Minigame](https://user-images.githubusercontent.com/72389411/172862436-65e9b3b4-09db-468f-a35f-fe5429055ae1.JPG)
![YoumadeitScreen](https://user-images.githubusercontent.com/72389411/172862457-aecc199f-65e4-4526-86f1-fe84d3e291d7.JPG)
![FailedScreen](https://user-images.githubusercontent.com/72389411/172862468-0a009a08-9103-499d-8575-c1d798e6ce7a.JPG)

Die Musik gibt eine bestimmte Stimmung, hält das Spiel dennoch leicht.

## Visual Style
Das Spiel hat den Look einer Art Garten, mit Holz Zäunen, Blumen, Gras und geflechteten Körben. Der Himmel ist eine Cyclus – es beginnt morgentlich im Intro, in der Main Scene ist es hell – als wäre es Mittag, die Outro Scene ist Abendlich, wobei die You Failed Scene Dunkel ist (der Spieler hat zu lange gebraucht) 


## Minigame 1:
Der Spieler betritt einen Raum, die Tür schließt sich hinter ihm und es findet sich ein Bild an der Wand mit 3 verschiedenen Eier Kombinationen. Vor der anderen Wand befinden sich zwei Körbe mit 'Rezepten' darüber. Aus einem weiteren Korb muss man sich das richtige Eier-resultat suchen und in die jeweiligen Körbe geben.

## Minigame 1 Programmierung:
Collided der Player (check Tag) mit dem Collider in dem jeweiligen Raum so schließt sich die Tür. OnCollisionEnter - Collidiert das richtige Ei mit dem richtigen Collider (Korb)? If every collision true - Die Tür öffnet sich wieder und der Player kann sich wieder in das Labyrinth begeben.

## Funktionen:
1. Timer 30 Minuten
2. Vogelgetswitscher Random Timer
3. Minigame fertig - Tür schließt und öffnet sich
4. Ambient Music Plays OnAwake
5. Blumen in der Wiese und Holz Wände
6. Intro mit Story und Musik
7. Intro switcht automatisch zur Main Scene
8. Minigame ist Spielbar
9. Läuft der Timer aus - Failed Screen
10. Retry und Quit Button
11. Erreicht man das Ende des Labyrinths Success Scene

## Development platform:
OS: Windows 10, Game Engine: Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit 1.0.0-pre.8, XR Plugin Management 4.2.1, Oculus XR Plugin 1.10.0.

## Software/Hardware Requirements:
Oculus hardware requirements https://support.oculus.com/248749509016567/ You need a VR headset in this case an Oculus Rift/Quest/Quest2

Examples: https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples

When downloaded, you have compile time errors in the project. To solve them install the XR interaction toolkit package via the Package Manager. (!Enable in Advanced Settings Preview Packages).

## Target platform:
Oculus Rift/S; Quest/2
Plattform: Oculus Quest

## Third-party code
Storyline and Scene Change (Activation Track)): https://youtu.be/NnPDJfvLeWQ
Buttons: https://youtu.be/xs7kLqEnCh8
Switch Scene on Trigger: https://youtu.be/9lPCv9kkbSl

## Assets
Shader: AllSkyFree: https://assetstore.unity.com/packages/2d/textures-materials/sky/allsky-200-sky-skybox-set-10109
Grass Flowers Pack Free: https://assetstore.unity.com/packages/2d/textures-materials/nature/grass-flowers-pack-free-138810
Mobile Wooden Fences: https://assetstore.unity.com/packages/3d/props/exterior/mobile-wooden-fences-54772
Basket, in Blender bearbeitet: https://www.cgtrader.com/free-3d-models/household/kitchenware/free-basket

Probleme:
Rechte Hand zu niedrig
Trigger reagieren nicht immer
UI Buttons funktionieren nicht in VR
