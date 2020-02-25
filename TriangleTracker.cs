using System;
using System.Collections.Generic;

class Triangle
{
  public int LegOne;
  public int LegTwo;
  public int LegThree;

  public Triangle(int L1, int L2, int L3)
  {
    LegOne = L1;
    LegTwo = L2;
    LegThree = L3;
  }

  public void TriangleChecker()
  {
    Console.WriteLine(LegOne);
    Console.WriteLine(LegTwo);
    Console.WriteLine(LegThree);
    if (LegOne == LegTwo && LegThree == LegOne)
    {
      Console.WriteLine("You made an equalateral.");
    } 
    else if ((LegOne + LegTwo <= LegThree) || (LegTwo + LegThree <= LegOne) || (LegOne + LegThree <= LegTwo))
    {
      Console.WriteLine("You divided by zero and your triangle imploded into a black hole which is now pulling in everything you know and love into a black oblivion.");
    }
    else if ((LegOne == LegTwo && LegTwo != LegThree) || (LegOne == LegThree && LegThree != LegTwo)|| (LegTwo == LegThree && LegThree != LegOne))
    {
      Console.WriteLine("Iscoceles is the triangle for you!");
    }
    else if (LegOne != LegTwo && LegOne != LegThree && LegTwo != LegThree)
    {
      Console.WriteLine("You strike me as a Scalene type of person.");
    }
  }
  public static void Main()
  {
    Console.WriteLine("Enter a length");
    string input1A = Console.ReadLine();
    int input1B = int.Parse(input1A);
    Console.WriteLine("Enter a length");
    string input2A = Console.ReadLine();
    int input2B = int.Parse(input2A);
    Console.WriteLine("Enter a length");
    string input3A = Console.ReadLine();
    int input3B = int.Parse(input3A);

    Triangle triangle = new Triangle(input1B, input2B, input3B);
    triangle.TriangleChecker();
  }

}