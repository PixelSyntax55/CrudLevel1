using AutoMapper;
using Crud_Level_1.NAME.DTOS.OGDTO;
using Crud_Level_1.NAME.RepositoryLayer;
using CrudLevel1.NAME.Models;

namespace Crud_Level_1.NAME.DTOS.ServiceLayer
{
    public class PersonalServiceLayred : IPersonalService
    {

        private readonly IRepositoryCommute _repository;
        private readonly IMapper _mapper;

        public PersonalServiceLayred(IRepositoryCommute repository, IMapper mapper)
        {

            _repository = repository;
            _mapper = mapper;

        }


        public async Task<IEnumerable<ResponcePersonDTOS>> GetAllAsync()

        {

            var person = await _repository.GetAllAsync();

            return _mapper.Map<IEnumerable<ResponcePersonDTOS>>(person);

        }

        public async Task<ResponcePersonDTOS?> GetByIdAsync(int id)
        {


            var person = await _repository.GetByIdAsync(id);

            if (person == null) return null;

            return _mapper.Map<ResponcePersonDTOS>(person);

        }

        public async Task<ResponcePersonDTOS> CreateAsync(RequestPersonDTOS request)
        {

            var person = _mapper.Map<Person>(request);

            var create = await _repository.CreateAsync(person);

            return _mapper.Map<ResponcePersonDTOS>(create);

        }


        public async Task<ResponcePersonDTOS?> UpdateAsync(int Id, RequestPersonDTOS request)
        {

            var person = _mapper.Map<Person>(request);

            var created = await _repository.UpdateAsync(Id, person);

            if (created == null) return null;

            return _mapper.Map<ResponcePersonDTOS>(created);

        }

        public async Task<bool> DeleteAsync(int Id)
        {

            return await _repository.DeleteAsync(Id);

        }
    }
}
