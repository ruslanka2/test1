Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "Маша")
{
    Console.WriteLine("О, шкура пришла");

}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);

}