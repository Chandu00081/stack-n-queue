using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackndQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue queue = new Queue();
            queue.Enqueue(34);
            queue.Enqueue(56);
            queue.Enqueue(13);
            queue.display();

            queue.Dequeue();
            queue.display();
            queue.Dequeue();
            queue.display();
            queue.Dequeue();
            queue.display();


        }
    }
}
