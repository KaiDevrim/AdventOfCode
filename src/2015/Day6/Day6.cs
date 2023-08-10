using System.Text;

public class Day6_2014
{
    private readonly string input = "./input.txt";

    public void Solution()
    {
        Console.WriteLine(Solution1());
    }

    private int Solution1()
    {
        using (StreamReader file = new(input))
        {
            bool[,] lightArray = new bool[999, 999];
            string line;
            while ((line = file.ReadLine()) != null)
                switch (line)
                {
                    case string l when l.StartsWith("turn on"):
                        string lSub = l.Substring(6);
                        int cInt = 0;
                        StringBuilder int1S = new StringBuilder();
                        while (lSub[cInt] != ',')
                        {
                            int1S.Append(lSub[cInt]);
                            cInt++;
                        }
                }
        }

        return 0;
    }

    public int Solution2()
    {
        return 0;
    }
}