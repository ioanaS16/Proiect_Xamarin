using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proiect_Xamarin.Models
{
    public class Client
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        //public DateTime DataNasterii { get; set; }
        public string Email { get; set; }

        public string Parola { get; set; }

    }
}
