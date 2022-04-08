using RestWithAspNet.Models;

namespace RestWithAspNet.Services.Implementation
{
    public class PersonService : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person>persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
               Person person = MockPerson(i); 
               persons.Add(person);
            }
            return persons;
        }

        private Person MockPerson(int i)
        {
             return new Person{
                Id = i,
                Nome = "Felipe - " + i,
                Email = "felipe@felipe.com - " + i
            };
        }

        public Person FindById(long id)
        {
            return new Person{
                Id = 1,
                Nome = "Felipe",
                Email = "felipe@felipe.com"
            };
        }

        public Person update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}