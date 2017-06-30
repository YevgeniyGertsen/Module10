using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Program
    {

        static void Main(string[] args)
        {
            //Basement basem = new Basement();
            //basem.startBuilding();
            //Walls walls = new Walls();
            //walls.startBuilding();
            List<IPart> listOfWork = new List<IPart>();
            listOfWork.Add(new Basement());
            listOfWork.Add(new Walls());
            listOfWork.Add(new Window());
            listOfWork.Add(new Door());
            listOfWork.Add(new Roof());
            var enumData=Enum.GetValues(typeof(Work.workers));

            for (int i = 1; i <= enumData.Length; i++)
            {
                Team.workers.Add(new Worker("Worker " + i,Work.workers.Jamshut));
                //var testi = (Enum.GetValues(typeof(Work.workers)).GetValue(i));
                //string msg = ((int)pParamEnum).ToString();
            }

            //Team.workers.Add(new Worker(Work.workers.Jamshut.ToString(), Work.workers.Jamshut));
            Random rand = new Random();
            Show sh = ShowMes;

            for (int i = 0; i < 50; i++)
            {
                Team.workers[rand.Next(0, enumData.Length)].toDoWork(ref listOfWork,sh);
            }

        }

        static void ShowMes(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
