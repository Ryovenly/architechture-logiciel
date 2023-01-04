using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Sd : ITarget
    {
        private readonly MicroSd _microSd;
        public Sd(MicroSd microSd)
        {
            this._microSd = microSd;
        }

        public string GetRequest()
        {
            return $"name = {_microSd.name}, connected = {_microSd.connected}, data = {_microSd.data}";
        }
    }
}
