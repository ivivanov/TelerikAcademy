## Contents

## Solution Class Diagram - [diagram](https://)

+ Overview
+ The GameObject class 
+ Important members
+ The IRenderable and ICollidable interfaces
+ The Block class
+ The IRenderer interface and ConsoleRenderer
+ The MovingObject and Ball classes
+ The IUserInterface and KeyboardInterface
+ The Engine class

## Academy Popcorn API

+ Provides an API for a matrix-based game of Popcorn/Blockbuster
+ Important classes
+ GameObject – base class for objects in the game (like System.Object in C#)
++ IRenderer – interface for rendering objects
++ IUserInterface – interface for handling input
++ Engine – runs the game, checks for input and renders the scene
++ CollisionDispatcher – notifies objects of their collisions

## The GameObject class

+ Base class for all objects in the game world
+ Abstract class
+ There is no such thing as "just an object"
+ it's either a block, a racket or something else
+ Has a protected constructor
+ Implements the IRenderable interface
+ Provides a GetImage method – returns a char matrix for visualization
+ Used by the IRenderer – will be covered later
+ Implements the IObjectProducer interface
+ Enables objects to produce other objects
+ Implements the ICollidable interface
+ Enables objects to participate and respond to collisions
+ The Update method
+ Abstract method
+ Inheriting classes implement their behavior there
+ Other fields
++ TopLeft – top left coordinates of the object in the world
++ Represented by instance of MatrixCoords
++ body – defines the body of the object as a char matrix
++ IsDestroyed – property indicating if the object should be removed from the world
