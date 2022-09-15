namespace BowlingScoreCalculator;

public class BowlingScoreCalculator
{
    public static void Main() { }
    public static int ScoreCalc(string scoreRolls)
    {
        const int ZERO_BASED_ADJ = -1;
        const int MAX_ROLL = 20;
        const int BONUS_FINAL_ROLLS = 1;
        int[] rollScore = new int[MAX_ROLL + BONUS_FINAL_ROLLS];
        int rS = 0;
        string[] Rolls = scoreRolls.Split(' ');

        for (int Roll = 0; Roll < Rolls.Length; Roll++)
        {
            //debug code
            for (int dbgRoll = 0; dbgRoll < Rolls.Length; dbgRoll++)
            {
                Console.Write(Rolls[dbgRoll]);
                Console.Write(' ');
            }
            Console.Write('\r');
            for (int dbgRoll = 0; dbgRoll < rollScore.Length; dbgRoll++)
            {
                Console.Write(rollScore[dbgRoll]);
                Console.Write(' ');
            }
            Console.Write('\r');
            Console.Write("Roll:{0}   rS:{1}\r",Roll,rS);
            //end debug code

            switch (Rolls[Roll])
            {
                case "X":
                    rollScore[rS] = 10;
                    if (rS < MAX_ROLL-1)
                    {
                        if (Roll - 1 >= 0 && Rolls[Roll - 1].Equals("X")) { rollScore[rS - 2] += 10; }
                        if (Roll - 2 >= 0 && Rolls[Roll - 2].Equals("X")) { rollScore[rS - 4] += 10; }
                        if (rS < MAX_ROLL-2) rS++;
                    }
                    else if(rS < MAX_ROLL)
                    {
                        if (Rolls[Roll - 1].Equals("X")) { rollScore[rS - 1] += 10; }
                        if (Rolls[Roll - 2].Equals("X")) { rollScore[rS - 3] += 10; }
                    }
                    else if (rS < MAX_ROLL + BONUS_FINAL_ROLLS)
                    {
                        if (Rolls[Roll - 1].Equals("X")) { rollScore[rS - 1] += 10; }
                        if (Rolls[Roll - 2].Equals("X")) { rollScore[rS - 2] += 10; }
                    }
                    break;
                case "0": case "1": case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9":
                    rollScore[rS] = int.Parse(Rolls[Roll]);
                    break;
                case "/":
                    break;
                case "-":
                    break;
                //default:
            }
            rS++;

            //debug code
            for (int dbgRoll = 0; dbgRoll < rollScore.Length; dbgRoll++)
            {
                Console.Write(rollScore[dbgRoll]);
                Console.Write(' ');
            }
            Console.Write("\r\r");
            //end debug code

        }
        return rollScore.Sum() - rollScore[19] - rollScore[20]; 
    }
}