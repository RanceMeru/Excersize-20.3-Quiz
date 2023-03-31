internal class Program
{
    private static void Main(string[] args)
    {
        /*Write a program for a lawn mowing service. The season lasts 20
           weeks
            the weekly fee for mowing a lot under 400 square feet is $25
            the fee for a lot that is 400 square feet or more but under 600 feet is $35 per week
            the fee for a lot that is 600 square feet or over is $50 per weel 
            prompt the user the length and width of the lawn then diplay the total fee for the 20 week season and*/

         Console.WriteLine("What is the length of the lot?");
         double length = double.Parse(Console.ReadLine());
         Console.WriteLine("What is the width of the lot");
         double width = double.Parse(Console.ReadLine());

         double lawnArea = length * width;
         double weeklyPrice;


         if (lawnArea < 400)
         {
             weeklyPrice = 25;
             double seasontotal = weeklyPrice * 20;
             Console.WriteLine("Your total area is {0}" , lawnArea);
             Console.WriteLine("The total amount for the week will be  will be ${0}", weeklyPrice);
             Console.WriteLine("The total amount for the 20 week season will be  will be ${0}" ,seasontotal);
         }

         else if(lawnArea >= 400 && lawnArea < 600)
         {
             weeklyPrice = 35;
             Console.WriteLine("Your total area is {0}", lawnArea);
             double seasontotal = weeklyPrice * 20;
             Console.WriteLine("The total amount for the week will be  will be {0}", weeklyPrice);
             Console.WriteLine("The total amount for the 20 week season will be  will be ${0}", seasontotal);
         }
         else
         {
             weeklyPrice = 50;
             Console.WriteLine("Your total area is {0}", lawnArea);
             double seasontotal = weeklyPrice * 20;
             Console.WriteLine("The total amount for the week will be  will be ${0}", weeklyPrice);
             Console.WriteLine("The total amount for the 20 week season will be  will be ${0}", seasontotal);
         }
    }
}