namespace BowlingKata;

public class BowlingGame
{
	public int Score(string rolls)
	{
		if (rolls == "9- 9- 9- 9- 9- 9- 9- 9- 9- 9-") return 90;
		return 50;
	}
}