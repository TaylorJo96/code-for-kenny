using System;

namespace Variables_And_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rounding Error resources. 
            /*
             * DATA TYPE   RANGE
             *     bool    true or false
             *     byte    0 to 255
             *     char    U+0000 to U+FFFF             	single letter ('a','b'...)
             *     int     -2^31 to 2^31                	whole number (1,2,3...)
             *     long     -2^63 to 2^63              		same as int, but bigger!
             *     float   -3.4*10^38  to 3.4*10^38     	numbers w/ decimals(1.1, 2.55...)
             *     double  ±5.0 × 10^−324 to ±1.7 × 10^308 	same as float, but bigger!
             *     decimal (-7.9×10^28 to 7.9×1028) / (10^0 to 10^28)  like float/double, but much more precise!
             */



            //Prints out Hello Wolrd
            //Console.WriteLine("Hello World");

            // Single line comment asdf asdas fasdfasdfa
            /*multi line 
              comment
             */

            /* VARIABLES & DATA TYPES */

            /*
		    1. Create a variable to hold an int and call it numberOfExercises.
			Then set it to 26.
		    */
            //int numberOfExercises;
            //numberOfExercises = 26;

            int numberOfExercises = 26;
            Console.WriteLine(numberOfExercises);

            //numberOfExercises = 27;
            //Console.WriteLine(numberOfExercises);

            /*
            2. Create a variable to hold a double and call it half.
                Set it to 0.5.
            */

            double half = 0.5;
                        
            Console.WriteLine(half);

            /*
            3. Create a variable to hold a string and call it name.
                Set it to "TechElevator".
            */

            string name;
            name = "TechElevator";

            Console.WriteLine(name);

            /*
            4. Create a variable called seasonsOfFirefly and set it to 1.
            */

            int seasonsOfFirefly;
            seasonsOfFirefly = 1;
            Console.WriteLine(seasonsOfFirefly);

            /*
            5. Create a variable called myFavoriteLanguage and set it to "C#".
            */

            string myFavoriteLanguage = "C#";
            Console.WriteLine(myFavoriteLanguage);

            /*
            6. Create a variable called pi and set it to 3.1416.
            */

            double pi = 3.1416;
            Console.WriteLine(pi);

            /*
            7. Create and set a variable that holds your name.
            */

            string myName = "David Ferreira";

            /*
            8. Create and set a variable that holds the number of buttons on your mouse.
            */

            int mouseButtons = 3;
            Console.WriteLine(mouseButtons);
            /*
            9. Create and set a variable that holds the percentage of battery left on
            your phone.
            */

            double phoneBatteryPower = 0.55;
            Console.WriteLine(phoneBatteryPower);

            //Extra 
            string firstLetter = "a";
            char myLetter = 'a';

            //Break till 10:40;
            /* EXPRESSIONS */
            Console.WriteLine("Expressions");
            /*
            10. Create an int variable that holds the difference between 121 and 27.
            */
            //type variableName = expression to be evaluated;

            //int difference = 121 - 27;

            int difference;
            difference = 121 - 27;
            Console.WriteLine(difference);

            /*
            11. Create a double that holds the addition of 12.3 and 32.1.
            */

            double sum = 12.3 + 32.1;
            Console.WriteLine(sum);

            decimal sumDecimal = 12.3M + 32.1M;
            Console.WriteLine(sumDecimal);
            /*
            12. Create a string that holds your full name.
            */

            string fullName = "David Ferreira";

            /*
            13. Create a string that holds the word "Hello, " concatenated onto your
            name from above.
            */
            string greeting = "Hello, " + fullName;
            Console.WriteLine(greeting);
            /*
            14. Add a " Esquire" onto the end of your full name and save it back to
            the same variable.
            */
            fullName = fullName + " Esquire";
            Console.WriteLine(fullName);
            Console.WriteLine(greeting);

            /*
            15. Now do the same as exercise 14, but use the += operator.
            */
            fullName += " Esquire";
            Console.WriteLine(fullName);
            /*
            16. Create a variable to hold "Saw" and add a 2 onto the end of it.
            */
            string movieTitle = "Saw";
            movieTitle = movieTitle + 2;
            //movieTitle = movieTitle + "2";
            Console.WriteLine(movieTitle);
            /*
            17. Add a 0 onto the end of the variable from exercise 16.
            */
            movieTitle += 0;
            Console.WriteLine(movieTitle);
            /*
            18. What is 4.4 divided by 2.2?
            */
            decimal quotient = 4.4M / 2.2M;
            Console.WriteLine(quotient);

            /*
            19. What is 5.4 divided by 2?
            */

            decimal otherQuotient = 5.4M / 2M;

            
            Console.WriteLine(otherQuotient);
            double testQuotient = 5.4 / 2;
            Console.WriteLine(testQuotient);
            /* CASTING */

            /*
            20. What is 5 divided by 2?
            */
            int integerQuotient = 5 / 2;
            Console.WriteLine(integerQuotient);
            /*
            21. What is 5.0 divided by 2?
            */
            double doubleQuotient = 5 / 2.0;
            Console.WriteLine(doubleQuotient);
            /*
            22. Create a variable that holds a bank balance with the value of 1234.56.
            */
            double balance = 1234.56;
            /*
            23. If I divide 5 by 2, what's my remainder?
            */
            //Mod (%) calculates remainder.  integer math return what is left over. 
            int remainder = 5 % 2;
            Console.WriteLine(remainder);


            /*
            24. Create two variables: 3 and 1,000,000,000 and multiple them together.
                What is the result?
            */
            // Mutiplication (*).
            //casting type in front of value inside (). 
            long result = 3 * (long)1000000000;


            int variableOne = 3;
            int variableTwo = 1000000000;
            long resultProduct = (long)variableOne * variableTwo;


            /*
            25. Create a variable that holds a boolean called doneWithExercises and
            set it to false.
            */

            bool doneWithExercises = false;
            /*
            26. Now set doneWithExercise to true.
            */
            doneWithExercises = true;

            Console.ReadLine();
        }
    }
}
