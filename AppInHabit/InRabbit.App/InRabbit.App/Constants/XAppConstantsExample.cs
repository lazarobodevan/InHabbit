using System;
using System.Collections.Generic;
using System.Text;

namespace InHabbit.App.Constants
{
    public class XAppConstantsExample{

        //RENAME THIS CLASS TO XAppContants (THIS WILL MAKE YOUR LIFE EASIER)
        //REMEBER TO CREATE YOUR GOOGLE CREDENTIALS AT GOOGLE CLOUD DEVELPER

            public static string AppName = "{THE NAMR YOU GAVE TO YOUR APP}";
            //Google Auth
            public const string CALLBACK_SCHEME = "[YOUR USER ID NUMBER].apps.googleusercontent.com";
            public const string DataScheme = "googleusercontent.com.apps.[YOUR USER ID NUMBER]";
            public const string Data = "com.googleusercontent.apps.[YOUR USER ID NUMBER]";
            //Links imutaveis
            public static string GoogleScope = "https://www.googleapis.com/auth/userinfo.email https://www.googleapis.com/auth/userinfo.profile";
            public static string GoogleAuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
            public static string GoogleAccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
            public static string GoogleUserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

            //Redirection URLs
            public const string GoogleAndroidRedirectURL = "com.googleusercontent.apps.[YOUR USER ID NUMBER]:/oauth2redirect";
        
    }
}
