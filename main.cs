using System;
class Program {
  public static void Main (string[] args) {
    Console.WriteLine("What is the original unit? ");
    String unit = Console.ReadLine();
    Console.WriteLine("What is the unit you want to convert to? ");
    String units = Console.ReadLine();
    Console.WriteLine("How much of the original unit do you have? ");
    int uni = Console.ReadLine();
    if(unit == "km" && units == "m"){
      uni *= 1000;
      Console.WriteLine(uni);
    }
    else if(unit == "m" && units == "mm"){
      uni *= 1000;
      Console.WriteLine(uni);
    }
    else if(unit == "cm" && units == "mm"){
      uni *= 10;
      Console.WriteLine(uni);
    }
    else{
      Console.WriteLine("Please enter a valid unit.");
    }
  }
}