namespace Training
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ValidatePin("a234"));
            
            Console.WriteLine(ValidatePin("-1.234"));
        }

        public static bool ValidatePin(string pin)
        {
            if (pin.Length != 4 || pin.Length != 6)
            {
                foreach (var item in pin)
                    if (char.IsDigit(item) == false)
                        return false;
                    else
                        return true;
            }
            return false;
        }
    }
}