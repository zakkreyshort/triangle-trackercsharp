using System;
using System.Collections.Generic;

public class Triangle
{
  public int SideOne;
  public int SideTwo;
  public int SideThree;

  public Triangle(int Side1, int Side2, int Side3)
  {
      SideOne = Side1;
      SideTwo = Side2;
      SideThree = Side3;
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

public bool IsATriangle()
{
    if(SideOne + SideTwo > SideThree && SideTwo + SideThree > SideOne && SideThree + SideOne > SideTwo)
    {
        return true;
    }
    else
    {
        return false;
    }
}
}


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Input a number");
    string stringSideOne = Console.ReadLine();
    int intSideOne = int.Parse(stringSideOne);

    Console.WriteLine("Input another number");
    string stringSideTwo = Console.ReadLine();
    int intSideTwo = int.Parse(stringSideTwo);

    Console.WriteLine("Input a third number");
    string stringSideThree = Console.ReadLine();
    int intSideThree = int.Parse(stringSideThree);

    Triangle userTriangle = new Triangle(intSideOne, intSideTwo, intSideThree);

    if (userTriangle.IsATriangle())
    {
    Console.WriteLine(userTriangle.CheckSide());
    }
    else
    {
    Console.WriteLine("Is not a triangle");
    }

  }
}