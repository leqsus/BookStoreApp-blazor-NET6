using Blazored.LocalStorage;
using BookStoreAppBlazorServer.UI.Providers;
using BookStoreAppBlazorServer.UI.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;

namespace BookStoreAppBlazorServer.UI.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient httpClient;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.httpClient = httpClient;
            LocalStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public ILocalStorageService LocalStorage { get; }

        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            var response = await httpClient.LoginAsync(loginModel);

            //store Token
            await LocalStorage.SetItemAsync("accessToken", response.Token);

            //Change auth state of app
           await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();

            return true;
        }

        public async Task Logout()
        {
            await((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();
        }
    }
}
