namespace topic_7._1___While_loop_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ashlyn Wright
            //top7.1 While loop assignment

            //Assignment 1

            //int number1;
            //int number2;
            //int number3;
            //int number4;

            //Console.WriteLine("please enter the first number");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the second number");
            //number2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the third number");
            //number3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the fourth number");
            //number4 = Convert.ToInt32(Console.ReadLine());

            //int sum = number1 + number2 + number3 + number4;
            //double average = sum / 4.0;

            //Console.WriteLine("the average of your numbers is " + average + "");



            //Assignment 2

            Random Random = new Random();
            int secretNumber = Random.Next(1, 101); 
            Console.WriteLine("please enter a number between 1 and 100");
            int userguess = Convert.ToInt32(Console.ReadLine());
            do
            {        
                if (userguess < secretNumber)
                {
                    Console.WriteLine("too low, please try again");
                    userguess = Convert.ToInt32(Console.ReadLine());
                }
                else if (userguess > secretNumber)
                {
                    Console.WriteLine("too high, please try again");
                    userguess = Convert.ToInt32(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine("Congratulations, you guessed the right number!");
                    userguess = Convert.ToInt32(Console.ReadLine());
                }
            } while (userguess != secretNumber);
           
             


















        }
    }
}
