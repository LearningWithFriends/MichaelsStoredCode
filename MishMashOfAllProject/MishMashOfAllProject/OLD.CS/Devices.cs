using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishMashOfAllProject
{
    public class CoffeMaker : IPluggable
    {
        private int _Voltage = 120;
        private string _PlugType = "NEMA20";
        private bool _Grounded = true;
        public int Voltage { get { return this._Voltage; } }
        public string PlugType { get { return this._PlugType; } }
        public bool Grounded { get { return this._Grounded; } }
    }
    public class Toaster : IPluggable
    {
        private int _Voltage = 15;
        private string _PlugType = "ungrounded Nema";
        private bool _Grounded = false;
        public int Voltage { get { return this._Voltage; } }
        public string PlugType { get { return this._PlugType; } }
        public bool Grounded { get { return this._Grounded; } }
    }

}
