using MinimalApi.Models;

namespace MinimalApi.Services;

public class PersonService
{
    private readonly List<Person> _people = [];
    private int _nextId = 1;

    public IEnumerable<Person> GetAll() => _people;

    public Person? GetById(int id) => _people.FirstOrDefault(p => p.Id == id);

    public void Add(Person person)
    {
        person.Id = _nextId++;
        _people.Add(person);
    }
}
