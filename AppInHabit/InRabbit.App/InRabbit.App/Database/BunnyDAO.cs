using InHabbit.App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace InHabbit.App.Database
{
    public class BunnyDAO
    {
        private static Bunny bunny { get; set; }

        public BunnyDAO()
        {
            bunny = new Bunny();
        }

        public void setBunnyName(string name)
        {
            bunny.Name = name;
        }
    }
}
