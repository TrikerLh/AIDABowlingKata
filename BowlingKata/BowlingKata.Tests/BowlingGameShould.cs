using FluentAssertions;

namespace BowlingKata.Tests {
	public class BowlingGameShould {
		[SetUp]
		public void Setup() {
		}

		[TestCase("81 81 81 81 81 81 81 81 81 81", 90)]
		[TestCase("41 41 41 41 41 41 41 41 41 41", 50)]
		[TestCase("52 14 33 81 21 42 32 22 51 33", 57)]
		public void ReturnScoreWithOutSpareAndStrikeAndBowlsFallsInBothRoll(string rolls, int score)
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