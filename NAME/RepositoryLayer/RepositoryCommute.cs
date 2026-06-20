using CrudLevel1.NAME.Models;

namespace Crud_Level_1.NAME.RepositoryLayer
{
    public interface IRepositoryCommute
    {

        public Task<IEnumerable<Person>> GetAllAsync();

        public Task<Person> GetByIdAsync(int Id);

        public Task<Person> CreateAsync(Person person);

        public Task<Person> UpdateAsync(int Id, Person Person);

        public Task<bool> DeleteAsync(int Id);
    }
}
