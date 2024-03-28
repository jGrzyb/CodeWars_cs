// https://www.codewars.com/kata/reviews/59ae0e50cfb4470003000171/groups/6605d067e0165300018045eb

using System;
using System.Collections.Generic;

public static class Kata
{
  public static bool IsPangram(string str)
  {
    List<char> allLetters = new();
    foreach(char s in "qwertyuiopasdfghjklzxcvbnm") {
      allLetters.Add(s);
    }
    foreach(char s in str) {
      if(allLetters.Contains(Char.ToLower(s))) {
        allLetters.Remove(Char.ToLower(s));
      }
    }
    return allLetters.Count == 0;
  }
}