namespace LearningReturnStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            //here we are calling the method and returning a value back to the main method
            int cubedNumber = cube(3);
            Console.WriteLine(cubedNumber);


            Console.ReadLine();

        }

        static int cube(int num)
        {
            //in this method we taking the value of of the variable cube and telling it to num * num * num and return the result
            int result = num * num * num;
            return result;
        }
    }
}