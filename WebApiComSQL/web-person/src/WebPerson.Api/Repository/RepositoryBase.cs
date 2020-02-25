using System;
using System.Linq;
using System.Collections.Generic;
using WebPerson.Interfaces;
using System.Threading.Tasks;
using WebPerson.Models;
using WebPerson.Data;
using Microsoft.EntityFrameworkCore;

namespace WebPerson.Repository
{
    public class RepositoryBase : IRepository
    {
        protected readonly MyDbContext _context;
        public RepositoryBase(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Person> CreatePersonAsync(Person person)
        {

           await  _context.AddAsync(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _context.Person.SingleOrDefaultAsync(p => p.BusinessEntityID.Equals(id));
                if (result == null)
                    return false;

                _context.Remove(result);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context.Person.OrderBy(p => p.LastName).ToListAsync();
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            var person = _context.Person.FindAsync(id);

            return await person;
           
        }

        public async Task<Person> UpdateAsync(int id)
        {
            try
            {
                var person= await _context.Person.SingleOrDefaultAsync(p => p.BusinessEntityID.Equals(p.BusinessEntityID));
                if (person == null)
                    return null;

                _context.Entry(person).CurrentValues.SetValues(id);
                await _context.SaveChangesAsync();
                return person;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
