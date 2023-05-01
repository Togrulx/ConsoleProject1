using ConsoleProject.Service.Implimentations;

MenuService menuServices = new MenuService();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("1.As Admin");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("2.As User");

string request = Console.ReadLine();

if (request == "1")
{
    bool result = await menuServices.Login();

    while (!result)
    {
        result = await menuServices.Login();

        if (!result)
        {
            Console.WriteLine("2.Return as User");
            request = Console.ReadLine();

            if (request == "2")
            {
                result = true;
            }

        }
    }
}
if (menuServices.IsAdmin)
{
    menuServices.ShowMenuAdmin();
}
else
{
    menuServices.ShowMenuUser();
}


