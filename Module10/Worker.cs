using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public delegate void Show(string mes);
    public class Worker : IWorker
    {
        public Show show;
        public string name { get; set; }
        public Work.workers position { get; set; }
        public Worker(string name) : this(name, Work.workers.Ravshan) { }
        public Worker(string name, Work.workers position)
        {
            this.name = name;
            this.position = position;
        }
        public void toDoWork(ref List<IPart> listOfWork, Show show)
        {
            /*
             Посчитать количество отработанных часов
             */

            foreach(var item in listOfWork.Where(l=>!l.isDone))
            {
                item.startDate = DateTime.Now;
                show(String.Format("Начал работу:  {0}\n в позиции {1}", name, position));
                Basement basem = new Basement();
                basem.startBuilding();
                break;
            }
            
        }
    }
}
