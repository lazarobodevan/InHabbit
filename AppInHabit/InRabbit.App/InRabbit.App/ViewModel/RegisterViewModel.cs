using InHabbit.App.Database;
using InHabbit.App.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InHabbit.App.ViewModel
{
    public class RegisterViewModel: BindableObject
    {
        public Bunny Bunny { get; set; }
        public DateTime birthDate { get;set; }
        public string bunnyName
        {
            get => _bunnyName; 
            set{
                if (value == _bunnyName)
                    return;
                _bunnyName = value;
                OnPropertyChanged();
            }
        }
        public string _bunnyName = "Carimbo";
        public string userName { get; set; }

        public ICommand Validate { get; }
        public ICommand RandBunnyName { get; }
        public RegisterViewModel()
        {
            userName = Application.Current.Properties["FirstName"].ToString();
            Validate = new Command(signUpValidation);
            RandBunnyName = new Command(getRandomBunnyName);
        }

        public async void signUpValidation()
        {
            if(birthDate.Date > new DateTime() || bunnyName.Length < 4){
                await Application.Current.MainPage.DisplayAlert("Cadastro Inválido", "Nome de usuário deve possuir pelo menos 6 caracteres. O nome do coelho deve possuir pelo menos 4. A data de nascimento deve ser válida.", "Ok");
            }
            else
            {
                new BunnyDAO().setBunnyName(bunnyName);
                Application.Current.MainPage = new Home();
            }

            OnPropertyChanged();
        }

        public void getRandomBunnyName()
        {
            string[] names = { "Arnaldo", "Charliston", "Cornélia", "Reginaldo", "Astolfo", "Margareth", "Igor", "Osvaldo" };
            Random rnd = new Random();

            this.bunnyName = names[rnd.Next(0, names.Length - 1)];
        }
    }
}
