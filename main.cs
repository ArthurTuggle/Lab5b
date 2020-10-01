using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 1;
    Console.WriteLine("How many cars");
    int maxcounter = Convert.ToInt32(Console.ReadLine());
    
    
    
    while(counter <= maxcounter)
  {
    Console.WriteLine ("Enter the distance covered by the car");
    double distance = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Enter the time taken by Car#1");
    double time = Convert.ToDouble(Console.ReadLine());
    counter++;
  
    Console.WriteLine (distance * time);
  
   

  }

  
  }
}