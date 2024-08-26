# Damage Scanning Drone
This repository showcase's the user interface of my capstone project. This program was made in Visual Studio using C#(.NET) and Python. I was tasked with setting up the User Interface to display a 3D Model, displaying a live camera feed, taking photos/videos and establishing connection between the local PC and a rasberry Pi.

NOTE* The python files are not listed in the repository. As they're on the Rasberry Pi.
 
## Features
* Syncing files remotely
* Live camera feed and taking photos
* Displaying a 3D model

## Photos

## File Transfer (C#, Powershell, Linux)
Initiated file sync by connecting to Powershell using the built in console in Visual Studio and streamlined the commands using C#. Input the `wsl` command to connect to Linux Ubuntu since I used a Windows device. Created SSH keys between the PC and the Rasberry Pi to automate login. Used the Linux `rsync` command to sync remote folders. 

## Live camera feed, Photos and Videos (Python)
These 3 features was coded in python using the "Flask" library and the built in camera functionality on the Rasberry Pi.
The live camera feed displays in the browser using a C# command that creates a popup in the browser.

## Display 3D model
Using the command line structure. Created a popup command that display the 3D model using the built in 3D Model viewer.
  
