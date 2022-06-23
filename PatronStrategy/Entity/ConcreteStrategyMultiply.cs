using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ConcreteStrategyMultiply : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
