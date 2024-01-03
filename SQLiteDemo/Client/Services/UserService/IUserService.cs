using SQLiteDemo.Shared.Models;

namespace SQLiteDemo.Client.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
    }
}
