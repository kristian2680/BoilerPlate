using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            int input = int.Parse(Console.ReadLine());

            if(program.IsLeapYear(input)==true){
                Console.WriteLine("yay");
            }
            else{
                Console.WriteLine("nay");
            }
        }

        public bool IsLeapYear (int year){
            if (year%4 == 0){
                if (year%100==0){
                    if (year%400==0){
                        return true;
                    }
                    else {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
