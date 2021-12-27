using System;

namespace RatMaze
{
    class Program
    {        
        static int N;
       
        void printSolution(int[,] sol)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write(" " + sol[i, j] + " ");

                Console.WriteLine();
            }
        }
        bool isSafe(int[,] maze, int x, int y)
        {
            return (x >= 0 && x < N && y >= 0 &&
                    y < N && maze[x, y] == 1);
        }
        bool solveMaze(int[,] maze)
        {
            int[,] sol = new int[N, N];

            if (solveMazeUtil(maze, 0, 0, sol) == false)
            {
                Console.Write("Solution doesn't exist");
                return false;
            }

            printSolution(sol);
            return true;
        }
        bool solveMazeUtil(int[,] maze, int x, int y,
                           int[,] sol)
        {
            if (x == N - 1 && y == N - 1 &&
                maze[x, y] == 1)
            {
                sol[x, y] = 1;
                return true;
            }

            if (isSafe(maze, x, y) == true)
            {             
                if (sol[x, y] == 1)
                    return false;

                sol[x, y] = 1;
                
                if (solveMazeUtil(maze, x + 1, y, sol))
                    return true;
               
                if (solveMazeUtil(maze, x, y + 1, sol))
                    return true;

                if (solveMazeUtil(maze, x - 1, y, sol))
                    return true;

                if (solveMazeUtil(maze, x, y - 1, sol))
                    return true;
                
                sol[x, y] = 0;
                return false;
            }
            return false;
        }

        
        public static void Main(String[] args)
        {
            Program rat = new Program();

            int[,] maze = { { 1, 0, 0, 0 },
                    { 1, 1, 0, 1 },
                    { 0, 1, 0, 0 },
                    { 1, 1, 1, 1 } };

            N = maze.GetLength(0);
            rat.solveMaze(maze);
        }
    }
}
