namespace BowlingKata;

public class BowlingGame
{
	public int Score(string rolls)
	{
		var scoreForRoll = rolls.Split(" ");

		var totalScore = 0;
		foreach (var score in scoreForRoll)
		{
			totalScore += GetScoreForRoll(score);
		}

		return totalScore;
	}

	private int GetScoreForRoll(string roll)
	{
		var score = 0;
		score += GetScoreForAttempt(roll[0]);
		score += GetScoreForAttempt(roll[1]);
		return score;
	}

	private int GetScoreForAttempt(char attempt)
	{
		if (attempt == '-') {
			return 0;
		}

		return Convert.ToInt32(attempt.ToString());
	}
}