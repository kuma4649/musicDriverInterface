using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicDriverInterface
{
    public class ChipDatum
    {
        public int port = 0;
        public int address = 0;
        public int data = 0;
        public long time = 0L;
        public object addtionalData = null;

        public ChipDatum(int port, int address, int data, long time = 0, object addtionalData = null)
        {
            this.port = port;
            this.address = address;
            this.data = data;
            this.time = time;
            this.addtionalData = addtionalData;
        }
    }
}
