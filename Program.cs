using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace CodePractice_Loops_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingVariable = 20;
            Random random = new Random();
            int loopCount = 1;
            while (true)

            {
                Console.WriteLine("startingVariable > 0 && startingVariable < 50");
               
                int randomNumber = random.Next(0, 10);

            }
            if (startingVariable  % 2 == 0) ;
            {
                startingVariable -= 5;
            }
            
            //else 
            {
                startingVariable += 2;
                Console.WriteLine($"Loop:{loopCount}, RandomNumber:");
            }

            
                
        }
    }
}
