namespace BowlingScoreCalculator;

public class BowlingScoreCalculator
{
    public static void Main() { }
    public static int ScoreCalc(string scoreFrames)
    {
        const int ZERO_BASED_ADJ = -1;
        const int MAX_FRAME = 10;
        const int BONUS_FINAL_ROLLS = 2;
        int[] frameScore = new int[MAX_FRAME + BONUS_FINAL_ROLLS];
        string[] Frames = scoreFrames.Split(' ');
        for (int i = 0; i <= Frames.Length + ZERO_BASED_ADJ; i++)
        {
            //debug code
            for (int Frame = 0; Frame <= frameScore.Length + ZERO_BASED_ADJ; Frame++) {
                Console.Write(frameScore[Frame]);
                Console.Write(' ');
            }
            Console.Write('\r');
            //end debug code

            switch (Frames[i])
            {
                case "X":
                    frameScore[i] = 10;
                    if (i - 1 >= 0 && Frames[i - 1].Equals("X")) { frameScore[i - 1] += 10; }
                    if (i - 2 >= 0 && Frames[i - 2].Equals("X")) { frameScore[i - 2] += 10; }
                    break;
                case "/":
                    break;
                case "-":
                    break;
                //default:
            }
        }
        return frameScore.Sum() - frameScore[10] - frameScore[11]; 
    }
}