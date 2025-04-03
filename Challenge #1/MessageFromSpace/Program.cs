using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        Console.WriteLine("Test 1....");
        output = spaceMessage("ABCD");
        if (output == "ABCD")
        {
            Console.WriteLine("Test 1 Passed: " + output );
        }
        else
        {
            Console.WriteLine("Test 1 Failed... " + output);
        }
        output = spaceMessage("AB[3CD]");
        Console.WriteLine("Test 2...");
        if (output == "ABCDCDCD")
        {
            Console.WriteLine("Test 2 Passed: " + output );
        }
        else
        {
            Console.WriteLine("Test 2 Failed... " + output);
        }
        Console.WriteLine("Test 3... ");  
        output = spaceMessage("IF[2E]LG[5O]D");     
        if (output == "IFEELGOOOOOD")
        {
            Console.WriteLine("Test 3 Passed: " + output );
        }
        else
        {
            Console.WriteLine("Test 3 Failed... " + output);
        }
    }

    static string spaceMessage(string message)
    {
        string newMessage = "";
        return newMessage;
    }

}