using System;
using System.Collections.Generic;
using System.Text;

namespace InHabbit.App.Model
{
    public class Chore {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public TimeSpan HourBegin { get; set; }
        public TimeSpan HourEnd { get; set; }
        public int Reward { get; set; }
        public string ImageSource { get; set; }


        public Chore(int Id, string Name, string Status, TimeSpan HourBegin, TimeSpan HourEnd, int Reward, string ImageSource){
            this.Id = Id;
            this.Name = Name;
            this.Status = Status;
            this.HourBegin = HourBegin;
            this.HourEnd = HourEnd;
            this.Reward = Reward;
            this.ImageSource = ImageSource;
        }

        public Chore(){
        }
    }
}
