using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Proiect_Xamarin.Models
{
    public class BoardingPass
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Bilet))]
        public int ID_zbor { get; set; }

        public string Loc { get; set; }
        public string Poarta { get; set; }
        public int Terminal { get; set; }
    }
}
