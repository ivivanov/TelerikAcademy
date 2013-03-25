## Contents
### Author: Georgi Georgiev
### Additional parts completed by Ivan Ivanov

## Solution Class Diagram - [diagram](https://github.com/ivivanov/TelerikAcademy/blob/master/Some%20Small%20Projects/PopcornGame/Documentation/ClassDiagram.bmp)

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
+ IRenderer – interface for rendering objects
+ IUserInterface – interface for handling input
+ Engine – runs the game, checks for input and renders the scene
+ CollisionDispatcher – notifies objects of their collisions

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
+ TopLeft – top left coordinates of the object in the world
+ Represented by instance of MatrixCoords
+ body – defines the body of the object as a char matrix
+ IsDestroyed – property indicating if the object should be removed from the world

## The Block class

+ Inherits the GameObject class
+ Describes a destructible block
+ Has implemented ICollidable methods
+ Note: all classes inheriting GameObject MUST implement the ICollidable methods if they need specific collision detection
+ Has a constructor, which initializes the body
+ 1x1 char matrix with a symbol

## IRenderer & ConsoleRenderer

+ IRenderer – provides interface to methods for displaying IRenderable
+ EnqueueForRendering – adds a IRenderable to the rendering queue
+ RenderAll – flushes the rendering queue to the screen
+ ClearQueue – removes all objects from the rendering queue
+ Should be called after RenderAll
+ ConsoleRenderer – implements IRenderer for console display

## MovingObject & Ball

+ MovingObject – game object with a speed property
+ Speed is a vector
+ Represented by instance of MatrixCoords
+ Imagine "delta" coords – the change of TopLeft at each "turn"
+ Has overridden Update
+ Updates the TopLeft by adding Speed
+ Ball – inherits MovingObject with bouncing behavior
+ Overrides RespondToCollision

## IUserInterface & KeyboardInterface

+ IUserInterface – provides processing of user input
+ ProcessInput method – checks for user input and signals the appropriate events
+ OnActionPressed, OnRightPressed, OnLeftPressed
+ Events for action (e.g. "shoot" ), move left and move right (e.g. joystick left or keyboard left arrow)
+ KeyboardInterface – implements IUserInterface for keyboard interaction

## The Engine Class

+ Manages game objects, user interface and visualization; all public methods are virtual
+ Uses a IUserInterface
+ Uses a IRenderer
+ Has several GameObject lists
+ allObjects
+ movingObjects
+ staticObjects
+ Has a separate Racket object
+ For control over the player racket
+ Has methods for controlling the Racket
+ Important members
+ AddObject method – adds a GameObject to the engine
+ Run method – starts a "game loop":
+ Draws the scene
+ Checks for input
+ Clears the rendering queue
+ Calls Update for all objects
+ Calls ProduceObjects for all objects and collects
+ Removes all destroyed objects
+ Adds all produced objects

# Tasks
+ The AcademyPopcorn class contains an IndestructibleBlock class. Use it to create side and ceiling walls to the game. You can ONLY edit the AcademyPopcornMain.cs file.
+ The Engine class has a hardcoded sleep time (search for "System.Threading.Sleep(500)". Make the sleep time a field in the Engine and implement a constructor, which takes it as an additional parameter.
+ Search for a "TODO" in the Engine class, regarding the AddRacket method. Solve the problem mentioned there. There should always be only one Racket. Note: comment in TODO not completely correct
+ nherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.
+ Implement a TrailObject class. It should inherit the GameObject class and should have a constructor which takes an additional "lifetime" integer. The TrailObject should disappear after a "lifetime" amount of turns. You must NOT edit any existing .cs file. Then test the TrailObject by adding an instance of it in the engine through the AcademyPopcornMain.cs file.
+ Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects. Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way as the normal ball. You must NOT edit any existing .cs file.
+ Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
+ Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks and will destroy any other block it passes through. The UnpassableBlock should be indestructible. Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.
+ Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file
+ Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. You must NOT edit any existing .cs file. Hint: what does an explosion "produce"?
+ Implement a Gift class. It should be a moving object, which always falls down. The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket. You must NOT edit any existing .cs file. 
+ Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed. You must NOT edit any existing .cs file. Test the Gift and GiftBlock classes by adding them through the AcademyPopcornMain.cs file.
