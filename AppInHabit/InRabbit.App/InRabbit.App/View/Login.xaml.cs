using InHabbit.App.Model;
using InHabbit.App.Services;
using InHabbit.App.View;
using InHabbit.App.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InHabbit.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        [Obsolete]
        public Login()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

    }
}
    
