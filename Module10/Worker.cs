using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public class Worker : IWorker
    {

        public string name { get; set; }
        public string position { get; set; }
        public Worker(string name) : this(name, Work.workers.Ravshan) { }
        public Worker(string name, Work.workers position)
        {
            this.name = name;
            this.position = position.ToString();
        }
        public void toDoWork(ref List<IPart> listOfWork)
        {
            /*
             Посчитать количество отработанных часов
             */

            foreach(var item in listOfWork.Where(l=>!l.isDone))
            {
                item.startDate = DateTime.Now;
                Console.WriteLine(String.Format("Начал работу:  {0}\n в позиции {1}", name, position));
                Basement basem = new Basement();
                basem.startBuilding();
                break;
            }
            
        }
    }
}
