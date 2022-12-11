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
        public int Seats { get; set; }
        public bool IsOcupied { get; set; }
        
        public Table(int id, int seats,bool isOcupied)
        {
            Id = id;
            Seats = seats;
            IsOcupied = isOcupied;
           
        }
    }
}