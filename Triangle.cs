using System;
using System.Collections.Generic;

public class Triangle
{
  public int Side1;
  public int Side2;
  public int Side3;

  public Triangle(int Side1, int Side2, int Side3)
  {
      SideOne = Side1;
      SideTwo = Side2;
      SideThree = Side3;
  }
}
public string CheckSide()
{
    if(SideOne == SideTwo && SideOne == SideThree)
    {
        return "equilateral";
    }
    else if (SideOne == SideTwo || SideTwo == SideThree || SideThree == SideOne)
    {
        return "isosceles";
    }
    else
    {
        return "scalene";
    }
}

public bool

// secondary 
public class Program
{
  public static void Main()
  {
      
  }
}