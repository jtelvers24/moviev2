using System;
using System.IO;
using NLog.Web;


namespace SleepData
{
    class Program
    {
        static void Main(string[] args)
        {
             string path = Directory.GetCurrentDirectory() + "//nlog.config";

            // create instance of Logger
            var logger = NLog.Web.NLogBuilder.ConfigureNLog(path).GetCurrentClassLogger();

            // log sample messages
            logger.Trace("Sample trace message");
            logger.Debug("Sample debug message");
            logger.Info("Sample informational message");
            logger.Warn("Sample warning message");
            logger.Error("Sample error message");
            logger.Fatal("Sample fatal error message");
            // ask for input
            Console.WriteLine("Enter 1 to create data file.");
            Console.WriteLine("Enter 2 to parse data.");
            Console.WriteLine("Enter anything else to quit.");
            // input response
            string resp = Console.ReadLine();
            int movieNumber = 0;

            if (resp == "1")
            {
                // create data file

                 // ask a question
                Console.WriteLine("Please enter data");
                // input the response (convert to int)
                String newMovie = Console.ReadLine();
                
                StreamWriter file1 = new StreamWriter("movies.csv", append: true);
                
                file1.WriteLine($"{newMovie}");
                movieNumber ++;
                
               
                
                file1.Close();
            }
            else if (resp == "2")
            {
                
                    

                    StreamReader sr = new StreamReader("movies.csv");
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split('|',',');
                            // display array data
                            System.Console.WriteLine($"{arr[1],-5}",arr);
                           
                        }
                        sr.Close();

                
            
              

        
            }
    }   }
}