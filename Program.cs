namespace Training
{
    class Program
    {
        static void Main()
        {
            HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");
            Console.ReadKey();
        }

        static string HighAndLow(string stringValue)
        {
            List<int> numbers = new List<int>();
            string[] splitArray = stringValue.Split(" ");

            foreach (var item in splitArray)
            {
                int convertedInt = Convert.ToInt32(item);
                numbers.Add(convertedInt);
            }

            return ($"{numbers.Max()} {numbers.Min()}");
        }
    }
}

// Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"))