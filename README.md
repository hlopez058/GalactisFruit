# GalactisFruit

## Description
A program that generates images of planets for space games. The planets are procedurally generated using astronomical rule sets.
The images are then rendered in real time using Perlin's Noise algorithm. 

## Console App
I wanted to start simple. So i built a console app around the perlin noise c# implementation available on github. I then added a couple helpr functions of my own.
I needed to publish an image to see how good the perlin noise generator was at making textures that resemlbled a planet. So i had the app spit out an image by walking
through a 2d array of perlin noise outputs and assigning it to an RGB color. The output needed to be scaled from 0-1 to 0-256.

![alt text](galactisfruit/galactisfruit/bin/Debug/map.jpg "first output")

