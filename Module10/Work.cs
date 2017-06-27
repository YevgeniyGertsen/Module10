using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public struct Work
    {
        public enum workers:long {Jamshut=1500, Ravshan=2000, Kalibshut=3000, BigBoss=6666 }
        public void GetWorker(workers w)
        {
            switch (w)
            {
                case workers.Jamshut:
                    Console.WriteLine("Рабочий {0} за час берёт {1}",workers.Jamshut.ToString(),(long)workers.Jamshut);
                    break;
                case workers.Ravshan:
                    Console.WriteLine("Рабочий {0} за час берёт {1}", workers.Ravshan.ToString(), (long)workers.Ravshan);
                    break;
                case workers.Kalibshut:
                    Console.WriteLine("Рабочий {0} за час берёт {1}", workers.Kalibshut.ToString(), (long)workers.Kalibshut);
                    break;
                case workers.BigBoss:
                    Console.WriteLine("Рабочий {0} за час берёт {1}", workers.BigBoss.ToString(), (long)workers.BigBoss);
                    break;
                default:
                    break;
            }
        }
    }
}
