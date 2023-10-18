Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Мария, добрый деннь, рады вас видеть!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}