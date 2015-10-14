using System;

class CompanyInfo
{
    static void Main()
    {
        string program = "program";
        string user = "user";
        Console.WriteLine("{0, -30}|{1, 30}", program, user);
        Console.WriteLine("______________________________________________________________");
        string name = "Company name:";
        string softuni = "Software University";
        Console.WriteLine("{0, -30}|{1, 30}", name, softuni);
        string address = "Company address:";
        string tintiava = "15-18 Tintyava, Sofia";
        Console.WriteLine("{0, -30}|{1, 30}", address, tintiava);
        string phone = "Phone number:";
        string number = "+359 899 55 55 92";
        Console.WriteLine("{0, -30}|{1, 30}", phone, number);
        string fax = "Fax number:";
        string fnumber = "";
        Console.WriteLine("{0, -30}|{1, 30}", fax, fnumber);
        string web = "Web site:";
        string site = "http://softuni.bg";
        Console.WriteLine("{0, -30}|{1, 30}", web, site);
        string first = "Manager first name:";
        string svetlin = "Svetlin";
        Console.WriteLine("{0, -30}|{1, 30}", first, svetlin);
        string last = "Manager last name:";
        string nakov = "Nakov";
        Console.WriteLine("{0, -30}|{1, 30}", last, nakov);
        string age = "Manager age:";
        string years = "25";
        Console.WriteLine("{0, -30}|{1, 30}", age, years);
        string telephone = "Manager phone:";
        string phnumber = "+359 2 981 981";
        Console.WriteLine("{0, -30}|{1, 30}", telephone, phnumber);
        Console.WriteLine("______________________________________________________________");
        Console.WriteLine("{0}", softuni);
        Console.WriteLine("Address: {0}", tintiava);
        Console.WriteLine("Telephone: {0}", number);
        Console.WriteLine("Fax: {0}", fnumber);
        Console.WriteLine("Web site: {0}", site);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", svetlin, nakov, years, phnumber);
        Console.WriteLine("______________________________________________________________");
    }
}