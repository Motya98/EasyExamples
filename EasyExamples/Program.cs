using System;
using System.Linq;

public class Person
{
    public int Value { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        var persons = new Person[]
        {
            new Person { Value = 100 },
            new Person { Value = 200 },
        };
        var program = new Program();
        Console.WriteLine($"WITH LINQ total = {program.GetTotalOld(persons)}");
        Console.WriteLine($"WITHOUT LINQ total = {program.GetTotal(persons)}");
    }
    
    public int GetTotal(Person[] persons)
    {
        return persons.Sum(person => person.Value);
    }
    
    public int GetTotalOld(Person[] persons)
    {    
        int value = 0;     
        foreach(Person person in persons)        
            value+= person.Value;     
        return value; 
    } 
}
