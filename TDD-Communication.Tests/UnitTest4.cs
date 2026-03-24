namespace TDD_Communication.Tests;
using Shouldly;
using TDD.Communications;

public class MoodTest
{
   
    [Test]
    public void CheckMood_WhereSingleLike_ReturnsLike()
    {
        var moodCheck = new Mood();
        OutCome[] input = { OutCome.LIKE };
        var result = moodCheck.EvaluateMoods(input);
        result.ShouldBe(OutCome.LIKE);
    }

    [Test]
    public void CheckMood_WhereSingleDislike_ReturnsDisLike()
    {
        var moodCheck = new Mood();
        OutCome[] input = { OutCome.DISLIKE };
        var result = moodCheck.EvaluateMoods(input);
        result.ShouldBe(OutCome.DISLIKE);
    }

    [Test]
    public void CheckMood_WhereDoubleLike_ReturnsNeutral()
    {
        var moodCheck = new Mood();
        OutCome[] input = { OutCome.LIKE, OutCome.LIKE };
        var result = moodCheck.EvaluateMoods(input);
        result.ShouldBe(OutCome.NEUTRAL);
    }

    [Test]
    public void CheckMood_WhereDoubleDisLike_ReturnsNeutral()
    {
        var moodCheck = new Mood();
        OutCome[] input = { OutCome.DISLIKE, OutCome.DISLIKE };
        var result = moodCheck.EvaluateMoods(input);
        result.ShouldBe(OutCome.NEUTRAL);
    }
    [Test]
    public void CheckMood_WhereLikeDislike_ReturnsNeutral()
    {
        var moodCheck = new Mood();
        OutCome[] input = { OutCome.LIKE, OutCome.DISLIKE };
        var result = moodCheck.EvaluateMoods(input);
        result.ShouldBe(OutCome.NEUTRAL);
    }


    [Test]
    public void CheckMood_WhereSequenceOutcomes_ReturnsNeutral()
    {
        var moodCheck = new Mood();
        OutCome[] input = { OutCome.LIKE, OutCome.LIKE, OutCome.LIKE, OutCome.DISLIKE, OutCome.LIKE, OutCome.LIKE };
        var result = moodCheck.EvaluateMoods(input);
        result.ShouldBe(OutCome.NEUTRAL);
    }
}
