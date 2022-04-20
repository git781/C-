using System;

namespace InheritProject // Note: actual namespace depends on the project name.
{
    internal class Program : File

    {
        static void Main(string[] args)
        {Console.WriteLine("Enter: 1 if want to enetr number, 2 if show contact by umber; 3 show all contact numbers; 4 show name by number"); 

// Create a string variable and get user input from the keyboard and store it in the variable
        string option = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
        Console.WriteLine("Option is: " + option);
        while (option!="0"){
        if (option == "1"){
            File file = new File();
            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number==0){
                break;
            }
            file.number = number;
            Console.WriteLine("Enter name:");
            file.name = Console.ReadLine();
        }
        else if (option == "2"){


            Console.WriteLine("Enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number==0){
                break;
            }
            Console.WriteLine(number);
            }

        }
        }
    }
}