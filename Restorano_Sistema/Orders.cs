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

        //Perkelti i Tables klase
        int staliukasMelynas = 1;
        int staliukasZalias = 1;
        int staliukasRaudonas = 1;
        int staliukasGeltonas = 1;


        public int Id { get; set; }
        public string Name { get; set; }
        DateAndTime DateAndTime { get; set; }

        public Orders(int id, string name, DateAndTime dateAndTime)
        {
            Id = id;
            Name = name;
            DateAndTime = dateAndTime;
        }


    }
}



