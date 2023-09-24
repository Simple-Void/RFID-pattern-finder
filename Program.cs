//lordchazza 2023
RFID_program.mainRuntime();

public class RFID_program
{
    //datastructure declarations
    static List<string> tagCodes = new List<string>();
    static List<string> commonCodes = new List<string>();

    public static void mainRuntime()
    {
        tagCodes = tagInp();
        //debugTagWrite(tagCodes);
        commonCodes = commonPatterns(tagCodes);
    }

    static List<string> tagInp()
    {
        //function datastructures
        List<string> localTagCodes = new List<string>();
        string inp = "";
        bool exit = false;

        //reading
        Console.WriteLine("enter RFID codes, return a blank line to exit inputs");
        do
        {
            inp = Console.ReadLine();
            if (inp == "" || inp == " ")
            {
                exit = true;
            } else
            {
                localTagCodes.Add(inp);
            }
        } while (exit == false);

        return localTagCodes;
    }

    static List<string> commonPatterns(List<string> _localTagCodes)
    {
        //function datastructures
        List<string> commonPatterns = new List<string>();
        List<int> codeLengths = new List<int>();
        int maxLength = 0;

        //find lengths of all the codes
        foreach (string code in _localTagCodes)
        {
            codeLengths.Add(code.Length);
        }
        maxLength = codeLengths.Max();
        Console.WriteLine("max code length found; " + maxLength.ToString());

        //find any common patterns from 2 chars or more
        for (int pattLen = 2; pattLen < maxLength; pattLen++)
        {
            //pick a 2 char set
            //check for repeats in other codes (iterative for length of code)
                //if match add to list, maybe dict?
            //increment length
        }

        return commonPatterns;
    }

    static void debugTagWrite(List<string> _localTagCodes)
    {
        foreach (string RFIDcode in _localTagCodes)
        {
            Console.WriteLine(RFIDcode);
        }
    }
}