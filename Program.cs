// Created by Austin9619
using System.Diagnostics;

namespace WatchDog
{
    class Program
    {
        static void Main()
        {
            // run program until user kills it 
            bool runProgram = true;
            string pName;
            do
            {
                Console.WriteLine("Enter the name of the process that you are looking for, type quit to end program");
                pName = Console.ReadLine();
                // Make sure pName - user input is not empty
                while (string.IsNullOrEmpty(pName))
                {
                    Console.WriteLine("You must enter something!");
                    pName = Console.ReadLine();
                }
                // check if user wants to end program
                if (pName.ToLower() == "quit")
                {
                    runProgram = false;
                }
                else
                {
                    LookForProcess(pName);
                }
                
            }
            while (runProgram);
        }

        static void LookForProcess(string pName)
        {
            //look for processes by name
            try
            {
                var process = Process.GetProcessesByName(pName);
                if (process.Length != 0)
                {
                    Console.WriteLine("Process found");
                }
                else
                {
                    Console.WriteLine("No process has been found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}