using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            //Console.WriteLine("Hello World!");
            Console.WriteLine(program.IsLeapYear(400));
            //Console.WriteLine(program.IsLeapYear(1700));
            //Console.WriteLine(program.IsLeapYear(1600));
        }

        public bool LeapYear2 (int year){
            if(year%4==0){
                return true;
            }
            else{
                return false;
            }
        }

        public bool IsLeapYear3 (int year){
            if (year%4 == 0){
                if (year%100==0){
                    return false;
                }
                return true;
            }
            return false;
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
