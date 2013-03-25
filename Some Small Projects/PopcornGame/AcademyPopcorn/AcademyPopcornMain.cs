using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block secondBlock = new Block(new MatrixCoords(startRow + 1, i));
                engine.AddObject(secondBlock);
            }

            for (int i = 3; i < 10; i++)
            {
                UnpassableBlock currBlock = new UnpassableBlock(new MatrixCoords(startRow + 3, i * 3));
                engine.AddObject(currBlock);
            }

            engine.AddObject(new ExplodingBlock(new MatrixCoords(startRow + 3, endCol - 1)));
            engine.AddObject(new ExplodingBlock(new MatrixCoords(startRow + 3, endCol - 5)));
            engine.AddObject(new ExplodingBlock(new MatrixCoords(startRow, endCol - 4)));
            engine.AddObject(new ExplodingBlock(new MatrixCoords(startRow, endCol - 9)));
            engine.AddObject(new ExplodingBlock(new MatrixCoords(startRow, 12)));
            engine.AddObject(new ExplodingBlock(new MatrixCoords(startRow, 17)));
            engine.AddObject(new GiftBlock(new MatrixCoords(startRow, 5)));
            engine.AddObject(new GiftBlock(new MatrixCoords(startRow, 10)));
            engine.AddObject(new GiftBlock(new MatrixCoords(startRow, 15)));

            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //engine.AddObject(theBall);

            MeteoriteBall metBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            engine.AddObject(metBall);

            UnstoppableBall unstopBall = new UnstoppableBall(new MatrixCoords(22, 10), new MatrixCoords(-1, 1));
            engine.AddObject(unstopBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            for (int i = 0; i < WorldRows; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, 0)));
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1)));
            }
            for (int i = 0; i < WorldCols; i++)
            {
                engine.AddObject(new IndestructibleBlock(new MatrixCoords(0, i)));
            }
            for (int i = 0; i < WorldCols; i++)
            {
                engine.AddObject(new GameOverBlock(new MatrixCoords(WorldRows, i)));
            }
            engine.AddTrailingObject(new TrailObject(new MatrixCoords(15, 20), new char[,] { { 'S', 't', 'a', 'r', 't' }, { 'G', 'a', 'm', 'e', ' ' } }, 10));
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngine = new Engine(renderer, keyboard,150);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            gameEngine.Run();
        }
    }
}