using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Usba : ITarget
    {
        private readonly Usbc _usbc;
        public Usba(Usbc usbc)
        {
            this._usbc = usbc;
        }

        public string GetRequest()
        {
            return $"name = {_usbc.name}, connected = {_usbc.connected}, data = {_usbc.data}";
        }
    }
}
