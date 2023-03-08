namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n \n***********************************");
                Console.WriteLine("*           -Options-             *");
                Console.WriteLine("*                                 *");
                Console.WriteLine("*     Enter '1' for a JOKE!!*     *");
                Console.WriteLine("*                                 *");
                Console.WriteLine("*    Enter '2' for a FUN FACT!    *");
                Console.WriteLine("*                                 *");
                Console.WriteLine("* Enter '3' to CHECK UR GRADE O_O *");
                Console.WriteLine("*                                 *");
                Console.WriteLine("*     Enter '4' to QUIT ;_;       *");
                Console.WriteLine("***********************************");

                int option = Int32.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Your mom");
                } else if (option == 2)
                {
                    Console.WriteLine("Coding has over 700 languages! (very fun)");
                } else if (option == 3)
                {
                    Console.WriteLine("What grade did you get? (Enter A, B, C, D, or F)");
                    string grade = Console.ReadLine().ToUpper();

                    if (grade == "A")
                    {

                        Console.WriteLine("Your range is 85 - 100");

                    }
                    else if (grade == "B")
                    {
                        Console.WriteLine("Your range is 84 - 70");
                    }
                    else if (grade == "C")
                    {

                        Console.WriteLine("Your range is 55 - 69");

                    }
                    else if (grade == "D")
                    {
                        Console.WriteLine("Your range is 40 - 54");

                    }
                    else if (grade == "F")
                    {
                        Console.WriteLine(" You got less than forty oof ");

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input");
                        Console.WriteLine("******************************");
                    }

                } else if (option == 4)
                {
                    break;
                }
                else { Console.WriteLine("Enter Valid Input"); }
            }
        }
    }
}
