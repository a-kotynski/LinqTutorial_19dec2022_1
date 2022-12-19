namespace LinqTutorial_19dec2022_1;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new[] { 16, 8, 9, -1, 2 };
        bool is7Present = numbers.Contains(7);
        Console.WriteLine($"{nameof(is7Present)}: {is7Present}");

        var words = new[] { "lion", "tiger", "snow leopard" };
        bool isTigerPresent = words.Contains("tiger");
        Console.WriteLine($"{nameof(isTigerPresent)}: {isTigerPresent}");

        var pets = new[]
        {
            new Pet(1, "Hannibal", PetType.Fish, 1.1f),
            new Pet(2, "Anthony", PetType.Cat, 2f),
            new Pet(3, "Ed", PetType.Cat, 0.7f),
            new Pet(4, "Taiga", PetType.Dog, 35f),
            new Pet(5, "Rex", PetType.Dog, 40f),
            new Pet(6, "Lucky", PetType.Dog, 5f),
            new Pet(7, "Storm", PetType.Cat, 0.9f),
            new Pet(8, "Nyan", PetType.Cat, 2.2f)
        };
        var hannibal = pets[0];

        bool isHannibalPresentVersionOne = pets.Contains(new Pet(1, "Hannibal", PetType.Fish, 1.1f));

        bool isHannibalPresentCustomComparer = pets.Contains(new Pet(1, "Hannibal", PetType.Fish, 1.1f), new PetComparerById()); /*both objects are compared by their Id*/

        bool isHannibalPresentVersionTwo = pets.Contains(hannibal); /*objects are compared by their memory address*/

        Console.WriteLine($"{nameof(isHannibalPresentVersionOne)}: {isHannibalPresentVersionOne}");
        Console.WriteLine($"{nameof(isHannibalPresentVersionTwo)}: {isHannibalPresentVersionTwo}");
        Console.WriteLine($"{nameof(isHannibalPresentCustomComparer)}: {isHannibalPresentCustomComparer}");

    }
}