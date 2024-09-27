namespace BowlingKata;

public class BowlingGame
{
	public int Score(string rolls)
	{
		var scoreForRoll = rolls.Split(" ");

		var totalScore = 0;
		foreach (var score in scoreForRoll)
		{
			var firstAttempt = score[0].ToString();
			if (firstAttempt != "-")
			{
				totalScore += Convert.ToInt32(score[0].ToString());
			}
			var secondAttempt = score[1].ToString();
			if (secondAttempt != "-") {
				totalScore += Convert.ToInt32(score[1].ToString());
			}
		}

		return totalScore;
	}
}