using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Module10
{
    public class Building
    {
        private Random rand = new Random();
      
        public virtual void startBuilding()
        {
            var countDay = rand.Next(10,20);
            int i = 1;
            while (countDay != i)
            {
                Console.Write(" . ");
                i++;
                Thread.Sleep(200);
            }
            Console.WriteLine();
        }
    }
}
