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
    Console.Write(LegOne);
    Console.Write(LegTwo);
    Console.Write(LegThree);

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
    
  }

}