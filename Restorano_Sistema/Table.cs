using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorano_Sistema
{
    public class Table
    {
        public int Id { get; set; }
        public int NumberOfSets { get; set; }
        public bool IsOcupied { get; set; }
        TimeOnly Time { get; set; }

        public Table(int id, int numberOfSets, TimeOnly time)
        {
            Id = id;
            NumberOfSets = numberOfSets;
            Time = time;
        }
    }
}

