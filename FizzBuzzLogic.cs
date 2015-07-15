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
            if (num % 3 != 0 && num % 5 != 0)
                answer = num.ToString();
            else
                answer = "no";

            return answer;
        }
    }
}
