using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTEXT_Aufgabe10
{
    internal class Edit
    {

        public static string UserInput { get; set; }
        public static bool schllter = true;
       


        public static string newContent { get; set; }



        public static void ShowAllData()
        {

            System.IO.DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(@"C:\Users\jonat\Desktop\CRUDTXT\CRUDTEXT_Aufgabe10\CRUDTEXT_Aufgabe10\bin\Debug");

            foreach (System.IO.FileInfo f in ParentDirectory.GetFiles())
            {
                Console.WriteLine("Datei: " + f.Name);
            }

            Console.WriteLine("Wälen sie eine datei aus (Nur name!)");
            UserInput = Console.ReadLine();

             EditText();

           


        }



        public static void EditText()
        {


            Console.WriteLine("Wenn sie das Programm benden wollen geben sie [exit] ein und drücken Enter");
           

            

            File.AppendAllText(UserInput + ".txt",
            DateTime.Now.ToString());

           
            while (newContent != "exit")
            {
                File.AppendAllText(UserInput + ".txt", newContent + Environment.NewLine);
                newContent = Console.ReadLine();
                
            }

            newContent = " ";
            Console.WriteLine("Der Editor wird geschlossen...");
            Selection.ShowMenu();
        }





    }
}
