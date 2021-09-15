using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketversand
{
    class Program
    {

        /// <summary>
        /// Main method; called on startup
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Code here
            Console.Title = "Paketversandrechner";
            Explanation();

            //string[] PackageDim = new string[2];
            string[] PackageDim = RequestData();
            //WorkWithData();
            NoClose();
        }
        /// <summary>
        /// Displays the Explanation of what the Program does
        /// </summary>
        public static void Explanation()
        {
            Console.WriteLine("Diese Software berechnet den benötigten Briefmarkenwert.");
            //Thats about it
        }

        /// <summary>
        /// Request Data from User
        /// </summary>
        public static string[] RequestData()
        {
            //string[] Dim = new string[2];
            
            Console.Write("Bitte gebe die Breite des Pakets in cm ein: ");
            string inputWidth = Console.ReadLine();
            Console.Write("Bitte gebe die Länge des Pakets in cm ein: ");
            string inputLength = Console.ReadLine();
            //PackageDim
            //Dim[0] = inputWidth;
            //Dim[1] = inputLength;
            string[] Dim = { inputWidth, inputLength };
            Console.Write(Dim[0] + " x " + Dim[1]);
            return Dim;
        }

        /// <summary>
        /// Checks if a String / User input can be converted to an int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool CheckIfConvertable(String input)
        {
            bool isConvertable = false;
            if (int.TryParse(input, out _))
                isConvertable = true;
            return isConvertable;
        }

        /// <summary>
        /// Keeps the Program from closing
        /// </summary>
        public static void NoClose()
        {
            Console.ReadLine();
        }
    }
}
