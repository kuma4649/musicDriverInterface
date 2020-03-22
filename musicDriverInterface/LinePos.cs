
using System;

namespace musicDriverInterface
{
    [Serializable]
    public class LinePos
    {
        public string srcMMLID = "";
        public int row = -1;
        public int col = -1;
        public int length = 1;
        public string part = "";
        public string chip = "";
        public int chipIndex = 0;
        public int chipNumber = 0;
        public int ch = -1;

        public LinePos()
        {
            this.srcMMLID = "";
            this.row = -1;
            this.col = -1;
            this.length = 1;
            this.part = "";
            this.chip = "";
            this.chipIndex = 0;
            this.chipNumber = 0;
            this.ch = -1;
        }

        public LinePos(string srcMMLID, int row = -1, int col = -1, int length = -1, string part = "", string chip = "", int chipIndex = 0, int chipNumber = 0, int ch = -1)
        {
            this.srcMMLID = srcMMLID;
            this.row = row;
            this.col = col;
            this.length = length;
            this.part = part;
            this.chip = chip;
            this.chipIndex = chipIndex;
            this.chipNumber = chipNumber;
            this.ch = ch;
        }
    }
}
