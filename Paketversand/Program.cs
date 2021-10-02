﻿using System;
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
            Console.Title = "Paketversandrechner";
            int MaterialStrength = 3;
            double Density = 0.0007;
            Console.WriteLine("Diese Software berechnet den benötigten Briefmarkenwert.");

            //string[] PackageDim = new string[2];
            //PackageDim = Width + Length
            run(MaterialStrength, Density);
            while (ContinueCheck())
            {
                run(MaterialStrength, Density);
            }

        }

        public static void run(int MaterialStrength, double Density)
        {
            int[] PackageDim = RequestData(MaterialStrength);
            double[] result = WorkWithData(PackageDim, Density);
            //Console.WriteLine($"{result[1]} {result[0]}");
        }

        public static bool ContinueCheck()
        {
            Console.Write("\nMöchten sie fortfahren? [J/n] ");
            var key = Char.ToLower(Char.Parse(Console.ReadLine()));
            if (key == 'j' || key == 'y')
            {
                return true;
            }
            else if (key == 'n')
            {
                return false;
            }
            else
            {
                return false;
            }
        }
        //Package Dim, Density; returns double[]
        public static double[] WorkWithData(int[] Dim, double den)
        {
            Console.WriteLine($"Die Größen des Paketes sind: {Dim[0]}cm x {Dim[1]}cm x {Dim[2]}cm");
            Array.Sort(Dim, 0, 3);
            //Console.WriteLine($"Die Größen des Paketes sind: {Dim[0]}cm x {Dim[1]}cm x {Dim[2]}cm");
            double result2 = Dim[0] * Dim[1] * Dim[2] * den; //kg
            Console.WriteLine($"Das Paket ist {result2}kg schwer.");
            int sum = Dim[0] + Dim[2];
            double[] result = { result2, sum };
            return result;
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
            //Console.WriteLine($"{Dim[0]}cm x {Dim[1]}cm x {Dim[2]}cm");
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
            Lenth = int.Parse(inputLength);
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
            Width = int.Parse(inputWidth);
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
    }
}
