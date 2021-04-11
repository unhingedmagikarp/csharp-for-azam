using System;
using System.Collections.Generic;

namespace PracticeTask
{
  class Program
  {
    public static void Main(string[] argv)
    {
      // You have a `DiceSet` class which has a list for 6 dice
      // You can roll all of them with roll()
      // Check the current rolled numbers with getCurrent()
      // You can reroll with reroll()
      // Your task is to roll the dice until all of the dice are 6
      DiceSet diceSet = new DiceSet();

      Console.WriteLine(diceSet.GetCurrent());
      diceSet.Roll();
      Console.WriteLine(diceSet.GetCurrent());
      Console.WriteLine(diceSet.GetCurrent(5));
      diceSet.Reroll();
      Console.WriteLine(diceSet.GetCurrent());
      diceSet.Reroll(4);
      Console.WriteLine(diceSet.GetCurrent());
    }
  }
}
