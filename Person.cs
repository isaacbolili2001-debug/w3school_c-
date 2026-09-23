public class Person
{
    private string _name;
    private string _firstName;
    private string _age;

   

    public Person(string name, string firstName, int age)
    {
        _name = name;
        _firstName = firstName;
        _age = age;
    }

    public string DisplayPerson()
    {
        return $"{_name} {_firstName} {_age}";
    }
}