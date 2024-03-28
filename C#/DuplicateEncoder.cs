// https://www.codewars.com/kata/reviews/57ab76bdd9af9cfeed000111/groups/6605d4a5e01653000180467e

using System.Collections.Generic;

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string s = "";
    List<char> l = new();
    foreach(char c in word.ToLower()) {
      l.Add(c);
    }
      foreach(char c in l) {
        s += l.FindAll(x => x == c).Count == 1 ? "(" : ")";
      }
    return s;
  }
}