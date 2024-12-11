namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        // var text = Console.ReadLine();
        // var result = RemoveTheLastTwo(text);
        // Console.WriteLine(result);
        
    }

    public static string RemoveTheLastTwo(string text)
    {
        return text.Remove(text.Length - 2);
    }

    public static int CountTwoDigits(List<int> numbers)
    {
        var count = 0;
        foreach (var number in numbers)
        {
            if (number > 9 && number < 100)
            {
                count++;
            }
        }

        return count;
    }

    public static bool CheckIsUpper(List<string> texts)
    {
        var isUpper = false;
        foreach(var text in texts)
        {
            if (char.IsUpper(text[0]) is true)
            {
                isUpper = true;
            }
            else
            {
                isUpper = false;
                break;
            }
        }
        
        return isUpper;
    }

    public static bool CheckLastAndStart(string text)
    {
        var start = text.StartsWith("PDP");
        var end = text.EndsWith("PDP");

        if (start == end is true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}