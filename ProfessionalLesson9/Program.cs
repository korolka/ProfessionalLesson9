//Завдання 2

//Створіть клас, який дозволить виконувати моніторинг ресурсів,
//що використовуються програмою. Використовуйте його з метою
//спостереження за роботою програми, а саме: користувач може
//вказати прийнятні рівні споживання ресурсів (пам'яті),
//а методи класу дозволять видати попередження, коли кількість ресурсів,
//що реально використовуються, наблизитися до максимально допустимого рівня.
namespace ProfessionalLesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monitoring monitoring = new Monitoring(4000);


            Thread thread = new Thread(new ThreadStart(monitoring.ChooseMemorySize));
            thread.Start();

            Thread thread1 = new Thread(monitoring.SomeMethod);
            thread1.Start();
        }
    }
}