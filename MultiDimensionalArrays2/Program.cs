using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Arrays 2:");
            Console.WriteLine();

            // 2D arrays

            //single item example
            string currentItem;
            currentItem = "pick axe";
            
            
            string[] hotbar = new string[9];
            hotbar[0] = "pick axe";
            hotbar[1] = ""; //empty
            hotbar[2] = ""; //empty
            //...
            hotbar[8] = "";
            //(should be in a loop)

            string[,] inventory = new string[9, 3]; //x is first in x,y and x is sideways, y is up and down
            inventory[0, 0] = "";

            inventory[4, 2] = "pickaxe";

            inventory[8, 2] = "";

            for(int x = 0; x <= 8; x++)
            {
              // Method1 //could do Console.WriteLine(x);

                for (int y = 0; y <= 2; y++)
                {
                    // Method1 Console.WriteLine(x);
                    // Method2 Console.WriteLine(x + "," + y);
                    // Method3
                    inventory[x, y] = "";
                    Console.WriteLine("Inventory[" + x + "," + y + "] = " + inventory[x,y]);
                }
            }
            
            //1D --> string[_] hotbar = new string[9];
            //       hotbar[_]
            //2D --> string[_] hotbar = new string[9, 3]
            
            
            
            
            
            
            
            //hot bar (1d array) example:
            //string[]

            // brackets []
            // parenthese ()
            // braces {}



            Console.ReadKey(true);
        }
    }
}
