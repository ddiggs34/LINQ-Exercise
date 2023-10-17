using System.Collections.Specialized;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        { /*Create a list of video game names... - DONE
            Order the list of games by length of the game name.
            Use the lambda expression in this exercise as well.
            Use Method Syntax for this exercise*/
            
            var videogames = new string[] { "Call Of Duty", "Super Mario", "Sonic", "NBA 2K", "Final Fantasy", "Suikoden" }; // create a list
            var gameNamesOrder = videogames.OrderBy(videogames => videogames.Length).ToList(); //orders the list by LENGTH
            
            foreach ( var gameName in gameNamesOrder ) 
            {
                Console.WriteLine(gameName);
            }
        }
    }
}
