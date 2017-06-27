using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    public interface IPart
    {
        bool isDone { get;}
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
    }
}
