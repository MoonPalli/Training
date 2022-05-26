class Programm
{
    static void Main()
    {
        SplitString.Solution("abcde");
    }
}

public class SplitString
{
    public static string[] Solution(string str)
    {
        int chunkSize = 2;
        int stringLength = str.Length;
        for (int i = 0; i < stringLength ; i += chunkSize)
        {
            if (i + chunkSize > stringLength)
            {
                chunkSize = stringLength  - i;
                Console.Write("'" +str.Substring(i, chunkSize) + "_'");
                break;
            }
            Console.Write("'" + str.Substring(i, chunkSize) + "', ");
        }
        Console.ReadLine();
        return str[];
    }
}