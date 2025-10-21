namespace Bismuth083.AlgorithmPractice.Test;
using Bismuth083.AlgorithmPractice;

public class TestPrimeNumber
{
  [Test]
  public void CheckIsPrime()
  {
    Assert.That(2.IsPrime(), Is.True);
    Assert.That(3.IsPrime(), Is.True);
    Assert.That(4.IsPrime(), Is.False);
    Assert.That(13.IsPrime(), Is.True);
    Assert.That(25.IsPrime(), Is.False);
    Assert.That(37.IsPrime(), Is.True);
    Assert.That(99.IsPrime(), Is.False);
    Assert.That(100.IsPrime(), Is.False);
    Assert.That(7919.IsPrime(), Is.True);
    Assert.That(10007.IsPrime(), Is.True);
    Assert.That(100003.IsPrime(), Is.True);
    Assert.That(1000003.IsPrime(), Is.True);
    Assert.That(10000019.IsPrime(), Is.True);
    Assert.That(100000007.IsPrime(), Is.True);
    Assert.That(167772161.IsPrime(), Is.True);
    Assert.That(469762049.IsPrime(), Is.True);
    Assert.That(924844033.IsPrime(), Is.True);
    Assert.That(998244353.IsPrime(), Is.True);
    Assert.That(1000000007.IsPrime(), Is.True);
    Assert.That(1000000009.IsPrime(), Is.True);
  }

  [Test]
  public void CheckGetPrimesUpTo()
  {
    CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 }, PrimeNumber.GetPrimesUpTo(31).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47 }, PrimeNumber.GetPrimesUpTo(50).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199 }, PrimeNumber.GetPrimesUpTo(200).ToList());
    CollectionAssert.AreEqual(new List<int> { 2 }, PrimeNumber.GetPrimesUpTo(2).ToList());
    CollectionAssert.AreEqual(new List<int> { }, PrimeNumber.GetPrimesUpTo(1).ToList());
    CollectionAssert.AreEqual(new List<int> { }, PrimeNumber.GetPrimesUpTo(0).ToList());
    CollectionAssert.AreEqual(new List<int> { }, PrimeNumber.GetPrimesUpTo(-10).ToList());
  }

  [Test]
  public void CheckPrimeFactorization()
  {
    CollectionAssert.AreEqual(new List<int> { }, PrimeNumber.PrimeFactorization(1).ToList());
    CollectionAssert.AreEqual(new List<int> { 2 }, PrimeNumber.PrimeFactorization(2).ToList());
    CollectionAssert.AreEqual(new List<int> { 3 }, PrimeNumber.PrimeFactorization(3).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 3 }, PrimeNumber.PrimeFactorization(6).ToList());
    CollectionAssert.AreEqual(new List<int> { 3, 3 }, PrimeNumber.PrimeFactorization(9).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 2, 2, 3, 3, 5 }, PrimeNumber.PrimeFactorization(360).ToList());
    CollectionAssert.AreEqual(new List<int> { 37 }, PrimeNumber.PrimeFactorization(37).ToList());
    CollectionAssert.AreEqual(new List<int> { 3, 19 }, PrimeNumber.PrimeFactorization(57).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 2, 5, 5 }, PrimeNumber.PrimeFactorization(100).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 2, 3, 3, 277 }, PrimeNumber.PrimeFactorization(9972).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 3, 3, 5, 3607, 3803 }, PrimeNumber.PrimeFactorization(1234567890).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 1000000007 }, PrimeNumber.PrimeFactorization(2000000014).ToList());
    CollectionAssert.AreEqual(new List<int> { 2, 2, 2, 3, 3, 5 }, PrimeNumber.PrimeFactorization(-360).ToList());
  }
}
