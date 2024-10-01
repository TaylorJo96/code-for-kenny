namespace Lecture
{
    public partial class LectureExample
    {
        /*
        12. Now write the above using the Ternary operator ?:
        */
        public string ReturnFizzIfThreeUsingTernary(int number)
        {
            //terninary operator ? 
            // bool ? true : false
            //     bool experssion ? do this on true : do this on false.  
            return number == 3 ? "Fizz" : "";
        }
    }
}
