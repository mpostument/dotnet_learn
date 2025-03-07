// Incorrect
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("The bird is flying.");
    }

    public virtual void Eat()
    {
        Console.WriteLine("The bird is eating.");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Penguins cannot fly!");
    }
}

// Correct
public interface IFlyable
{
    void Fly();
}

public class BirdFixed
{
    public void Eat()
    {
        Console.WriteLine("The bird is eating.");
    }
}

public class Sparrow : BirdFixed, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("The sparrow is flying.");
    }
}

public class PenguinFixed : BirdFixed
{
    public void Swim()
    {
        Console.WriteLine("The penguin is swimming.");
    }
}
