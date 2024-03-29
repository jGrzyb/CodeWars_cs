// https://www.codewars.com/kata/reviews/59ad1ea477a679358e000dbd/groups/6606dfde8cfbca00017fa7bd

using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
    int c = a + b;
    string result = "";
    while(c != 0) {
      result = c%2 + result;
      c /= 2;
    }
    return result;
  }
}