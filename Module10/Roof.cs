using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Roof : Building, IPart
    {

        private Random rand = new Random();
        protected DateTime sDate = new DateTime();
        protected DateTime eDate = new DateTime();
        public DateTime startDate
        {
            get { return sDate; }
            set { sDate = value.AddDays(1); }
        }
        public DateTime endDate
        {
            get { return eDate; }
            set { eDate = value.AddDays(rand.Next(1, 10)); }
        }
        public bool isDone
        {
            get
            {
                if (DateTime.MinValue != eDate)
                    return true;
                else return false;
            }
        }
        public override void startBuilding()
        {
            Console.WriteLine("Eto budet krysha epta");
            base.startBuilding();
            Console.WriteLine("Eto byl krysha epta");
        }
    }
}
