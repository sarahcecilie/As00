using System;

namespace doAssignment0
{
    public class LeapYear
    {
        public static void Main(string[] args){
           int input = Convert.ToInt32(Console.ReadLine());
            if(isLeapYear(input) == true){
                Console.WriteLine("yay");
            } else{
                Console.WriteLine("nay");
            }
        }
        public static bool isLeapYear(int year){
            if(year % 4 == 0){
                if(year % 400 == 0){
                    return true;
                } if(year % 100 == 0){
                    return false;
                }
                return true;
            } else{
                return false;
            }
        }
    }
}
