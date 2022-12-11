using Microsoft.VisualBasic;
using Restorano_Sistema;
using System.Net.Sockets;
using System.Xml.Linq;


void StartApp()
{
    //repozitorijos
    DrinksRepository drinkRepository = new DrinksRepository();
    OrdersRepository ordersRepository = new OrdersRepository();
    ProductRepository productRepository = new ProductRepository();
    TablesRepository tablesRepository = new TablesRepository(); 

    
    //inicijuotas paduoti i init metoda 
    while (true)
    {
        Init();
    }
}

void Init()
{
    Console.WriteLine("Užsakymo sistema");
    Console.WriteLine("************************");
    Console.WriteLine("[1] Staliuko rezervacija, [2] Čekis, [3] Uždaryti");
    string userChoise = Console.ReadLine();

    switch (userChoise)
    {
        case "1":
            MakeTableReservation();
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
