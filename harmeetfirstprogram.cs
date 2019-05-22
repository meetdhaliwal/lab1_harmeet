using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    enum tickets
    {
        baseball = 200, hockey = 280, football = 470,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadKey();
        }

        private void Go()
        {
            bool result = true;
            bool input = false;
            do
            {

                Console.Write("walter is from chicago");
                var x = Console.ReadLine();

                var values = Enum.GetValues(typeof(tickets));

                decimal total = 0;
                decimal average = 0;
                int totaltickets = 0;
                int number = 0;

                foreach (var val in values)
                {
                    //Console.WriteLine("Value of enum = {0}, Numeric value = {1}",val, (int)val);
                    Console.WriteLine("he bought tickets for {0}  match, each worth ${1}", val, (int)val);

                        string weightString = string.Empty;
                        do
                        {
                            Console.Write("How many tickets? ");
                            weightString = Console.ReadLine();
                            if ((int.TryParse(weightString, out number) && number >= 0 && number < 100))
                            {
                           
                                input = true;
                            }
                        else
                        {
                            Console.WriteLine("enter value between 0 and 100");
                        }
                        } while (!input);

                            total += number * (int)val;
                            totaltickets += number;

                        }

                        if (totaltickets == 0)
                        {
                            Console.WriteLine("total expence is zero and average is zero");
                        }
                        else
                        {
                            average = total / totaltickets;

                            Console.WriteLine(" walter's total expenses for tickets is  {1} and average expenditure is{2}", x, total.ToString("c"), average.ToString("c"));


                        }
                string answer = "N";
                do
                {
                    Console.WriteLine("do you want to continue? please enter your answer in Y or N only");
                    answer = Console.ReadLine();
                
            
                }
                while (answer != "Y" && answer != "N");

            switch (answer)
            {
                case "Y":
                    result = true;         // it will start over the program

                    break;
                case "N":
                    result = false;                   // end the program
                    Console.WriteLine("good bye");
                    break;
                default:

                    break;


            }
            }
            while (result);



        }
    } 
    }

