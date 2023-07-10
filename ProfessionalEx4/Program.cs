//Завдання 4

//Створіть свій клас, об'єкти якого займатимуть багато місця в пам'яті
//(наприклад, у коді класу буде великий масив) і реалізуйте для цього класу формалізований шаблон очищення.
namespace ProfessionalEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ExampleClass exampleClass = new ExampleClass())
            {
                exampleClass.Method();
            }
            
        }
    }
}
