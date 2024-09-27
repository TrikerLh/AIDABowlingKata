using FluentAssertions;

namespace BowlingKata.Tests {
	public class BowlingGameShould {
		[SetUp]
		public void Setup() {
		}

		[TestCase("9- 9- 9- 9- 9- 9- 9- 9- 9- 9-", 90)]
		public void ReturnScoreWithOutSpareAndStrike(string rolls, int score)
		{
			var bowlingGame = new BowlingGame();

			var result = bowlingGame.Score(rolls);

			result.Should().Be(score);
		}
	}
}


/******
 * X X X X X X X X X X X X = 300
 * 9- 9- 9- 9- 9- 9- 9- 9- 9- 9- = 90
 * 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/ 5/5 = 150
 *
 ***********/