using System;
using System.Collections.Generic;
using Wildlife.Models;

class Program
{
  private static Animal deer = new Animal ("White Tailed Deer", 3, "Brown", "Female", "Pregnant");
  private static Animal bear = new Animal ("Black Bear", 7, "Black", "Male", "Hibernating");
  private static Animal moose = new Animal ("Moose", 5, "Brown", "Male", "Agressive");
  private static Animal eagle = new Animal ("Golden Eagle", 3, "Brown", "Female", "Flying");

  private static List<Animal> Animals = new List<Animal>() {deer, bear, moose, eagle};

  public static void ShowAnimals()
  {
    Console.WriteLine("Here are the animals residing in the park: ");
    foreach(Animal resident in Animals)
    {
      Console.WriteLine("----------------------");
      Console.WriteLine(resident.GetSpecies());
      Console.WriteLine(resident.GetAge());
      Console.WriteLine(resident.GetColor());
      Console.WriteLine(resident.GetGender());
      Console.WriteLine(resident.GetCondition());
    }
  }

  public static void Main()
  {
    ShowAnimals();

    Console.WriteLine("Would you like to add another animal to the park? (Y/N)");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
      Console.WriteLine("Enter the species of your animal:");
      string species = Console.ReadLine();
      Console.WriteLine("Enter its age:");
      string stringAge = Console.ReadLine();
      int age = int.Parse(stringAge);
      Console.WriteLine("Enter its color:");
      string color = Console.ReadLine();
      Console.WriteLine("Enter its gender:");
      string gender = Console.ReadLine();
      Console.WriteLine("Enter its condition:");
      string condition = Console.ReadLine();

      Animal newAnimal = new Animal (species, age, color, gender, condition);

      Animals.Add(newAnimal);

      ShowAnimals();
      Main();
    }
  }
}
