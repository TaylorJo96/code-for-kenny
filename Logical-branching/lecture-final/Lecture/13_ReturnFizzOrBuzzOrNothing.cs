﻿namespace Lecture
{
    public partial class LectureExample
    {
        /*
         13. Write an if/else statement that returns
            "Fizz" if the parameter is 3,
            "Buzz" if the parameter is 5
            and an empty string "" for anything else.
            TOPIC: Conditional Logic
         */
        public string ReturnFizzOrBuzzOrNothing(int number)
        {
            
            /*string returnValue = "";
            if(number == 3)
            {
                returnValue = "Fizz";
            }
            else if(number == 5)
            {
                returnValue = "Buzz";
            }

            return returnValue;
            */

            if(number == 3)
            {
                return "Fizz";
            }
            if(number == 5)
            {
                return "Buzz";
            }

            return "";

            
        }
    }
}
