using System;

namespace fortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, birthMonthInput, ageInput, numberOfSiblingsInput;
            string vacationHomeLocation = "";
            string modeOfTransportation = "";
            int age, birthMonth, numberOfSiblings, retirementYears;
            double bankBalance;
            string favoriteColor;
            Console.WriteLine("Welcome to the fortune teller program!");
            //get useer first name
            Console.WriteLine("Please enter the users first name: ");
             firstName=Console.ReadLine();
            //get user last name
            Console.WriteLine("please enter your last name: ");
            lastName = Console.ReadLine();
            //get user age
            Console.WriteLine("please enter your age: ");
            ageInput = Console.ReadLine();
            //convert ageInput to integer
            age = Convert.ToInt32(ageInput);
            //get user birth month
            Console.WriteLine("please enter your birth month as an integer");
            birthMonthInput = Console.ReadLine();
            //convert birthmonth input to integer
            birthMonth = Convert.ToInt32(birthMonthInput);
            //get user favorite color
            Console.WriteLine("please enter your favorite ROYGBIV:  If you don't know what that is type help for help:");
            favoriteColor = Console.ReadLine();
           
            while (favoriteColor == "help")
            { 
            
            
                Console.WriteLine("ROYGBIV COLORS:");
                Console.WriteLine("Red,Orange,Yellow,Green,Blue,Indigo,Violet");
                Console.WriteLine("please enter your favorite ROYGBIV:  If you don't know what that is type help for help:");
                favoriteColor = Console.ReadLine();
            }
            // get users number of  siblings.
            Console.WriteLine("please enter your number of siblings: ");
            // input numberof siblings Input
            numberOfSiblingsInput = Console.ReadLine();

            // convert numbersiblingsInput to integer
            numberOfSiblings = Convert.ToInt32(numberOfSiblingsInput);
            //calculations
            switch (favoriteColor)
            {
                case "Red": modeOfTransportation = "massaratti";
                    break;
                case "Orange": modeOfTransportation = "stallion";
                    break;
                case "Yellow": modeOfTransportation = "chariot";
                    break;
                case "Green": modeOfTransportation = "taxi";
                    break;
                case "Blue": modeOfTransportation = "rickshaw";
                    break;
                case "Indigo": modeOfTransportation = "motor scooter";
                    break;
                case "Violet": modeOfTransportation = "flying saucer";
                        break;
                
                    
            }
            if (age % 2 == 0)
            {
                retirementYears = 12;
            }
            else
            {
                retirementYears = 15;
            }
            // assign vacationHomeLocation
            switch (numberOfSiblings)
            {
                case 0: vacationHomeLocation = "The moon";
                    break;
                case 1: vacationHomeLocation = "Earth";
                    break;
                case 2: vacationHomeLocation = "Mars";
                    break;
                case 3: vacationHomeLocation = "Jupiter";
                    break;
                default: vacationHomeLocation = "Venus";
                    break;
            } // end switch 
            // assign vacatioinHomeLocation continued
            if (numberOfSiblings > 3)
            {
                vacationHomeLocation = "Saturn";
            }
            if (numberOfSiblings < 0)
            {
                vacationHomeLocation = "Uranus";
            }

            //calculate bank balance based on birth month
            if (birthMonth >=0&& birthMonth <= 4)
            {
                bankBalance = 256000.76;
            }
            else
            {
                if(birthMonth<=8 && birthMonth >= 5)
                {
                    bankBalance = 3687105.42;
                }
                else
                {
                    if(birthMonth <=9 && birthMonth <= 12)
                    {
                        bankBalance = 86.23;
                    } else
                    {
                        bankBalance = 0.0;
                    }
                }
            }
            // display the users fortune
            Console.Write(firstName + " " + lastName + " ");
            Console.Write("will retire in " + retirementYears);
            Console.Write(" " + "with " + bankBalance);
            Console.WriteLine("in the bank,");
            Console.Write("a vacation home in " + vacationHomeLocation);
            Console.Write(", and travel mode by " + modeOfTransportation);
            Console.WriteLine();
            Console.ReadKey();






        }
    }
}
