// https://www.codewars.com/kata/reviews/59cf83889efac1e38b000210/groups/59cff6af9d83572fe2001b8e
using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    if (name.Length == 0)
      return "no one likes this";
   else if(name.Length == 1)
     return name[0] + " likes this";
   else if(name.Length == 2)
     return name[0] + " and " + name[1] + " like this";
   else if (name.Length == 3)
     return name[0] + ", " + name[1] + " and " + name[2] + " like this";
   else return name[0] +", " +name[1] + " and " + (name.Length - 2).ToString() + " others like this";
 }
}