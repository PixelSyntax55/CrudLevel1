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

            public async Task<Person> CreateAsync(Person Person)
            {

                _Context.Persons.Add(Person);
                await _Context.SaveChangesAsync();
                return Person;
            
            
            }

            public async Task<Person> UpdateAsync(int Id ,Person Person) 
            {
                var upd = await _Context.Persons.FindAsync(Id);

                if (upd == null) return null;

                upd.Name = Person.Name;
                upd.Age = Person.Age;
                upd.PhoneNumber = Person.PhoneNumber;
                upd.CNIC = Person.CNIC;
                upd.Email = Person.Email;
                upd.Gender = Person.Gender;
                upd.City = Person.City;
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
