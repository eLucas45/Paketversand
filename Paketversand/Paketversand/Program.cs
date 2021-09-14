using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paketversand
{
    class Program
    {
                //if(int.TryParse(url, out int result))
                    //this.DoSomethingUsefull
        /// <summary>
        /// Main method; called on startup
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Code here
            Console.Title = "Paketversandrechner für Hermes";
            Explanation();
            requestData();
            noClose();
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
        public static void requestData()
        {

        }

        /// <summary>
        /// keeps the Program from closing
        /// </summary>
        public static void noClose()
        {
            Console.ReadLine();
        }
    }
}
