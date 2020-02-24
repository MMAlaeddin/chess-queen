using System;
using System.Collections.Generic;

class Chess
{
  static void Main()
  {
    Console.WriteLine("Enter Queen X");
    string queenCorXStr = Console.ReadLine(); 
    int queenCorX = int.Parse(queenCorXStr); 
    Console.WriteLine("Enter Queen Y");
    string queenCorYStr = Console.ReadLine(); 
    int queenCorY = int.Parse(queenCorYStr); 
    Console.WriteLine("Enter Piece X");
    string pieceCorXStr = Console.ReadLine(); 
    int pieceCorX = int.Parse(pieceCorXStr) ;
    Console.WriteLine("Enter Piece Y");
    string pieceCorYStr = Console.ReadLine(); 
    int pieceCorY = int.Parse(pieceCorYStr); 
    Queen queen = new Queen(queenCorX,queenCorY);
    bool attacked = queen.CanAttack(pieceCorX,pieceCorY);
    if(attacked)
    {
      Console.WriteLine("This queen will get ur ass");
    }
    else 
    {
      Console.WriteLine("Youre a king and got away");
     }
  }
}
public class Queen
{
  int queenX;
  int queenY;
  public Queen(int inX, int inY)
  {
    queenX = inX;
    queenY = inY;
  }
  public bool CanAttack(int x,int y)
  {
    if(queenX == x || queenY == y || Math.Abs(queenX - x) == Math.Abs(queenY - y))
    {
      return true;
    } 
  else
  {
    return false;
  }
  }
}
