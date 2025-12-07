using System;
using System.Collections.Generic;
using System.Linq;
using static System.Math;

namespace Bismuth083.AlgorithmPractice
{
  /// <summary>
  /// 素数に関する計算を行うための静的クラス
  /// </summary>
  public static class PrimeNumber
  {
    /// <summary>
    /// 与えられた数値が素数かどうか判定する関数
    /// </summary>
    /// <param name="num">素数かどうかを判定したい数値</param>
    /// <returns>素数ならtrue。そうでないならfalse。1、0はfalseを返す</returns>
    public static bool IsPrime(this ulong num)
    {
      // 1以下の数は考慮しない
      if (num < 2) return false;

      // 2は素数
      if (num == 2) return true;

      // 2以外の偶数は素数ではない
      if (num % 2 == 0) return false;


      // 3以上の奇数について、全ての奇数で割り切れないか確認する
      for (ulong i = 3; i <= Ceiling(Sqrt(num)); i += 2)
      {
        if (num % i == 0)
        {
          return false;
        }
      }
      return true;
    }

    /// <summary>
    /// 与えられた数値が素数かどうか判定する関数
    /// </summary>
    /// <param name="num">素数かどうかを判定したい数値</param>
    /// <returns>素数ならtrue。そうでないならfalse。1、0はfalseを返す</returns>
    /// <remarks>負数の場合、絶対値が素数かどうかを判定する。</remarks>
    public static bool IsPrime(this long num)
    {
      if (num < 0) return false;
      return IsPrime((ulong)num);
    }

    /// <summary>
    /// 与えられた数値が素数かどうか判定する関数
    /// </summary>
    /// <param name="num">素数かどうかを判定したい数値</param>
    /// <returns>素数ならtrue。そうでないならfalse。1、0はfalseを返す</returns>
    /// <remarks>負数の場合、絶対値が素数かどうかを判定する。</remarks>
    public static bool IsPrime(this int num)
    {
      return IsPrime((long)num);
    }

    /// <summary>
    /// 2から指定された数値までの素数を列挙する関数。[2, limit]の範囲内の素数を返す
    /// </summary>
    /// <param name="limit">列挙したい素数の上限値</param>
    /// <returns>[2, limit]の範囲内における、素数のリスト</returns>
    public static List<int> GetPrimesUpTo(int limit)
    {
      // 2未満の場合は空リストを返す
      if (limit < 2) return new List<int>();

      // 0からlimitまでFalseで初期化
      // 3以上の奇数のみTrueに書き換える
      var primes = new bool[limit + 1];
      primes[2] = true;
      for (int i = 3; i <= limit; i += 2)
      {
        primes[i] = true;
      }

      // エラトステネスの篩(3以降の奇数のみ調べている)
      int cntPrime = 1;
      for (int i = 3; i <= Ceiling(Sqrt(limit)); i += 2)
      {
        if (primes[i])
        {
          cntPrime++;
          for (int j = 2 * i; j <= limit; j += i) {
            primes[j] = false;
          }
        }
      }

      // 素数リストの作成
      List<int> result = new List<int>(cntPrime) {2};
      for (int i = 3; i <= limit; i += 2)
      {
        if (primes[i])
        {
          result.Add(i);
        }
      }
      return result;
    }

    /// <summary>
    /// 指定された数を素因数分解する関数
    /// </summary>
    /// <param name="num">素因数分解したい数値</param>
    /// <returns>素因数を列挙したリスト</returns>
    /// <exception cref="System.ArgumentException">引数に0を与えると例外</exception>
    public static List<ulong> PrimeFactorization(ulong num)
    {
      if (num == 0) throw new System.ArgumentException("Zero is not supported", nameof(num));
      var factors = new List<ulong>();

      while (true)
      {
        if (num % 2 == 0)
        {
          factors.Add(2);
          num /= 2;
          continue;
        }
        break;
      }

      for (ulong i = 3; i <= Ceiling(Sqrt(num)); i += 2)
      {
        while (true)
        {
          if (num % i == 0)
          {
            factors.Add(i);
            num /= i;
            continue;
          }
          break;
        }
      }
      
      if (num != 1) factors.Add(num);

      return factors;
    }

    /// <summary>
    /// 指定された数を素因数分解する関数
    /// </summary>
    /// <param name="num">素因数分解したい数値</param>
    /// <returns>素因数を列挙したリスト</returns>
    /// <exception cref="System.ArgumentException">引数に0を与えると例外</exception>
    /// <remarks>引数が負数の場合、絶対値を素因数分解する</remarks>
    public static List<ulong> PrimeFactorization(long num)
    {
      num =  num < 0 ? Abs(num) : num;
      return PrimeFactorization((ulong)num);
    }
  }
}

// https://github.com/Bismuth083/AlgorithmPractice