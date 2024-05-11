using Inventory_Backend.Models;
using Inventory_Backend.Models.User;

namespace Inventory_Backend.Services.IServices
{
    public interface IUserService
    {
        Task<bool> Add(UserModel data);
        Task<DataAndCountDto<UserDto>> GetAll(SearchFilter filter);
        Task<DataAndCountDto<UserDto>> GetSingleUser(Guid id);
        Task<bool> Update(UserModel data);
        Task<bool> Delete(Guid id);
    }
}
