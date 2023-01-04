using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MicroSd
    {
        public string name;
        public bool connected;
        public string data;

        public MicroSd(string name, bool connected, string data)
        {
            this.name = name;
            this.connected = connected;
            this.data = data;
        }
    }
}
