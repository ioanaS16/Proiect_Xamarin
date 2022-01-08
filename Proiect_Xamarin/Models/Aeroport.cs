using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proiect_Xamarin.Models
{
    public class Aeroport
    {
        [PrimaryKey]
        public string ID { get; set; }
        public string Nume { get; set; }
        public string Oras { get; set; }
        public string Tara { get; set; }
    }
}
