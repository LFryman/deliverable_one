using Microsoft.VisualBasic;
using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop for different vacations
            while (true)
            {

               
                //Input for vacation type
                Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? ");

                //Collect info
                string vacationType = Console.ReadLine();

                string destination = ("");

                //deciding destination
                if (vacationType == "musical")
                {
                    destination = "New Orleans";
                }
                else if (vacationType == "tropical")
                {
                    destination = "Beach Vacation in Mexico";
                }
                else if (vacationType == "adventurous")
                {
                    destination = "Whitewater Rafting the Grand Canyon";
                }


                //prompt Input for group size
                Console.Write("How many people are in your group? ");

                //collect
                string input = Console.ReadLine();
                int groupSize = int.Parse(input);

                string travelSuggestion = ("");

                //determin travelSuggestion  
                if (groupSize < 1)
                {
                    Console.WriteLine("Sorry, you actually need people in your group for a vacation.");

                }
              
                if (groupSize < 3)
                {
                    travelSuggestion = "First Class";
                }
                else if (groupSize < 6)
                {
                    travelSuggestion = "Helicopter";
                }
                else
                {
                    travelSuggestion = "Charter Flight";
                }

                //resulets 

                if (groupSize == 1)
                {
                    Console.WriteLine("Since you are going on a " + vacationType + " vacation and you have " + groupSize + " person in your group, you should travel " + travelSuggestion + " to " + destination);
                }
                else if (groupSize == 2)
                {
                    Console.WriteLine("Since you are going on a " + vacationType + " vacation and you have " + groupSize + " people in your group, you should travel " + travelSuggestion + " to " + destination);
                }
                else
                {
                    Console.WriteLine("Since you are going on a " + vacationType + " vacation and you have " + groupSize + " people in your group, you should take a " + travelSuggestion + " to " + destination);
                }

            }
 
        }
    }
}
