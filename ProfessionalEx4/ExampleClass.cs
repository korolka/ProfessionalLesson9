using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx4
{
    class ExampleClass: IDisposable
    {
        private int[] array;
        private bool disposed =false;

        public void Method()
        {
            array = new int[1000000];
            for(int i=0;i<array.Length; i++)
            {
                array[i] = i;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if(disposed) return;
            if (disposing)
            {
                Console.WriteLine("Clear of memory");
            }
            disposed = true;
        }

        ~ExampleClass() 
        {
            Dispose(false); 
        }
    }
}
