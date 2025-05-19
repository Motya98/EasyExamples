namespace EasyExamples;

public class Answer
{
    private int GetTotal(Person[] persons)
    {
        return persons.Sum(person => person.Value);
    }
}
