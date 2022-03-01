using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.ComponentModel;
using Xamarin.Auth;
using InRabbit.App.Services;
using InRabbit.App.Model;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;
using InRabbit.App.Views;
using InRabbit.App.View;
using Android.Content.Res;

namespace InRabbit.App.ViewModel
{
    public class LoginViewModel : BindableObject{
        /*
        public List<Account> account;
        public SecureStorageAccountStore store;

        public ICommand GoogleLoginCommand { get; }

        [Obsolete]
        public LoginViewModel(){
            GoogleLoginCommand = new Command(OnGoogleLoginCLicked);
        }

        [Obsolete]
        public async void OnGoogleLoginCLicked(){
            await OnGoogleLoginClickedAsync();
        }

        [Obsolete]
        public async Task OnGoogleLoginClickedAsync()
        {
            string clientId = null;
            string redirectUri = null;
            //Xamarin.Auth.CustomTabsConfiguration.CustomTabsClosingMessage = null;            

            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    clientId = XAppConstants.XAppConstants.CALLBACK_SCHEME;
                    redirectUri = XAppConstants.XAppConstants.GoogleAndroidRedirectURL;
                    break;
            }

            account = await SecureStorageAccountStore.FindAccountsForServiceAsync("Google");

            var authenticator = new OAuth2Authenticator(
                clientId,
                null,
                XAppConstants.XAppConstants.GoogleScope,
                new Uri(XAppConstants.XAppConstants.GoogleAuthorizeUrl),
                new Uri(redirectUri),
                new Uri(XAppConstants.XAppConstants.GoogleAccessTokenUrl),
                null,
                true);

            authenticator.Completed += OnAuthCompleted;
            authenticator.Error += OnAuthError;

            
            AuthenticationState.Authenticator = authenticator;

            App.Current.MainPage =  new Xamarin.Auth. (authenticator);

            Xamarin.Auth.Presenters.OAuthLoginPresenter presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(AuthenticationState.Authenticator);
        }

        [Obsolete]
        async void OnAuthCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }


            if (e.IsAuthenticated)
            {
                if (authenticator.AuthorizeUrl.Host == "www.google.com")
                {
                    User user = null;

                    // If the user is authenticated, request their basic user data from Google
                    // UserInfoUrl = https://www.googleapis.com/oauth2/v2/userinfo
                    var request = new OAuth2Request("GET", new Uri(XAppConstants.XAppConstants.GoogleUserInfoUrl), null, e.Account);
                    var response = await request.GetResponseAsync();
                    if (response != null)
                    {
                        // Deserialize the data and store it in the account store
                        // The users email address will be used to identify data in SimpleDB
                        string userJson = await response.GetResponseTextAsync();
                        user = JsonConvert.DeserializeObject<User>(userJson);
                    }

                    if (account != null)
                    {
                        await store.SaveAsync(account.FirstOrDefault(), XAppConstants.XAppConstants.AppName);
                    }

                    await store.SaveAsync(e.Account, XAppConstants.XAppConstants.AppName);
                    account = new List<Account>();
                    account.Add(e.Account);

                    Application.Current.Properties.Remove("Id");
                    Application.Current.Properties.Remove("FirstName");
                    Application.Current.Properties.Remove("LastName");
                    Application.Current.Properties.Remove("DisplayName");
                    Application.Current.Properties.Remove("EmailAddress");
                    Application.Current.Properties.Remove("ProfilePicture");

                    Application.Current.Properties.Add("Id", user.Id);
                    Application.Current.Properties.Add("FirstName", user.GivenName);
                    Application.Current.Properties.Add("LastName", user.FamilyName);
                    Application.Current.Properties.Add("DisplayName", user.Name);
                    Application.Current.Properties.Add("EmailAddress", user.Email);
                    Application.Current.Properties.Add("ProfilePicture", user.Picture);

                    //await Navigation.PushAsync(new ProfilePage());
                    App.Current.MainPage = new NavigationPage(new Register());
                }
            }
        }

        [Obsolete]
        void OnAuthError(object sender, AuthenticatorErrorEventArgs e)
        {
            var authenticator = sender as OAuth2Authenticator;
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthCompleted;
                authenticator.Error -= OnAuthError;
            }

            Debug.WriteLine("Authentication error: " + e.Message);
        }
        */
    }
}

