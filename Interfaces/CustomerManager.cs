using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //class larda -> inherits
    //interface lerde -> implements
    public class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("müşteri güncellendi");
        }
    }
}
