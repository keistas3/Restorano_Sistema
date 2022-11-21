using Microsoft.VisualBasic;
using Restorano_Sistema;
using System.Xml.Linq;

//Perkelti i Tables klase
int staliukasMelynas = 1;
int staliukasZalias = 1;
int staliukasRaudonas = 1;
int staliukasGeltonas = 1;

StartApp();

void StartApp()
{
    while (true)
    {
        Init();
    }
}

    void Init()
    {
        Console.WriteLine("Užsakymo sistemas");
        Console.WriteLine("************************");
        Console.WriteLine("[1] Staliuko rezervacija, [2] Čekis, [3] Uždaryti");
        string userChoise = Console.ReadLine();

        switch (userChoise)
        {
            case "1":
                TableReservation();
                break;
            case "2":
                Report();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("|--Nenustatytas veiksmas--|");
                break;
        }
    }
    void TableReservation()
    {
        Console.WriteLine("************************");
        Console.WriteLine("[1] Rezervuoti staliuką, [2] Atšaukti rezervaciją, [3] Baigti");
        Console.WriteLine("************************");
        string userChoise = Console.ReadLine();

        switch (userChoise)
        {
            case "1":
                Confirm();
                break;
            case "2":
                Delete();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("|--Nenustatytas veiksmas, patikslinkite--|");
                break;
        }

    }
    void Report()
    {

    }
    void Confirm()
    {


    }
    void Cancel(int staliukasMelynas, int staliukasZalias, int staliukasRaudonas, int staliukasGeltonas)
    {
        Console.WriteLine($"Kurią rezervaciją panaikinti:");
        Console.WriteLine($"Melynas staliukas 4 vietos {staliukasMelynas}\n  Žalias staliukas 2 vietos{staliukasZalias}\n Raudonas staliukas 4 vietos{staliukasRaudonas}\n Geltonas staliukas 2 vietos{staliukasGeltonas}");
    }
    void Delete()
    {

    }
