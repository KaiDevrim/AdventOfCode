namespace AdventOfCode;

public class Day2_2022
{
    public int Day2_1()
    {
        int score = 0;
        string[] input = File.ReadAllLines("../../../2022/Day2/input.txt");
        foreach (string item in input)
        {
            if (item[2] == 'X')
            {
                switch (item[0])
                {
                    case 'A': score += 4;
                        break;
                    case 'B': score += 1;
                        break;
                    case 'C': score += 7;
                        break;
                }
            }

            if (item[2] == 'Y')
            {
                switch (item[0])
                {
                    case 'A': score += 8;
                        break;
                    case 'B': score += 5;
                        break;
                    case 'C': score += 2;
                        break;
                }
            }
            
            if (item[2] == 'Z')
            {
                switch (item[0])
                {
                    case 'A': score += 3;
                        break;
                    case 'B': score += 9;
                        break;
                    case 'C': score += 6;
                        break;
                }
            }
        }
        return score;
    }

    public int Day2_2()
    {
        int score = 0;
        string[] input = File.ReadAllLines("../../../2022/Day2/input.txt");
        foreach (string line in input)
        {
            if (line.Contains('X'))
            {
                score += line[0] == 'A' ? 3 : line[0] == 'B' ? 1 : 2;
            }
            if (line.Contains('Y'))
            {
                score += line[0] == 'A' ? 4 : line[0] == 'B' ? 5 : 6;
            }
            if (line.Contains('Z'))
            {
                score += line[0] == 'A' ? 8 : line[0] == 'B' ? 9 : 7;
            }
        }
        return score;
    }
}