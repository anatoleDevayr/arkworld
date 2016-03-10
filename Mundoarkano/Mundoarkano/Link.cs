using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundoarkano
{
    class Link
    {
        public string nombre { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return url;
        }
    }
}
