using System;
using System.Collections.Generic;
using Wildlife.Models;

class Program
{
  private static Animal deer = new Animal ("White Tailed Deer", 3, "Brown", "Female", "Pregnant");
  private static Animal bear = new Animal ("Black Bear", 7, "Black", "Male", "Hibernating");
  private static Animal moose = new Animal ("Moose", 5, "Brown", "Male", "Agressive");
  private static Animal eagle = new Animal ("Golden Eagle", 3, "Brown", "Female", "Flying");

  public static List<Animal> Animals = new List<Animal>() {deer, bear, moose, eagle};

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

      Main();
    }
    if (answer == "N" || answer == "n")
    {
      Console.WriteLine("Would you like to change the condition of an animal? (Y/N)");
      answer = Console.ReadLine();
      if (answer == "Y" || answer == "y")
      {
        Console.WriteLine("Enter number for the animal you want to change the condition of:");
        for (int i = 0; i < Animals.Count; i++)
        {
          Console.WriteLine(i + ": " + Animals[i].GetSpecies());
        }
        string id = Console.ReadLine();
        int intId = int.Parse(id);
        Console.WriteLine("Enter its new condition:");
        string condition = Console.ReadLine();
        Animals[intId].SetCondition(condition);

        Main();
      }
    }
  }
}
