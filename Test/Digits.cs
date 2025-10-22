using static Bismuth083.AlgorithmPractice.Digits;
namespace Bismuth083.AlgorithmPractice.Test;

public class TestDigits
{
  [Test]
  public void TestCalcDigits()
  {
    Assert.That(CalcDigits(0), Is.EqualTo(1));
    Assert.That(CalcDigits(1), Is.EqualTo(1));
    Assert.That(CalcDigits(5), Is.EqualTo(1));
    Assert.That(CalcDigits(9), Is.EqualTo(1));
    Assert.That(CalcDigits(10), Is.EqualTo(2));
    Assert.That(CalcDigits(99), Is.EqualTo(2));
    Assert.That(CalcDigits(100), Is.EqualTo(3));
    Assert.That(CalcDigits(999), Is.EqualTo(3));
    Assert.That(CalcDigits(1_000), Is.EqualTo(4));
    Assert.That(CalcDigits(9_999), Is.EqualTo(4));
    Assert.That(CalcDigits(10_000), Is.EqualTo(5));
    Assert.That(CalcDigits(99_999), Is.EqualTo(5));
    Assert.That(CalcDigits(100_000), Is.EqualTo(6));
    Assert.That(CalcDigits(999_999), Is.EqualTo(6));
    Assert.That(CalcDigits(1_000_000), Is.EqualTo(7));
    Assert.That(CalcDigits(9_999_999), Is.EqualTo(7));
    Assert.That(CalcDigits(10_000_000), Is.EqualTo(8));
    Assert.That(CalcDigits(99_999_999), Is.EqualTo(8));
    Assert.That(CalcDigits(100_000_000), Is.EqualTo(9));
    Assert.That(CalcDigits(999_999_999), Is.EqualTo(9));
    Assert.That(CalcDigits(1_000_000_000), Is.EqualTo(10));
    Assert.That(CalcDigits(9_999_999_999), Is.EqualTo(10));
    Assert.That(CalcDigits(10_000_000_000), Is.EqualTo(11));
    Assert.That(CalcDigits(99_999_999_999), Is.EqualTo(11));
    Assert.That(CalcDigits(100_000_000_000), Is.EqualTo(12));
    Assert.That(CalcDigits(999_999_999_999), Is.EqualTo(12));
    Assert.That(CalcDigits(1_000_000_000_000), Is.EqualTo(13));
    Assert.That(CalcDigits(9_999_999_999_999), Is.EqualTo(13));
    Assert.That(CalcDigits(10_000_000_000_000), Is.EqualTo(14));
    Assert.That(CalcDigits(99_999_999_999_999), Is.EqualTo(14));
    Assert.That(CalcDigits(100_000_000_000_000), Is.EqualTo(15));
    Assert.That(CalcDigits(999_999_999_999_999), Is.EqualTo(15));
    Assert.That(CalcDigits(1_000_000_000_000_000), Is.EqualTo(16));
    Assert.That(CalcDigits(9_999_999_999_999_999), Is.EqualTo(16));
    Assert.That(CalcDigits(10_000_000_000_000_000), Is.EqualTo(17));
    Assert.That(CalcDigits(99_999_999_999_999_999), Is.EqualTo(17));
    Assert.That(CalcDigits(100_000_000_000_000_000), Is.EqualTo(18));
    Assert.That(CalcDigits(999_999_999_999_999_999), Is.EqualTo(18));
    Assert.That(CalcDigits(1_000_000_000_000_000_000), Is.EqualTo(19));
    Assert.That(CalcDigits(9_999_999_999_999_999_999), Is.EqualTo(19));
    Assert.That(CalcDigits(10_000_000_000_000_000_000), Is.EqualTo(20));
    Assert.That(CalcDigits(UInt64.MaxValue), Is.EqualTo(20));
  }
}
