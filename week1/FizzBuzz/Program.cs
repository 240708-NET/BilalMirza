class Program
{
    public static void Main( string[] args)
    {

        //Play Fizzbuzz
        // As a user, I want to play Fizz Buzz from 1 to 20
        // Count from lower to upper numbers, printing each one to it's own line
        // When a multiple of 3 is being printed, replace with 'Fizz'
        // When a multiple of 5 is being printed, replace with 'Buzz'
        // When a multiple of 3 and 5 is being printed, replace with 'FizzBuzz'

        // When a multiple of 3 and 7 is being printed, replace with 'FizzBang'
        // When a multiple of 5 and 7 is being printed, replace with 'BuzzBang'
        // When a multiple of 3, 5, and 7 is being printed, replace with 'FizzBuzzBang'

        // Collections: an object in memory that holds/stores a group of similarly types objects
        // Enumerable: object that contains other objects, and allows them to be iterated through

        // Array: fixed size in memory
        // List: dynamic (can be added to, or removed from - one element at a time)
        // Dictionary: made of Keys and Values, but have no "index"

        Dictionary<int, string> wordVals = new Dictionary<int, string> ();
        wordVals.Add (3, "Fizz");
        wordVals.Add (5, "Buzz");
        wordVals.Add (7, "Bang");
        wordVals.Add (9, "Crack");

        int startNum = 1;
        int endNum = 25;

        /*
        int fizzNum = 3;
        int buzzNum = 5;
        int bangNum = 7;
        int crackNum = 9;
        int counter;
        */

        for (int i = startNum; i <= endNum; i++)
        {
            Console.WriteLine(FizzBuzzBuilder( wordVals, i));

            /*
            counter = 0;

            // % divides, and returns the reminder of the division
            if (i % fizzNum == 0)
            {
                Console.Write("Fizz");
                counter++;
            }
            
            if (i % buzzNum == 0)
            {
                Console.Write("Buzz");
                counter++;
            }
            
            if (i % bangNum == 0)
            {
                Console.Write("Bang");
                counter++;
            }

            if (i % crackNum == 0)
            {
                Console.Write("Crack");
                counter++;
            }
            
            if (counter == 0)
            {
                Console.Write(i); //Write each number
            }

            Console.WriteLine();
            */

        }
    }

    public static string FizzBuzzBuilder( Dictionary<int, string> wordVals, int i)
    {
        string output = "";
        foreach (KeyValuePair<int,string> val in wordVals)
        {
            //Console.Write(" - " + val.Key + " - ");
            if(i % val.Key == 0)
            {
                output += val.Value;
            }
        }

        if (String.IsNullOrEmpty(output)) //boolean
        {
            output += i.ToString();
        }

        return output;
    }

}
