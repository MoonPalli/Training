
void Main()
{
    HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4");
    Console.WriteLine("pizdec");
    Console.ReadKey();
}


void HighAndLow(string numbers)
{
    List<int> intNumbers = new List<int>();
    string[] charArray = numbers.Split(" ", StringSplitOptions.None);
    foreach (var i in numbers)
    {
        intNumbers.Add(Convert.ToInt32(numbers.Split(" ", StringSplitOptions.None)));
    }
    
    int a = intNumbers.Max();
    int b = intNumbers.Min();

    Console.WriteLine(charArray);
    Console.WriteLine(intNumbers);
    Console.WriteLine(a + b);
    
}

// Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"))