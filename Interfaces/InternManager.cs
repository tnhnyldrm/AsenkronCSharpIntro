using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("stajer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("stajer guncellendi");
        }
    }
}
