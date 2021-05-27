using System;

namespace Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello! Please write the name for the order below.");

            string orderName;
            orderName = Console.ReadLine();

            Console.WriteLine($"Hello {orderName}, I hope you had a good time at the resturant. How many people are in your party?");

            int partyAmount;
            partyAmount = int.Parse(Console.ReadLine());

            Console.WriteLine($"There are {partyAmount} members in your party. Is this correct?");

            bool answerOne;
            answerOne = true;

            if (answerOne)
            {
                Console.WriteLine($"That's great to hear! I hope our services benefited you greatly. How much would you add for a tip?");

            }
            else
            {
                Console.WriteLine($"I'm sorry, please enter the correct number of members in your party.");

                partyAmount = int.Parse(Console.ReadLine());

                Console.WriteLine($"There are now {partyAmount} members in your party. How much would you add for a tip? ");
                
            }

            decimal tipAmount;
            tipAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Is {tipAmount} correct?");

            string answerThree = null;
            answerThree = Console.ReadLine();

            if (answerThree == "Yes")
            {
                Console.WriteLine($"Alrighty! Thank you so much. Have a great day!");
            }
            else
            {
                Console.WriteLine($"I'm sorry, please retype the correct tip amount.");

                double newTipAmount;
                newTipAmount = double.Parse(Console.ReadLine());

                Console.WriteLine($"Your tip amount is now {newTipAmount}. Thank you!");
            }

            Console.WriteLine($"What section of the building were you seated in? Options: A, B, C, D.");

            char sectionType;
            sectionType = char.Parse(Console.ReadLine());

            Console.WriteLine($"Is Section {sectionType} correct?");

            string answerTwo = null;
            answerTwo = Console.ReadLine();

            if (answerTwo == "Yes")
            { }
            else
            {
                Console.WriteLine($"Please retype the correct section.");

                char newSectionType;
                newSectionType = char.Parse(Console.ReadLine());

                Console.WriteLine($"Your section is now {newSectionType}.");
            }

            Console.WriteLine($"Thank you for dining with us. How would you rate your experience with us on a scale of 1-10?");

            int experienceValue;
            experienceValue = int.Parse(Console.ReadLine());

            Console.WriteLine($"You rated your experience a {experienceValue} out of 10. We appreciate your feedback.");
        }
    
    }

}