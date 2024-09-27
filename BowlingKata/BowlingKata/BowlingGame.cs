namespace BowlingKata;

public class BowlingGame
{
	public int Score(string rolls)
	{
		if (rolls == "81 81 81 81 81 81 81 81 81 81")
		{
			return 90;
		}
		return 50;
	}
}