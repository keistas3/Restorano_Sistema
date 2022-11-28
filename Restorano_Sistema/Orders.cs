using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restorano_Sistema
{
    public class Orders
    {

        public int Id { get; set; }
        public string TableID { get; set; }
        DateTime DateTime { get; set; }

        public Orders(int id, string tableID, DateTime dateTime)
        {
            Id = id;
            TableID = tableID;
            DateTime = dateTime;
        }

    }
}



