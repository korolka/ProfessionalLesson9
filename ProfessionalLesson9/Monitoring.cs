using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalLesson9
{
    class Monitoring
    {
        int memorySize;
        public Monitoring[] array;
        public Monitoring(int memorySize)
        {
            this.memorySize = memorySize;
        }
        public void ChooseMemorySize()
        {
            bool flag = true;
            while (flag)
            {
                if (memorySize <= GC.GetTotalMemory(false) / 1000000)
                {
                    Console.WriteLine("Don`t have a memory");
                    flag = false;
                }
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine($"How much memory is currently full :{GC.GetTotalMemory(false) / 1000000}");

            }
        }

        public void SomeMethod()
        {
            array = new Monitoring[100000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Monitoring(i);
            }
        }
    }
}
