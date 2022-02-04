using BookStoreAppBlazorServer.UI.Services.Base;

namespace BookStoreAppBlazorServer.UI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
