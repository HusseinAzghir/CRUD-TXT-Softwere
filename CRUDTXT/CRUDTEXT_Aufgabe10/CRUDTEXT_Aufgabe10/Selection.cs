using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTEXT_Aufgabe10
{
    internal class Selection
    {

        public static string Input { get; set; } 


        public static void ShowMenu()
        {

           for (int i = 0; i < 100000;)
           {

            Console.WriteLine("Selection");
            Console.WriteLine();
            Console.WriteLine("Create [1]");
            Console.WriteLine("Edit [2]");
            Console.WriteLine("Read [3]");
            Console.WriteLine("Delete [4]");
            Console.WriteLine("Exit [5]");
            Console.WriteLine();
            Console.Write("Eingabe: ");
            Input = Console.ReadLine();
            
            switch (Input) 
            {
                     case "1":
                    create.UI_Menu();
                    break;

                    case "2":
                    // Edit
                    Edit.ShowAllData();
                    break;

                    case "3":
                    // Read
                    break;

                    case "4":
                    // Delete
                    break;

                    case "5":
                    Console.WriteLine("Das programm wird bendet");
                    Environment.Exit(0);
                    break;

                    default:
                      Console.WriteLine("Uppps da hat was nicht geklapt...");
                      Console.WriteLine();
                    break;

                }

            }

        }


     


    }
}
