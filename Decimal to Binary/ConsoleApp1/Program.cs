using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Sets if the program is running
            bool isRunning = true;

            
            Console.WriteLine("Let's convert decimal to binary!");
            Console.WriteLine("");

            //Initial Prompt
                Console.WriteLine("Please enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
      
            //While the program is running
            while (isRunning == true)
            {

                int remainder = 1;
                string binary = "";

                //Used to detect the length of the binary
                int length;
                //Used to add extra zeros later
                int placeholder = 0;

                //While the quotent is greater than '1', loop the process.
                do
                {
                    remainder = number % 2;
                    binary = (binary + remainder);
                    number = number / 2;

                } while (number > 1);

                

                //Adds quotent to front of the string value (binary)
                binary = (number + binary);

                //If the length of the string binary is lower than 8...
                if (binary.Length < 8)
                {
                    //Until length is equal to zero, add a zero to the front of the string for every 1 character
                    length = 8 - binary.Length;
                    do
                    {
                        binary = (placeholder + binary);
                        length = length - 1;
                    } while (length > 0);

                }

                Console.Write(binary);
                Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Please enter another Number:");
                number = Convert.ToInt32(Console.ReadLine());                

                }
            }
            
    }
}