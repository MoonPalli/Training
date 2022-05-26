class Programm
{
    static void Main()
    {
        SplitString.Solution("abcde");
        Console.Read();
    }
}

public class SplitString
{
    public static string[] Solution(string str)
    {
        string[] result = new string[] { };
        int chunkSize = 2;
        int stringLength = str.Length;
        for (int i = 0; i < stringLength ; i += chunkSize)
        {
            if (i + chunkSize > stringLength)
            {
                chunkSize = stringLength  - i;
                result[i] = str.Substring(i, chunkSize);
                Console.Write("'" +str.Substring(i, chunkSize) + "_'");
                break;
            }
            result[i] = str.Substring(i, chunkSize);
            Console.Write("'" + str.Substring(i, chunkSize) + "', ");
        }
        Console.ReadLine();
        return new []{ str };;
    }
}