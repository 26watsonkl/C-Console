
using System.ComponentModel;

class If
{
    public static void Numbers(int number)
    {
    
        if(number > 0)
        {
            Console.WriteLine("Your number is Positive. ");
        }
        else if(number < 0)
        {
            Console.WriteLine("Your number is Negitive. ");
        }
        else
        {
            Console.WriteLine("Your number is Zero.");
        }
    }
    public static void Health(int Health)
    {
        if(Health > 75)
        {
            Console.WriteLine("The player is in great condition! ");
        }
        else if(Health < 75)
        {
            Console.WriteLine("The Player is in good condition! ");
        }
        else if(Health < 50)
        {
            Console.WriteLine("The player is in danger! ");
        }
        else if (Health < 0 )
        {
            Console.WriteLine("Game Over.");
        }
        else
        {
            Health = 100;
        }
    }
}