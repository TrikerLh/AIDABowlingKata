using FluentAssertions;

namespace BowlingKata.Tests {
	public class BowlingGameShould {
		[SetUp]
		public void Setup() {
		}

		[Test]
		public void ReturnScoreWithOutSpareAndStrike()
		{
			var bowlingGame = new BowlingGame();

			var result = bowlingGame.Score("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-");

			result.Should().Be(90);
		}
	}

	public class BowlingGame
	{
		public int Score(string rolls)
		{
			return 90;
		}
	}
}


/******
 * X X X X X X X X X X X X = 300
 * 9- 9- 9- 9- 9- 9- 9- 9- 9- 9- = 90
 * 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5 = 150
 *
 ***********/