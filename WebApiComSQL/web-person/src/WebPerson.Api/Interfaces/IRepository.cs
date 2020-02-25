using System.Collections.Generic;
using System.Threading.Tasks;
using WebPerson.Models;

namespace WebPerson.Interfaces
{
    public interface IRepository
    {
        Task<IEnumerable<Person>> GetAllAsync();
        Task<Person> GetPersonAsync(int id);
        Task<Person> CreatePersonAsync(Person person);
        Task<Person> UpdateAsync(int id);
        Task<bool> DeleteAsync(int id);
    }
}
