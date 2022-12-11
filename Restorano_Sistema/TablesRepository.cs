using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorano_Sistema
{
    public class TablesRepository
    {
        private List<Table> Tables { get; set; } = new List<Table>();
        
        public TablesRepository()
        {
            Tables.Add(new Table(01, 04, true)); ;

        }

    }
}



void MakeTableReservation(int staliukasMelynas, int staliukasZalias, int staliukasRaudonas, int staliukasGeltonas)
{
    Console.WriteLine($"Kurį staliuką koreguoti:");
    Console.WriteLine($" [1] Melynas staliukas iš 4 vietų, laisva {staliukasMelynas}\n [2] Žalias staliukas iš 2 vietų, laisva {staliukasZalias}\n [3] Raudonas staliukas iš 4 vietų, laisva {staliukasRaudonas}\n [4] Geltonas staliukas iš 2 vietų, laisva {staliukasGeltonas}\n [5] Atgal\n [6] Baigti");
    string userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "1":
            Blue();
            break;
        case "2":
            Green();
            break;
        case "3":
            Red();
            break;
        case "4":
            Yellow();
            break;
        case "5":
            Init();
            break;
        case "6":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("|--Nenustatytas veiksmas, patikslinkite--|");
            break;
    }
}
void Blue()
{
    Console.WriteLine("************************");
    Console.WriteLine("[1] Rezervuoti staliuką, [2] Atšaukti rezervaciją, [3] Atgal, [4] Baigti");
    Console.WriteLine("************************");
    string userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "1":
            Reserve();
            break;
        case "2":
            Delete();
            break;
        case "3":
            Init();
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("|--Nenustatytas veiksmas, patikslinkite--|");
            break;
    }

}
//Pakartoti jiems Reserve ir Delete
void Green()
{
    Console.WriteLine("************************");
    Console.WriteLine("[1] Rezervuoti staliuką, [2] Atšaukti rezervaciją, [3] Atgal, [4] Baigti");
    Console.WriteLine("************************");
    string userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "1":
            Reserve();
            break;
        case "2":
            Delete();
            break;
        case "3":
            Init();
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("|--Nenustatytas veiksmas, patikslinkite--|");
            break;
    }

}

void Red()
{
    Console.WriteLine("************************");
    Console.WriteLine("[1] Rezervuoti staliuką, [2] Atšaukti rezervaciją, [3] Atgal, [4] Baigti");
    Console.WriteLine("************************");
    string userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "1":
            Reserve();
            break;
        case "2":
            Delete();
            break;
        case "3":
            Init();
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("|--Nenustatytas veiksmas, patikslinkite--|");
            break;
    }

}
void Yellow()
{
    Console.WriteLine("************************");
    Console.WriteLine("[1] Rezervuoti staliuką, [2] Atšaukti rezervaciją, [3] Atgal, [4] Baigti");
    Console.WriteLine("************************");
    string userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "1":
            Reserve();
            break;
        case "2":
            Delete();
            break;
        case "3":
            Init();
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("|--Nenustatytas veiksmas, patikslinkite--|");
            break;
    }

}

void Reserve()
{
    Console.WriteLine("************************");
    Console.WriteLine("Pasirinkite rezervacijos skaičių");
    int seatReserv = ModifySeat();

    if (staliukasMelynas >= seatReserv)
    {
        staliukasMelynas += seatReserv;
        Console.WriteLine($"Laisva: {staliukasMelynas}");
    }
    else
    {
        Console.WriteLine("|--Bloga įvestis--|");
    }

}

void Delete()
{
    Console.WriteLine("************************");
    Console.WriteLine("Pasirinkite rezervacijos skaičių");
    int seatReserv = ModifySeat();

    if (staliukasMelynas >= seatReserv)
    {
        staliukasMelynas -= seatReserv;
        Console.WriteLine($"Laisva: {staliukasMelynas}");
    }
    else
    {
        Console.WriteLine("|--Bloga įvestis--|");
    }

}

int ModifySeat()
{
    Console.WriteLine(" [1] 1 vieta, [2] 2 vietos, [3] 3 vietos, [4] 4 vietos");
    return int.Parse(Console.ReadLine());
}