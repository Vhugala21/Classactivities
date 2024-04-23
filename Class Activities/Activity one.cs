using System;
public interface IPlayable
{
    void Play();
}
public class Guitar : IPlayable
{
    // Explicit implementation of IPlayable interface
    void IPlayable.Play()
    {
        Console.WriteLine("Playing the guitar...");
    }
}
public class Piano : IPlayable
{
    // Explicit implementation of IPlayable interface
    void IPlayable.Play()
    {
        Console.WriteLine("Playing the piano...");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating Guitar and Piano objects
        Guitar guitar = new Guitar();
        Piano piano = new Piano();
        // Calling Play method on Guitar and Piano objects
        ((IPlayable)guitar).Play(); // Explicitly cast to IPlayable interface
        ((IPlayable)piano).Play(); // Explicitly cast to IPlayable interface
    }
}