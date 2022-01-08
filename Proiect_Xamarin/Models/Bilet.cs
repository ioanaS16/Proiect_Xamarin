using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Proiect_Xamarin.Models
{
    public class Bilet
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Aeroport))]
        public string ID_aeroport_decolare { get; set; }

        [ForeignKey(typeof(Aeroport))]
        public string ID_aeroport_aterizare { get; set; }

        public DateTime Data { get; set; }
        public double Durata { get; set; }
        public double Pret { get; set; }
    }
}
