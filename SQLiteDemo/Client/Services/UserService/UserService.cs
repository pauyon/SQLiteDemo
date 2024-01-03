using SQLiteDemo.Shared.Models;
using System.Net.Http.Json;

namespace SQLiteDemo.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetAll()
        {
            var users = await _httpClient.GetFromJsonAsync<List<User>>("api/user");
            return users ?? new List<User>();
        }
    }
}
