using InHabbit.App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace InHabbit.App.ViewModel
{
    public class ChoreViewModel : INotifyPropertyChanged{

        public ObservableCollection<Chore> Chores { get; set; }

        public ChoreViewModel(){
            Chores = new ObservableCollection<Chore>();
            AddChores();
        }

        void AddChores()
        {
            Chores.Add(item: new Chore
            {
                Id = 0,
                Name = "Limpar a casa",
                Status = "Em execução",
                HourBegin = new TimeSpan(10, 30, 0),
                HourEnd = new TimeSpan(11, 30, 0),
                Reward = 5,
                ImageSource = "strongBunny"
            });
            Chores.Add(item: new Chore
            {
                Id = 1,
                Name = "Limpar a casa1",
                Status = "Em execução",
                HourBegin = new TimeSpan(10, 30, 0),
                HourEnd = new TimeSpan(11, 30, 0),
                Reward = 6,
                ImageSource = "sleepingBunny"
            });
            Chores.Add(item: new Chore
            {
                Id = 2,
                Name = "Limpar a casa2",
                Status = "Em execução",
                HourBegin = new TimeSpan(10, 30, 0),
                HourEnd = new TimeSpan(11, 30, 0),
                Reward = 7,
                ImageSource = "sleepingBunny"
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
