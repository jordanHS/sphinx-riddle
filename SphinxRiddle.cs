using System;

class SphinxRiddle
{
   static void Main()
    {
        Console.WriteLine("The more you take, the more you leave behind. What am I?");
        string answerOne = Console.ReadLine();
        
       
    
        Console.WriteLine("What has a head, a tail, is brown, and has no legs?");
        string answerTwo = Console.ReadLine();

        bool footsteps = answerOne == "footsteps";
        bool pennies = answerTwo == "pennies";

        if (!(footsteps && pennies))
        {
            Console.WriteLine("Oh no! You got eaten!");
        }
         else if (footsteps && pennies)
        {
            Console.WriteLine("You defeated the sphinx!");
        }       
        
       

        
    }
  
}
