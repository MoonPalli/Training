namespace Training
{
    class Program
    {
        static void Main()
        {
            string[] testArray = SplitString.Solution("abcde");

            foreach (var item in testArray)
                Console.WriteLine($"\"{item}\"");
        }
    }

    public class SplitString
    {
        public static string[] Solution(string str)
        {
            List<string> result = new List<string>();
            string chunk = "";
            
            int chunkSize = 2;
            int stringLength = str.Length;
            
            for (int i = 0; i < stringLength ; i += chunkSize)
            {
                if (i + chunkSize > stringLength)
                    chunk = (str[i].ToString() + "_");
                else
                    chunk = (str[i].ToString() + str[i + 1].ToString());
                
                result.Add(chunk);
            }

            return result.ToArray();
        }
    }
}
