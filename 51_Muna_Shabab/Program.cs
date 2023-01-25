using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//chapter 5-6 51
//written by: Muna Shabab
//date:9-24-2020
namespace _51_Muna_Shabab
{
    class Program
    {
        static void Main(string[] args)
        {
            int largest=0;
            int secondLargest=0;
            int num;
            int numberEntered = 0;
            string userEntry;
            
            //prompt  the user for input
            Console.WriteLine("Please enter an integer or x to exit:");
            //read the input into a string variable
            userEntry = Console.ReadLine();

            //if the user input is a valid integer
            if (int.TryParse(userEntry, out num))
            {
                //set the largest number to the integer 
                largest = num;
                secondLargest = num - 1;
                //initiate a counter for entries
                numberEntered = 1;

            }

            //if the user enters x display that on the screen
            else if (userEntry == "x")
            {
                Console.WriteLine("you have entered x ");
          
            }

            //if the user enters a non integer value other than x 
            else
            {
                Console.WriteLine( userEntry + " is not a valid integer");
            }

            //while the entry is not x loop through the following statements
            while (userEntry!="x")
            {
                //prompt the user for an integer
                Console.WriteLine("Please enter the next integer or x to exit:");
                //read he entry into newEntry
                userEntry = Console.ReadLine();
                //if it is a valid integer
                if(int.TryParse(userEntry, out num))
                {
                    //increment the numbers entered
                    ++numberEntered;
                    //compare to the second largest if it is greater then it becomes the second largest
                    if (num > secondLargest)
                    {
                        
                        secondLargest = num;
                        //and if it is greater than the largest
                        if (secondLargest>largest)
                        {
                            secondLargest = largest;
                            largest = num;
                        }

                    }
                    

                }


            }

            //if there were ant enties
            if(numberEntered>1)
            {
                //display the results
                Console.WriteLine("the largest number you entered is " + (largest)
            + " and the second largest number you entered is " + (secondLargest));
                
            }

            Console.ReadLine();



        }
    }
}
