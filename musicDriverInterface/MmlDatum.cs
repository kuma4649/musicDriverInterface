using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicDriverInterface
{
    [Serializable]
    public class MmlDatum
    {
        public enmMMLType type = enmMMLType.unknown;
        public List<object> args = null;
        public int dat = 0;
        public LinePos linePos = null;

        public MmlDatum()
        {
        }

        public MmlDatum(int dat)
        {
            this.dat = dat;
        }

        public MmlDatum(enmMMLType type, List<object> args, LinePos linePos, int dat)
        {
            this.type = type;
            this.args = args;
            this.linePos = linePos;
            this.dat = dat;
        }

        public MmlDatum(int dat,enmMMLType type, LinePos linePos, params object[] args)
        {
            this.type = type;
            this.args = args != null ? args.ToList() : null;
            this.linePos = linePos;
            this.dat = dat;
        }


        public override string ToString()
        {
            return string.Format(
                "type:{0} args:{1} linePos:[ {2} ]"
                ,type
                ,args
                ,linePos
                );
        }

    }
}
