using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_TDD_Demo
{
    public class FizzBuzzLogic
    {
        public string DoTheThing(int num)
        {
            string answer = "";
            if (num % 3 == 0 && num % 15 == 0)
                answer = "FizzBuzz";
            else if (num % 3 != 0 && num % 5 != 0)
                answer = num.ToString();
            else if (num % 3 == 0)
                answer = "Fizz";
            else if (num % 5 == 0)
                answer = "Buzz";
            

            return answer;
        }
       
    }
}
