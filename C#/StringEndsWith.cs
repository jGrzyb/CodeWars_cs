// https://www.codewars.com/kata/reviews/5990b47735fd2f187600011c/groups/59969d0bb1a1cd0154000d13
public class Kata
{
  public static bool Solution(string str, string ending)
  {
    return ((str.Length >= ending.Length) && (str.Substring(str.Length-ending.Length,ending.Length) == ending));
  }
}