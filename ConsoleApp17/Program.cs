namespace ConsoleApp17;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            UserServise userServise = new UserServise();

            Console.WriteLine("1. Добавить нового пользователя");

            Console.WriteLine("2. Удалить пользователя");

            Console.WriteLine("3. Обновить данные пользователя");

            Console.WriteLine("4. Найти пользователя");

            Console.WriteLine("Выберите действие");
            int Value = int.Parse(Console.ReadLine());

            switch (Value)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите имя");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Возрост");
                        int Age = int.Parse(Console.ReadLine());
                        userServise.AddUser(Name, Age);

                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ID для удаления");
                        Guid guid = new Guid(Console.ReadLine());
                        userServise.RemoveID(guid);
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ID которого хотите обновить");
                        Guid Guid = new Guid(Console.ReadLine());
                        Console.WriteLine("Измените Имя");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Измените возрос");
                        int Age = int.Parse(Console.ReadLine());
                        userServise.RemoveUser(Guid, Name, Age);
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ID которого хотите найти");
                        Guid Guid = new Guid(Console.ReadLine());
                        User user = userServise.FindUser(Guid);
                        Console.WriteLine($"Имя = {user.Name}: Возврост = {user.Age}");
                        break;
                    }
            }
            Console.ReadKey();
            Console.Clear ();
        }
    }
}
