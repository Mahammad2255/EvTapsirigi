using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tapsiriq 1
            int counter = 0;
            int a = 2;


            if (a == 0 || a == 1)
            {
                Console.WriteLine("Ne sadedir ne de murekkeb");
                

            }
            else if 
                 (a < 0) { 
                {
                    Console.WriteLine("Musbet daxil et");
                }
            }
           
            else
            {
               
                for (int i = 2; i < a; i++)


                    if (a % i == 0)
                    {
                        counter++;
                        break;
                    }
                if (counter == 0)
                {
                    Console.WriteLine("Sadedir");
                }
                else
                {
                    Console.WriteLine("Murekkebdir");
                }
            }
           //tapsiriq 2
            int say = 142;
            int reqem;
            int cem = 0;
            while (say > 0)
            {
                reqem = say % 10;
                cem = cem + reqem;
                say = say / 10;

            }
            Console.WriteLine(cem);


            //tapsiriq 3 
            int ay = 1;

            switch (ay)
            {
                case 1:
                    Console.Write("Qış");
                    break;
                case 2:
                    Console.Write("Qış");
                    break;
                case 3:
                    Console.Write("Yaz");
                    break;
                case 4:
                    Console.Write("Yaz");
                    break;
                case 5:
                    Console.Write("Yaz");
                    break;
                case 6:
                    Console.Write("Yay");
                    break;
                case 7:
                    Console.Write("Yay");
                    break;
                case 8:
                    Console.Write("Yay");
                    break;
                case 9:
                    Console.Write("Payiz");
                    break;
                case 10:
                    Console.Write("Payiz");
                    break;
                case 11:
                    Console.Write("Payiz");
                    break;
                case 12:
                    Console.Write("Qış");
                    break;
                default:
                    Console.Write("Aylar 1-12 araliginda olmalidir");
                    break;
            }
        }
           
            
        }
   }

