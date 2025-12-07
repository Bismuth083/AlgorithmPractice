using System;
using static System.Math;

namespace Bismuth083.AlgorithmPractice
{
  /// <summary>
  /// 桁数を計算するための静的クラス
  /// </summary>
  public static class Digits
  {
    /// <summary>
    /// 桁数を計算する関数
    /// </summary>
    /// <param name="number">桁数を調べたい数値</param>
    /// <returns>桁数(1から20までの整数)</returns>
    /// <remarks>0の桁数は1として扱われる。</remarks>
    public static int CalcDigits(ulong number)
    {
      if(number >= Dig11)
      {
        if (number >= Dig16)
        {
          if(number >= Dig19)
          {
            if(number >= Dig20)
            {
              return 20;
            }
            else
            {
              return 19;
            }
          }
          else
          {
            if(number >= Dig18)
            {
              return 18;
            }
            else
            {
              if(number >= Dig17)
              {
                return 17;
              }
              else
              {
                return 16;
              }
            }
          }
        }
        else
        {
          if(number >= Dig14)
          {
            if(number >= Dig15)
            {
              return 15;
            }
            else
            {
              return 14;
            }
          }
          else
          {
            if(number >= Dig13)
            {
              return 13;
            }
            else
            {
              if(number >= Dig12)
              {
                return 12;
              }
              else
              {
                return 11;
              }
            }
          }
        }
      }
      else
      {
        if(number >= Dig06)
        {
          if (number >= Dig09)
          {
            if(number >= Dig10)
            {
              return 10;
            }
            else
            {
              return 9;
            }
          }
          else
          {
            if(number >= Dig08)
            {
              return 8;
            }
            else
            {
              if(number >= Dig07)
              {
                return 7;
              }
              else
              {
                return 6;
              }
            }
          }
        }
        else
        {
          if(number >= Dig04)
          {
            if(number >= Dig05)
            {
              return 5;
            }
            else
            {
              return 4;
            }
          }
          else
          {
            if(number >= Dig03)
            {
              return 3;
            }
            else
            {
              if(number >= Dig02)
              {
                return 2;
              }
              else
              {
                return 1;
              }
            }
          }
        }
      }
    }

    /// <summary>
    /// 桁数を計算する関数
    /// </summary>
    /// <param name="number">桁数を調べたい数値。</param>
    /// <returns></returns>
    /// <remarks>0の桁数は1として扱われる。負数が与えられたら絶対値の桁数を計算する。</remarks>
    public static int CalcDigits(long number) {
      return CalcDigits((ulong)Abs(number));
    }

    const ulong Dig02 = 10UL;
    const ulong Dig03 = 100UL;
    const ulong Dig04 = 1000UL;
    const ulong Dig05 = 10000UL;
    const ulong Dig06 = 100000UL;
    const ulong Dig07 = 1000000UL;
    const ulong Dig08 = 10000000UL;
    const ulong Dig09 = 100000000UL;
    const ulong Dig10 = 1000000000UL;
    const ulong Dig11 = 10000000000UL;
    const ulong Dig12 = 100000000000UL;
    const ulong Dig13 = 1000000000000UL;
    const ulong Dig14 = 10000000000000UL;
    const ulong Dig15 = 100000000000000UL;
    const ulong Dig16 = 1000000000000000UL;
    const ulong Dig17 = 10000000000000000UL;
    const ulong Dig18 = 100000000000000000UL;
    const ulong Dig19 = 1000000000000000000UL;
    const ulong Dig20 = 10000000000000000000UL;
  }
}

// https://github.com/Bismuth083/AlgorithmPractice