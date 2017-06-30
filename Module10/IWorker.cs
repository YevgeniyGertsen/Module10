﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    interface IWorker
    {
        string name { get; set; }
        Work.workers position { get; set; }
        void toDoWork(ref List<IPart> listOfWork, Show show);
    }
}
