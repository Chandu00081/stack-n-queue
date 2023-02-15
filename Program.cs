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
            Stack stack = new Stack();
            stack.push(86);
            stack.push(23);
            stack.push(43);
            stack.display();
            stack.peak();
            stack.pop();
            stack.peak();
            stack.pop();
            stack.peak();
            stack.pop();
            stack.display();


        }
    }
}
