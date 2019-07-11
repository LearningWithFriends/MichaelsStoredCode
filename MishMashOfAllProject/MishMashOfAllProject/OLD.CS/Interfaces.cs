using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    public interface IPluggable

    {
        int Voltage { get; }
        string PlugType { get; }
        bool Grounded { get; }

    }
}
