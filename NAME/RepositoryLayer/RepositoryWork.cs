using CrudLevel1.DataConnection;
using CrudLevel1.NAME.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Level_1.NAME.RepositoryLayer
{
    

        public class RepositoryWork : IRepositoryCommute
        {

            private readonly DataConnect _Context;

            public RepositoryWork(DataConnect Context) 
            {

                _Context = Context;

            }

            public async Task<IEnumerable<Person>> GetAllAsync() 
            {

                return await _Context.Persons.ToListAsync();

            }

            public async Task<Person> GetByIdAsync(int Id) 
            {

                return await _Context.Persons.FindAsync(Id);

            }

            public async Task<Person> CreateAsync(Person person)
            {

                _Context.Persons.Add(person);
                await _Context.SaveChangesAsync();
                return person;
            
            
            }

            public async Task<Person> UpdateAsync(int Id ,Person person) 
            {
                var upd = await _Context.Persons.FindAsync(Id);

                if (upd == null) return null;

                upd.Name = person.Name;
                upd.Age = person.Age;
                upd.PhoneNumber = person.PhoneNumber;
                upd.CNIC = person.CNIC;
                upd.Email = person.Email;
                upd.Gender = person.Gender;
                upd.City = person.City;
                await _Context.SaveChangesAsync();
                return upd; 


            }

            public async Task<bool> DeleteAsync(int Id)
            {

                var Delo = await _Context.Persons.FindAsync(Id);

                if(Delo == null) return false;

                _Context.Persons.Remove(Delo);
                await _Context.SaveChangesAsync();
                return true;
            
            }

        }
    
}           
