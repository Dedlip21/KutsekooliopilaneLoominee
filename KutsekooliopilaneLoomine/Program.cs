using KutsekooliopilaneLoomine;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using static KutsekooliopilaneLoomine.WriteList;

Console.WriteLine("Sisentage isik. 1 - Tootajad, 2 - Opilased, 3 - Kutsekooliõpilane");
int isikud = Convert.ToInt32(Console.ReadLine());

Tootaja tootaja = new Tootaja(Isik.sugu.mehe, "Oleg Petrov", 1980, "Sõpruse pst. 180", "Programeerija õpetaja", 800);
Opilane opilane = new Opilane(Isik.sugu.mehe, "Rolan Maslennikov", 2004, "Rolan", "9 Klass", "Noorem tarkvaraarendaja");
Kutsekooliõpilane kutsekooliõpilane = new Kutsekooliõpilane(Isik.sugu.mehe, "Rolan Maslennikov", 2004, "TTHK", "Noorem tarkvaraarendaja", "2 Kurss", 60);

/*Koer veelkoer = new Koer(koer);
veelkoer.muudaNimi("Murka");
veelkoer.print_Info();*/

if (isikud == 1)
{
    tootaja.print_Info();

    Console.WriteLine("Kas ta tahad muuda nimi? Yah - 1, Ei - 0");
    int muudaValik = Convert.ToInt32(Console.ReadLine());

    if (muudaValik == 1)
    {
        Console.WriteLine("Sisenda nimi: ");
        //int muudaNimi = Convert.ToInt32(Console.ReadLine());

        string muudaNimi = Convert.ToString(Console.ReadLine());

        Tootaja uusTootaja = new Tootaja(tootaja);
        uusTootaja.muudaNimi(muudaNimi);
        uusTootaja.print_Info();
    }
    else if (muudaValik == 0)
    {

    }

    Console.WriteLine("Kas te tahate vaata vanus või netopalk? vanus - 1 või netopalk - 2");
    int Valik = Convert.ToInt32(Console.ReadLine());

    if (Valik == 1)
    {
        tootaja.Vanus();
    }
    else if (Valik == 2)
    {
        Console.WriteLine(tootaja.arvutaSissetulek(500, 50));
    }
}
else if(isikud == 2)
{
    opilane.print_Info();

    Console.WriteLine("Kas ta tahad muuda nimi? Yah - 1, Ei - 0");
    int muudaValik = Convert.ToInt32(Console.ReadLine());

    if (muudaValik == 1)
    {
        Console.WriteLine("Sisenda nimi: ");
        //int muudaNimi = Convert.ToInt32(Console.ReadLine());

        string muudaNimi = Convert.ToString(Console.ReadLine());

        Opilane uusOpilane = new Opilane(opilane);
        uusOpilane.muudaNimi(muudaNimi);
        uusOpilane.print_Info();
    }
    else if (muudaValik == 0)
    {

    }

    Console.WriteLine("Kas te tahate vaata vanus või muuda koolinimi? vanus - 1 või muuda koolinimi - 2");
    int Valik = Convert.ToInt32(Console.ReadLine());

    if (Valik == 1)
    {
        opilane.Vanus();
    }
    else if (Valik == 2)
    {
        Console.WriteLine("Sisenda koolinimi: ");
        //int muudaNimi = Convert.ToInt32(Console.ReadLine());

        string muudaKooliNimii = Convert.ToString(Console.ReadLine());

        Opilane uusKooliNimi = new Opilane(opilane);
        uusKooliNimi.muudaKooliNimi(muudaKooliNimii);
        uusKooliNimi.print_Info();
    }
}
else if(isikud == 3)
{
    kutsekooliõpilane.print_Info();

    Console.WriteLine("Kas ta tahad muuda nimi? Yah - 1, Ei - 0");
    int muudaValik = Convert.ToInt32(Console.ReadLine());

    if (muudaValik == 1)
    {
        Console.WriteLine("Sisenda nimi: ");
        //int muudaNimi = Convert.ToInt32(Console.ReadLine());

        string muudaNimi = Convert.ToString(Console.ReadLine());

        Kutsekooliõpilane uuskutsekooliõpilane = new Kutsekooliõpilane(kutsekooliõpilane);
        uuskutsekooliõpilane.muudaNimi(muudaNimi);
        uuskutsekooliõpilane.print_Info();
    }
    else if (muudaValik == 0)
    {

    }

    Console.WriteLine("Kas te tahate vaata vanus või kooli asutus? vanus - 1 või kooli asutus - 2");
    int Valik = Convert.ToInt32(Console.ReadLine());

    if (Valik == 1)
    {
        kutsekooliõpilane.Vanus();
    }
    else if (Valik == 2)
    {
        Console.WriteLine(kutsekooliõpilane.kooliKoht("---"));
    }

    Console.WriteLine("Kas te tahate kirjuta see õpilane andmebaasi? Yah - 1 või Ei - 2");
    int andmebaasValik = Convert.ToInt32(Console.ReadLine());

    if (andmebaasValik == 1)
    {
        WriteToListHamster(kutsekooliõpilane);
    }
    else if (andmebaasValik == 2)
    {
        Console.WriteLine("Ok, headaega!");
    }
}