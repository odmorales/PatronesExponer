using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Context
    {
        private IStrategy? _strategy;

        public IStrategy? Strategy { set { _strategy = value; } }

        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
