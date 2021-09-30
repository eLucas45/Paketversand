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
            int MaterialStrength = 3;
            double Density;
            Console.Title = "Paketversandrechner";
            Explanation();

            //string[] PackageDim = new string[2];
            //PackageDim = Width + Length
            int[] PackageDim = RequestData(MaterialStrength);
            WorkWithData(PackageDim);
            
            NoClose();
        }

        public static void WorkWithData(int[] Dim)
        {
            Array.Sort(Dim, 0, 2);
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
        public static int[] RequestData(int Materialstr)
        {
            //string[] Dim = new string[2];
            int inputWidth = ReqWidth();
            int inputLength = ReqLength();
            
            //PackageDim
            //Dim[0] = inputWidth;
            //Dim[1] = inputLength;
            int[] Dim = { inputWidth, inputLength, Materialstr };
            //Console.Write(Dim[0] + " x " + Dim[1]);
            Console.WriteLine($"{Dim[0]} x {Dim[1]} x {Dim[2]}");
            return Dim;
        }
        
        /// <summary>
        /// Gets the Length from the user
        /// </summary>
        /// <returns></returns>
        public static int ReqLength()
        {
            int Lenth = 250;
            string inputLength = "this is text";
            while (!CheckIfConvertable(inputLength))
            {
                Console.Write("Bitte gebe die Länge des Pakets in cm ein: ");
                inputLength = Console.ReadLine();
            }
            return Lenth;
        }

        /// <summary>
        /// Gets the Width from the user
        /// </summary>
        /// <returns></returns>
        public static int ReqWidth()
        {
            int Width = 250;
            string inputWidth = "this is text";
            while (!CheckIfConvertable(inputWidth))
            {
                Console.Write("Bitte gebe die Breite des Pakets in cm ein: ");
                inputWidth = Console.ReadLine();
            }
            return Width;
        }



        /// <summary>
        /// Checks if a String / User input can be converted to an int
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool CheckIfConvertable(string input)
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
