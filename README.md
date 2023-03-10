# Mini Space Rover Curi
 Final project in Practical Engineering in Electronics 
 
last update: 22/05/18- Submission version

[Demonstration video](https://youtu.be/pdhwyjT2Q-M)

## Images of the project
![project's front](https://user-images.githubusercontent.com/120782729/209185255-b69c18f0-27ee-4648-877d-401d5d4e5c54.jpg)
 
 ![project's back](https://user-images.githubusercontent.com/120782729/209185325-ebde7867-b5b5-4d3a-9ac0-463b8394b68c.jpg)

### Project's circuits
![circiuts](https://user-images.githubusercontent.com/120782729/209185363-604a1dbb-5630-4d0e-bb87-5ed230a2c7df.jpg)

## Description

This project is a remote controlled vehicle with an IP camera, using CPLD controller (Altera MAXII CPLD). 

The project is inspired by NASA's rover on plant Mars, Curiosity- hence the nickname we gave to the project, Curi.

The rover includes: 
* 2 DC motors 
* IP camera
* 3 servo motors- 2 for arm, 1 for camera
* Bluetooth module 
* Altera MAXII CPLD controller.


### Features:
* The user can interface with the project using GUI written in C#, while the computer is remotely connected to the rover using Bluetooth modules.
* Using the GUI, the user can move the rover, control the arm, changing the camera's angles and use a few image processing functions on the received picture from the camera.
* Color detection and self driving function.
* The IP camera is remotely connected to the computer using router. 
* The rover can move in any direction (forward, backward, right, left) in two different speeds. 
* The servo motor attached to the IP camera can move in 8 different angles.
* The arm can move up and down in 8 different angles, and the arm's claw can open and close.

Image processing functions are explained in the Operating Principle segment.


## Block diagram 
![Block Diagram](https://user-images.githubusercontent.com/120782729/209185845-ff39ebd4-213f-4a3d-90d2-e3c0042d3fcb.png)

## Schematic of the project
![schematic](https://user-images.githubusercontent.com/120782729/209185207-0dc22271-c03c-4832-81cc-7f505d6936b0.jpg)


## C# GUI and Image Processing functions (Operating Principle)
![C# interface](https://user-images.githubusercontent.com/120782729/210149287-660f6b86-e196-4d18-8c46-4ab2a194bf11.png)

As you can see in the picture above, the user can interface with the rover, view the picture received from the IP camera and apply a few image processing functions to it.


There are 3 scrollbars for the 3 servos on the rover- 2 for the arm and 1 for controlling the camera's angle. Each scrollbar has 8 different values.

Pressing the movement buttons (UP, DOWN, RIGHT, LEFT, Stop) will move the rover accordingly. 

Pressing the Speed button will change it from "Slow" to "Fast" and vice versa.

In order to receive live footage from the IP camera, the user has to enter the camera's IP address and then press "Camera Start" button. 

Pressing "shoot" button, will capture and pressent the momentary picture.

Scrollerbar "Scale/Amp" is used to change the intensity of the image processing functions.

The user can apply a few image processing functions:
* Color filtering- the function will detect the range of the pixels values (in HSV), in a rectangle at the center of the picture (the size of the rectangle is determined by "Scale/Amp" scrollbar). Then all the pixels that are out of the range will be marked in black.
* HPF- big differences in value of the pixels will be marked in white while the rest of the picture is black. Thus creating a picture with outlines of te figures in the picture.
* Outlines- the function creates picture of the outlines using Sobel mask.
* Sharpening- this function enhancing the differences between pixels values. 
* LPF- this function blur the picture, by averaging the pixels values.
* Color detection and self driving function- after using the Color filitering function, the rover will find the biggest group of pixels that match the ragne of the color filtering function, and then drive itself towards it.The rover will drive towards the object, until the pixels are at the center of the picture. Thus if the group of the pixels are above the middle of the picture, the rover will drive forward and vice versa (and if the group of the pixels are right to the middle of the picture, the rover will drive right and vice versa).

### Color filter:

![color_filtering](https://user-images.githubusercontent.com/120782729/210152190-bae0573b-2b47-497c-886d-97aed435d64e.jpg)

### HPF filter:

![HPF_filter](https://user-images.githubusercontent.com/120782729/210152197-545e99a5-f2b4-4461-8f8c-29241c06830a.jpg)

### Outlines:

![outlines_filter](https://user-images.githubusercontent.com/120782729/210152212-7e7def12-f6a5-4559-a58d-3eaa7625a4e4.jpg)

### Sharperning:

![shaprening_filter](https://user-images.githubusercontent.com/120782729/210152214-b9cee9d6-a500-4f76-94ea-75952bf88ddb.jpg)

### LPF filter:

![LPF_filter](https://user-images.githubusercontent.com/120782729/210152219-666c011a-dd82-4177-bf10-dc1062c2a9dc.jpg)

## Authors

**Dan Neytur** - [DanNeytur](https://github.com/DanNeytur)

