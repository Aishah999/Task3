namespace Task;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    static string CustomSubstring(string input,int startIndex,int length)
    {
        if(input==null)
        {
            throw new
          ArgumentNullException(nameof(input));
        }
        if(startIndex<0||startIndex>=input.Length)
        {
            throw new
                ArgumentOutOfRangeException(nameof(startIndex));
        }
        if(length<0||startIndex+length>input.Length)
        {
            throw new
                ArgumentOutOfRangeException(nameof(length));
        }
        char[] result = new char[length];
        for(int i=0;i<length;i++)
        {
            result[i] = input[startIndex + i];
        }
        return new string(result);
    }
}

