using System;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] map = {
     {"*", ".", ".", "."},
      {".", ".", ".", "."},
      {".", "*", ".", "."},
      {".", ".", ".", "."}
 };
            Console.WriteLine("*");

        
            for (int xOrdinate = 0; xOrdinate < map.GetLength(1); xOrdinate++)
            {
                if (map[0, xOrdinate].Equals("*"))
                    Console.WriteLine("*");
                else
                    Console.WriteLine(1);
            }

         
            int MAP_WIDTH = map.GetLength(1);
            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                String curentCell = map[0, xOrdinate];
                if (curentCell.Equals("*")) Console.WriteLine("*");
                else Console.WriteLine(1);
            }

          
             MAP_WIDTH = map.GetLength(1);

            string[,] mapReport = new String[1, MAP_WIDTH];
            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                string curentCell = map[0, xOrdinate];
                if (curentCell.Equals("*")) mapReport[0, xOrdinate] = "*";
                else mapReport[0, xOrdinate] = "1";
            }

            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                string currentCellReport = mapReport[0, xOrdinate];
                Console.Write(currentCellReport);
            }

          
        MAP_WIDTH = map.GetLength(1);

            mapReport = new String[1, MAP_WIDTH];
            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                String curentCell = map[0, xOrdinate];
                if (curentCell.Equals("*"))
                {
                    mapReport[0, xOrdinate] = "*";
                }
                else
                {
                    int minesAround = 0;

                    bool hasNeighbourAtLeft = xOrdinate - 1 >= 0;
                    bool hasMineAtLeft = hasNeighbourAtLeft && map[0, xOrdinate - 1].Equals("*");
                    if (hasMineAtLeft) minesAround++;

                    bool hasNeighbourAtRight = xOrdinate + 1 < MAP_WIDTH;
                    bool hasMineAtRight = hasNeighbourAtRight && map[0, xOrdinate + 1].Equals("*");
                    if (hasMineAtRight) minesAround++;

                    mapReport[0, xOrdinate] = minesAround.ToString();
                }
            }

            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                String currentCellReport = mapReport[0, xOrdinate];
                Console.Write(currentCellReport);
            }

        
            int MAP_HEIGHT = map.GetLength(0);
          MAP_WIDTH = map.GetLength(1);

            mapReport = new string[MAP_HEIGHT, MAP_WIDTH];

            for (int xOrdinate = 0; xOrdinate < map.GetLength(1); xOrdinate++)
            {
                string curentCell = map[0, xOrdinate];
                if (curentCell.Equals("*"))
                {
                    mapReport[0, xOrdinate] = "*";
                }
                else
                {
                    int[,] NEIGHBOURS_ORDINATE = { { 0, xOrdinate - 1 }, { 0, xOrdinate + 1 } };

                    int minesAround = 0;
                    for (int i = 0; i < NEIGHBOURS_ORDINATE.GetLength(0); i++)
                    {
                        int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                        int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                        bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0 || xOrdinateOfNeighbour == MAP_WIDTH;
                        if (isOutOfMapNeighbour) continue;

                        bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                        if (isMineOwnerNeighbour) minesAround++;
                    }

                    mapReport[0, xOrdinate] = minesAround.ToString();
                }
            }

            for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
            {
                String currentCellReport = mapReport[0, xOrdinate];
                Console.Write(currentCellReport);
            }

   
             MAP_HEIGHT = map.GetLength(0);
            MAP_WIDTH = map.GetLength(1);

        mapReport = new string[MAP_HEIGHT, MAP_WIDTH];

         mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                for (int xOrdinate = 0; xOrdinate < map.GetLength(1); xOrdinate++)
                {
                    String curentCell = map[yOrdinate, xOrdinate];
                    if (curentCell.Equals("*"))
                    {
                        mapReport[yOrdinate, xOrdinate] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = { { yOrdinate, xOrdinate - 1 }, { yOrdinate, xOrdinate + 1 } };

                        int minesAround = 0;
                        for (int i = 0; i < NEIGHBOURS_ORDINATE.GetLength(0); i++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0 || xOrdinateOfNeighbour == MAP_WIDTH;
                            if (isOutOfMapNeighbour) continue;

                            bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour) minesAround++;
                        }

                        mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
                    }
                }
            }

            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                Console.WriteLine("\n");
                for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                {
                    String currentCellReport = mapReport[yOrdinate, xOrdinate];
                    Console.Write(currentCellReport);
                }
            }
        }

    }
}