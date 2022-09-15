namespace BowlingScoreCalculator;

public class BowlingScoreCalculator
{
    public static void Main() { }
    public static int ScoreCalc(string scoreFrames)
    {
        const int ZERO_BASED_ADJ = -1;
        int[] frameScore = new int[12];
        string[] Frames = scoreFrames.Split(' ');
        for (int i = 0; i <= Frames.Length + ZERO_BASED_ADJ; i++)
        {
            switch (Frames[i])
            {
                case "X":
                    frameScore[i] = 10;
                    if (i - 1 >= 0 && frameScore[i - 1] == 'X') { frameScore[i - 1] += 10; }
                    if (i - 2 >= 0 && frameScore[i - 2] == 'X') { frameScore[i - 2] += 10; }
                    foreach (int Frame in frameScore) {
                        Console.Write(frameScore[Frame]);
                        Console.Write(' ');
                    }
                    Console.Write('\r');
                    break;
                case "/":
                    break;
                case "-":
                    break;
                //default:
            }
        }
        return frameScore.Sum(); 
    }
}