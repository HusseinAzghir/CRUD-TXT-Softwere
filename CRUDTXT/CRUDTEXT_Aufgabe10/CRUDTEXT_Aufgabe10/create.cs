using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTEXT_Aufgabe10
{
    internal class create
    {

        public static string userInput {get; set;}



        public static void UI_Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Create");
            Console.WriteLine();
            Console.WriteLine("Text datei erstellen [1]");
            Console.WriteLine("Zurück zum Hauptmenü [2]");
         



            userInput = Console.ReadLine();

            switch (userInput) 
            {
                case "2":
                    Selection.ShowMenu();
                 break;
               
                default:
                    Create();
                break;
            }


        }





        public static void Create()
        {
            Console.WriteLine("Datei erstllen: ");
            Console.Write("Bitte geben sie einene namen an: ");
            userInput= Console.ReadLine();


            FileStream erstellen;
            erstellen = new FileStream(userInput + ".txt", FileMode.Create);


            Console.WriteLine("Datei Wurde Erstellt!");
            Console.WriteLine();
            Console.Write("Taste Drücken...");
            Console.ReadKey();
            Console.WriteLine();
            Selection.ShowMenu();
            // Zurück zu menü


        }
       



    }
}
