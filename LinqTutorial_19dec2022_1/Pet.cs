using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial_19dec2022_1;

public enum PetType
{
    Dog,
    Cat,
    Fish
}

public class PetComparerById : IEqualityComparer<Pet>
{
    bool IEqualityComparer<Pet>.Equals(Pet? x, Pet? y)
    {
        return x.Id == y.Id;
    }

    int IEqualityComparer<Pet>.GetHashCode(Pet obj)
    {
        return obj.Id;
    }
}
internal class Pet
{
    public Pet(int id, string name, PetType type, float number)
    {
        Id = id;
        Name = name;
        Type = type;
        Number = number;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public PetType Type { get; set; }
    public float Number { get; set; }
}
