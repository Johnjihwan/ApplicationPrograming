using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //string value = Console.ReadLine();

            Random random = new Random();
            string[] result = {
                "Rock", "Paper", "Scissors"
            };
            int machine = random.Next(result.Length);
            Console.Write(result[machine]);

            //switch (value)
            //{
            //    case "rock":

            //        break;

            //    case "paper":

            //        break;

            //    case "scissors":

            //        break;
            //}
        }
    }
}
