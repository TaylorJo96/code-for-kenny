namespace Lecture
{
    public partial class LectureExample
    {
        /*
        11. Write an if statement that returns "Fizz"
            if the parameter is 3 and returns an empty string for anything else.
            TOPIC: Conditional Logic
        */
        public string ReturnFizzIfThree(int number)
        {
            
            string returnValue = string.Empty;

            if(number == 3)
            {
                returnValue = "Fizz";
            }           

            return returnValue;
        }
    }
}
