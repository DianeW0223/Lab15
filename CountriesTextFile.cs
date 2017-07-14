using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab15
{
    
    class CountriesTextFile
    {
        //private string filePath;
        private string input, file, aFile, text;
        string filePath;
        

        public CountriesTextFile()
        {
            filePath = @"C:\Users\wattsdi01\Desktop\Lab15\Countries.txt";
            //FileStream aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
            //StreamReader reader = new StreamReader(filePath);
            file = File.ReadAllText(filePath);


        }
        
        
        public void menu()
        {
            //this asks which menu item does the user want to do.
            Console.WriteLine("What would you like to do today?"); 
            string[] m = { "1 View List of Countries", "2 Add a new Country", "3 Exit" };
            //this creates the list of menu options.
            foreach (string mlist in m)
            {
                Console.WriteLine(mlist);
            }            
        }
        //this sets the input for the menu
        public string setInput()
        {
            menu();
            input = Console.ReadLine();
            return input;
            
        }
        //this retrieves the input.
        public string getInput()
        {
            return input;
        }
        //this method runs the application.
        public void runApp()

        {
            bool run = true;
            while (run == true)
            {
                if (input == "1")
                {
                    getTextFile();
                    run = Continue();
                }
                else if (input == "2")
                {
                    addNewC();
                    run = Continue();
                }
                else if (input == "3")
                {
                    exit();
                    run = false;
                    Console.WriteLine ("Good Bye!");
                }
                else
                {
                    Console.WriteLine("I didn't understand that, let's try again.");
                }
            }
        }
        //This method retrieves all the information in the text file.
        public void getTextFile()
        {
            StreamReader reader = new StreamReader(filePath);
            try
            {
                
                string files = File.ReadAllText(filePath);
                Console.WriteLine(files);
                                                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            reader.Close();
        }
        //This method was supposed to allow the adding of a new country, but I was unable to get it to work.
        public void addNewC()
        {
            StreamWriter aFile = new StreamWriter(filePath, true);
            try
            {
                test2();
                string newText = test3();
                File.AppendAllText(filePath, newText);


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("There was an error please review");

            }
            aFile.Close();
        }
        //this method exits the program.
        public string exit()
        {
            return "Good Bye!";
        }
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
        //the below methods were for testing on different ways i was trying to get the add new country method to work.
        public string test2()
        {
            Console.WriteLine();
            text = Console.ReadLine();
            return text;
        }
        public string test3()
        {
            return text;
        }
    }
}
