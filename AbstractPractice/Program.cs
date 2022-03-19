using System;

namespace AbstractPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            /*
             * 
             * 
             * Program class-ında bir menu olacaq
                1. Send message by email
                2. Send message by sms
                0. Quit
            */
            //Console.WriteLine("Menu\n1-Send Message By Email\n2-Send Message By Sms\n0-Quit");
            //string commandStr = Console.ReadLine();
            //int command;
            //while(!int.TryParse(commandStr,out command))
            //{
            //    Console.WriteLine("Warn :");
            //    Console.WriteLine("Menu\n1-Send Message By Email\n2-Send Message By Sms\n0-Quit");
            //    commandStr = Console.ReadLine();
            //}
            //int.TryParse(commandStr, out command);
            //switch (command)
            //{
            //    case 1:
            //        EmailSender emailSender = new EmailSender();
            //        emailSender.SendMessage();
            //        break;

            //    case 2:
            //        SmsSender smsSender = new SmsSender();
            //        smsSender.SendMessage();
            //        break;
            //    case 0:
            //        Console.WriteLine("Stop");
            //        break;
            //    default:
            //        Console.WriteLine("The End");
            //        break;
            //}
            #endregion

            #region Task2

            //Console.WriteLine("Menu");
            //Console.WriteLine("1. Square");
            //Console.WriteLine("2. Rectangular");
            //Console.WriteLine("0. Quit");

            //string choice = Console.ReadLine();

            //switch (choice)
            //{
            //    case "1":
            //        Console.WriteLine("Side:");
            //        int side = Convert.ToInt32(Console.ReadLine());
            //        Square square = new Square(side);
            //        Console.WriteLine(square.CalcArea());
            //        break;
            //    case "2":
            //        Console.WriteLine("Width:");
            //        int width = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Length:");
            //        int length = Convert.ToInt32(Console.ReadLine());

            //        Rectangular rectangular = new Rectangular(width, length);
            //        Console.WriteLine(rectangular.CalcArea());
            //        break;
            //    case "0":
            //        break;
            //    default:
            //        Console.WriteLine("wrong input");
            //        break;
            //}
            #endregion
        }
    }
}
