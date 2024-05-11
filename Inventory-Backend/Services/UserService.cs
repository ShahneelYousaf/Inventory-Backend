using AutoMapper;
using Inventory_Backend.Database.DataContext;
using Inventory_Backend.Database.Entities.User;
using Inventory_Backend.Models;
using Inventory_Backend.Models.User;
using Inventory_Backend.Services.IServices;

namespace Inventory_Backend.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public UserService(DataContext db, IMapper mapper) 
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<bool> Add(UserModel data)
        {
            Users user = _mapper.Map<Users>(data);

            user.CreatedDate = DateTime.UtcNow;
            user.UpdatedDate = DateTime.UtcNow;

            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Delete(Guid id)
        {
            Users user = _db.Users.Where(x => x.Id == id).FirstOrDefault();
           
            _db.Users.Remove(user);
            _db.SaveChanges();

            return true;
        }

        public async Task<DataAndCountDto<UserDto>> GetAll(SearchFilter filter)
        {
            var data = _db.Users.Where(x => x.IsDeleted == false).ToList();

            List<UserDto> users = _mapper.Map<List<UserDto>>(data);

            var result = new DataAndCountDto<UserDto>();
            result.Data = users;
            result.Count = users.Count;

            return result;
        }

        public async Task<DataAndCountDto<UserDto>> GetSingleUser(Guid Id)
        {
            var data = _db.Users.Where(x => x.IsDeleted == false && x.Id == Id).FirstOrDefault();

            List<UserDto> users = _mapper.Map<List<UserDto>>(data);

            var result = new DataAndCountDto<UserDto>();
            result.Data = users;
            result.Count = users.Count;

            return result;
        }

        public async Task<bool> Update(UserModel data)
        {
            Users user = _mapper.Map<Users>(data);

            user.UpdatedDate = DateTime.UtcNow;

            _db.Users.Update(user);
            _db.SaveChanges();

            return true;
        }
    }
}
