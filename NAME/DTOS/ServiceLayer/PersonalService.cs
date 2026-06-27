using Crud_Level_1.NAME.DTOS.OGDTO;

namespace Crud_Level_1.NAME.DTOS.ServiceLayer
{
    public interface IPersonalService
    {

        Task<IEnumerable<ResponcePersonDTOS>> GetAllAsync();


        Task<ResponcePersonDTOS?> GetByIdAsync(int id);

        Task<ResponcePersonDTOS> CreateAsync(RequestPersonDTOS request);

        Task<ResponcePersonDTOS?> UpdateAsync(int id, RequestPersonDTOS request);

        Task<bool> DeleteAsync(int id);

    }
}
