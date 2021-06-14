using System;
using System.Collections.Generic;
using System.Text;

//UnfetteredScholar
//This function is used to create an interactive menu
//It returns an integer corresponding to the option's index on the list

//KEY HASH CODES
//851981 - ENTER
//2490368 - UP ARROW
//2621440 - DOWN ARROW

namespace Interactive_Menu
{
    class IMenu
    {
        public static int Interactive_menu(params string[] optionList) //Variable Argument List
        {
            int i = 1, choice = 1, listLength = optionList.Length;
            string quit = "Quit";
            bool running = true;
            int[] selection = new int[listLength + 1];
            ConsoleKeyInfo key;

            while (running)
            {
                i = 1;
                foreach (string option in optionList)
                {
                    if (choice == i)
                    {
                        Console.Write("->");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                    Console.WriteLine("{0}. {1}", i, option);
                    i++;

                }

                if (choice == i)
                {
                    Console.Write("->");
                    Console.WriteLine("{0}. {1}", i, quit);

                }
                else
                {
                    Console.Write("  ");
                    Console.WriteLine("{0}. {1}", i, quit);

                }

                key = Console.ReadKey();

                if ((key.GetHashCode() == 2490368) && (choice > 1)) //UP ARROW
                {
                    choice--;
                    Console.Clear(); //CLEARS THE SCREEN FOR A NEW LIST TO BE PRINTED
                }
                else if ((key.GetHashCode() == 2621440) && (choice < listLength + 1)) //DOWN ARROW
                {
                    choice++;
                    Console.Clear(); //CLEARS THE SCREEN FOR A NEW LIST TO BE PRINTED
                }
                else if (key.GetHashCode() == 851981) //ENTER
                {
                    return choice; //RETURNS THE CHOICE INDEX WHEN ENTER IS PUSHED
                }
                else
                {
                    Console.Clear();
                }
            }

            return -1; //Returns -1 if none of the options are chosen
        }

    }
}



