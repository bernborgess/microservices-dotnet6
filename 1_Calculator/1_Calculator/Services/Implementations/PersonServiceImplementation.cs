using _1_Calculator.Model;

namespace _1_Calculator.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            // TODO
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            foreach (int x in Enumerable.Range(0, 8))
            {
                Person person = MockPerson(x);
                persons.Add(person);
            }
            return persons;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int x)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person FirstName" + x,
                LastName = "Person LastName" + x,
                Address = "Some Address" + x,
                Gender = "Male" + x
            };

        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
