using System;

namespace Lecture01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            var userInput = program.readInput();
            if(program.IsLeapYear(userInput)==true){
                Console.WriteLine("yay");
            }
            else{
                Console.WriteLine("nay");
            }
        } 

        public int readInput (){
            try{
                return int.Parse(Console.ReadLine());
            }
            catch (Exception){
                throw new Exception();
            }
        }

        public bool IsLeapYear (int year){
            if(year<1582){
                throw new Exception();
            }
            else{
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
}
