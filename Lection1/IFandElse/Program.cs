Console.Write("Введите имя ");
string username = Console.ReadLine();

if(username.ToLower() == "рома")
{

    Console.WriteLine("Ура, хозяин пришел");
}
else
{
Console.Write("Салам, ");
Console.WriteLine(username);
}