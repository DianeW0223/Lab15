using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    class Program
    {
        string txt;
        static void Main(string[] args)
        {
            
            CountriesTextFile a = new CountriesTextFile();
            //this will welcome the user and then run the application.
            Console.WriteLine("Welcome to the Country Maintenace Database Application");
            a.setInput();
            a.runApp();
            
        }
        
    }
}
