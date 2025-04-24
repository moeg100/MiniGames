using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace ConsoleApp3
{



    class EscapeGame
    {
        private char[,] grid;
        private int width = 20;
        private int height = 15;
        private (int x, int y) playerPos;
        private (int x, int y)[] enemyPos;
        private (int x, int y)[] exitPos = new (int x, int y)[4];
        private Random rand = new Random();
        private const char PLAYER = 'O';
        private const char ENEMY = 'E';
        private const char EXIT = 'X';
        private const char EMPTY = '.';

        public EscapeGame()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Initialize or fill the grid
            grid = new char[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid[y, x] = EMPTY;
                }
            }

            // Place player
            playerPos = (2, 2);
            grid[playerPos.y, playerPos.x] = PLAYER;

            // Place 2x2 exit by replacing the '.' with X.
            int exitX = width - 3;
            int exitY = height - 3;
            exitPos[0] = (exitX, exitY);
            exitPos[1] = (exitX + 1, exitY);
            exitPos[2] = (exitX, exitY + 1);
            exitPos[3] = (exitX + 1, exitY + 1);
            foreach (var pos in exitPos)
                grid[pos.y, pos.x] = EXIT;

            // Place 3 enemies
            enemyPos = new (int x, int y)[3];
            for (int i = 0; i < 3; i++)
            {
                do
                {   // Assign random tuple values for the enemies.
                    enemyPos[i] = (rand.Next(3, width - 3), rand.Next(3, height - 3));
                } while (grid[enemyPos[i].y, enemyPos[i].x] != EMPTY); // If the cell is not empty, evaluates to true and the loop continue.
                grid[enemyPos[i].y, enemyPos[i].x] = ENEMY;
            }
        }

        private void DrawGrid()
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Adding color to the objects.
                    char c = grid[y, x];
                    switch (c)
                    {
                        case PLAYER:
                            Console.ForegroundColor = ConsoleColor.Green; break;

                        case ENEMY:
                            Console.ForegroundColor = ConsoleColor.Red; break;

                        case EXIT:
                            Console.ForegroundColor = ConsoleColor.Blue; break;

                        default:
                            Console.ForegroundColor = ConsoleColor.White; break;


                    }
                    Console.Write(grid[y, x] + " ");
                }
                Console.WriteLine(); // Add new line after drawing the grid.
                Console.ResetColor();
            }
            Console.WriteLine("\nUse WASD or Arrow keys to move. Reach 'X' to win!");
        }

        private void MoveEnemies()
        {
            foreach (var enemy in enemyPos)
            {
                grid[enemy.y, enemy.x] = EMPTY;
                // This line calculates the new x and y for the enemy by moving it closer to the player.
                int newX = enemy.x + Math.Sign(playerPos.x - enemy.x);
                int newY = enemy.y + Math.Sign(playerPos.y - enemy.y);

                if (newX >= 0 && newX < width && newY >= 0 && newY < height) // This ensures the enemy doesn't move outside the grid
                {
                    enemyPos[Array.IndexOf(enemyPos, enemy)] = (newX, newY);  // Update the new enemy position.


                    if (grid[newY, newX] != PLAYER && grid[newY, newX] != EXIT) // This condition checks whether the new position where the enemy wants to move(newX, newY) is not occupied by the player or the exit.
                    {
                        grid[newY, newX] = ENEMY;
                    }
                }
                else
                {
                    grid[enemy.y, enemy.x] = ENEMY;
                }
            }
        }

        private bool CheckCollision()
        {
            foreach (var enemy in enemyPos)
                if (playerPos == enemy)
                    return true;
            return false;
        }

        private bool CheckWin()
        {
            foreach (var exit in exitPos)
                if (playerPos == exit)
                    return true;
            return false;
        }

        public void Run()
        {
            bool gameOver = false;
            while (!gameOver)
            {
                DrawGrid();
                var key = Console.ReadKey(true).Key; // if key pressed it will not be shown in the console as the user types

                // Move player
                grid[playerPos.y, playerPos.x] = EMPTY;
                var newPos = playerPos;
                switch (key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        if (playerPos.y > 0) newPos.y--; break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        if (playerPos.y < height - 1) newPos.y++; break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        if (playerPos.x > 0) newPos.x--; break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        if (playerPos.x < width - 1) newPos.x++; break;
                }
                playerPos = newPos;
                grid[playerPos.y, playerPos.x] = PLAYER;

                MoveEnemies();

                if (CheckCollision())
                {
                    DrawGrid();
                    Console.WriteLine("Game Over! You were caught by an enemy!");
                    gameOver = true;
                }
                else if (CheckWin())
                {
                    DrawGrid();
                    Console.WriteLine("Congratulations! You escaped!");
                    gameOver = true;
                }
            }

            // Replay prompt
            Console.WriteLine("Play again? (Y/N)");
            while (true)
            {
                var choice = Console.ReadKey(true).KeyChar;
                if (char.ToUpper(choice) == 'Y')
                {
                    InitializeGame();
                    Run();
                    break;
                }
                else if (char.ToUpper(choice) == 'N')
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Escape Game";
            new EscapeGame().Run();
        }
    }

}
