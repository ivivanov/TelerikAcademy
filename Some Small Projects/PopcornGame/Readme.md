# Academy Popcorn API

### Author: Georgi Georgiev
### Additional tasks completed by Ivan Ivanov

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
