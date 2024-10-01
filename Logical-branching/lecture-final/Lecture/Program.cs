using System;

namespace Lecture
{
    class Program
    {


        static void Main(string[] args)
        {
            /*
            
             * EXPRESSION: Expressions are variables, operators & methods that evaluate to a single value
             *  -each expression is evaluated separately, even if they are all in the same line

            STATEMENT: A complete unit of execution
             *  -a "sentence" or command
             *  -must end in a semi-colon;

    
             * COMPARISON OPERATORS: Compares values and returns TRUE or FALSE
             *  OPERATOR    MEANING
             *  ==          equal to
             *  !=          not equal
             *  >           greater than
             *  <           less than
             *  >=          greater than or equal to
             *  <=          less than or equal to

             
             * LOGICAL OPERATORS
             *  !   not
             *  &&  and
             *  ||  or
             *  ^   1 true, 1 false. AKA, XOR, exclusive OR
             *  
             *  
             Truth table:
             
            A       B           !A      A && B  A || B  A ^ B
            TRUE    TRUE        FALSE   TRUE    TRUE    FALSE
            TRUE    FALSE       FALSE   FALSE   TRUE    TRUE
            FALSE   TRUE        TRUE    FALSE   TRUE    TRUE
            FALSE   FALSE       TRUE    FALSE   FALSE   FALSE

             *  
             *  
             *  
             *  
             *  IF statements use BOOLEAN expressions to control program flow
             *  -The expression goes in parenthesis
             *  -the conditional code to execute goes in {  }
             *  
             *  METHOD: a named block of code that you can execute/call multiple times
             *  -A method takes a specific input and produces a specific output
             *  -the code to execute goes inside the braces { }
             *  -Method signature:  [ACCESS_MODIFIER] [RETURN_TYPE] [METHOD_NAME] ([PARAMETER LIST]) {
             *      public int addNumbers (int num1, int num2) {}
             *  
             *  -return void if nothing is to be returned
             *  -parameters have a type and a name, separated by commas
             *  -Method names always start with a capital letter in C#

             *  
             */






            int x = 5 + 1;  //5+1 is an expression. The whole line is a statement
            int z = (5 + 10) / 3;   //multiple expressions. 5+10 is calculated first


            Console.WriteLine(1 == 2);
            Console.WriteLine(1 != 2);
            Console.WriteLine(1 > 2);


            Console.WriteLine("!true: " + (!true));
            Console.WriteLine("true && true: " + (true && true));
            Console.WriteLine("true && false: " + (true && false));
            Console.WriteLine("false && false: " + (false && false));
            Console.WriteLine("true || false: " + (true || false));
            Console.WriteLine("true ^ false: " + (true ^ false));
            Console.WriteLine("true ^ true: " + (true ^ true));

            Console.WriteLine("NAND - not and: false nand false " + (!false && true));



            Console.WriteLine("Hello World!");


            int cupsOfCoffee = 121;
            if (cupsOfCoffee < 2)
            {
                Console.WriteLine("You don't need a beverage carrier");
                Console.WriteLine("Less coffee is best coffee!");
            }
            else if (cupsOfCoffee > 8)
            {
                //else if true()
                Console.WriteLine("You should buy a larger coffee container...");
            }
            else
            {
                //all other conditions are false.
                Console.WriteLine("You are going to need a beverage carrier!");
            }

            //Break till 10:30.
            Console.WriteLine("you have " + cupsOfCoffee + " cups of coffee");


            int length = 4;
            int width = 5;
            int area = MultiplyTwoNumbers(length, width);
            Console.WriteLine("The area is " + area);

            //Break till 1:10

        }

        public static void MakeDinner(string noodle, string sause)
        {
            string resultsOfDinner = "I made " + noodle + " " + sause + " dinner!";

            Console.WriteLine(resultsOfDinner);
        }

        public static void BoilEggs(string eggName, int numberOfEggs)
        {

        }
        public static int MultiplyTwoNumbers(int num1, int num2)
        {
            int product = num1 * num2;
            return product;
        }


    }
}
