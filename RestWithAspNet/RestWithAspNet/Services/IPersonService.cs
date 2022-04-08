using RestWithAspNet.Models;

namespace RestWithAspNet.Services
{
    public interface IPersonService
    {
         Person Create(Person person);
         Person update(Person person);
         void Delete(long id);
         Person FindById(long id);
         List<Person> FindAll();

    }
}