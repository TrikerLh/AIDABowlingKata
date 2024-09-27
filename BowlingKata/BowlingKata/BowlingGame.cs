namespace BowlingKata;

public class BowlingGame
{
	public int Score(string rolls)
	{
		var scoreForRoll = rolls.Split(" ");

		var totalScore = 0;
		foreach (var score in scoreForRoll)
		{
			totalScore += Convert.ToInt32(score[0].ToString());
			totalScore += Convert.ToInt32(score[1].ToString());
		}

		return totalScore;
	}
}