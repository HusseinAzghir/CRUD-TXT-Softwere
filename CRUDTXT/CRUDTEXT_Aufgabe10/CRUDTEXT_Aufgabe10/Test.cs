using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTEXT_Aufgabe10
{
    public class TxtModifier
    {

        public static string newContent;

        public static void Show()
        {


            Console.WriteLine("Please enter the content to append in to the file - type exit and press enter to finish editing:");
            newContent = Console.ReadLine();
            while (newContent != "exit")
            {
                File.AppendAllText("test.txt", newContent + Environment.NewLine);
                newContent = Console.ReadLine();
            }

        }


    }
}
