using System;

namespace Wildlife.Models
{

  class Animal
  {
    private string _Species;
    private int _Age;
    private string _Color;
    private string _Gender;
    private string _Condition;

    public Animal (string species, int age, string color, string gender, string condition)
    {
      _Species = species;
      _Age = age;
      _Color = color;
      _Gender = gender;
      _Condition = condition;
    }

    public string GetSpecies()
    {
      return _Species;
    }

    public int GetAge()
    {
      return _Age;
    }

    public string GetColor()
    {
      return _Color;
    }

    public string GetGender()
    {
      return _Gender;
    }

    public string GetCondition()
    {
      return _Condition;
    }

    public void SetCondition(string newCondition)
    {
      _Condition = newCondition;
    }
  }


}
