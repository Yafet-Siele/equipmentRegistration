
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiApp35.Data
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Equipment { get; set; }
        public string Category { get; set; }
        public float Cost { get; set; }
        public string Description { get; set; }
    }
}

