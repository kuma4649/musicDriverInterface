
using System;
using System.Collections.Generic;
using System.Reflection;

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

        public string aliesName = "";
        public string aliesNextName = "";
        public int aliesDepth = 0;

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

            this.aliesName = "";
            this.aliesNextName = "";
            this.aliesDepth = 0;
        }

        public LinePos(string srcMMLID, int row = -1, int col = -1, int length = -1, string part = "", string chip = "", int chipIndex = 0, int chipNumber = 0, int ch = -1, string aliesName = "", string aliesNextName = "", int aliesDepth = 0)
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

            this.aliesName = aliesName;
            this.aliesNextName = aliesNextName;
            this.aliesDepth = aliesDepth;
        }

        public static void Clear(LinePos src)
        {
            if (src == null) return;

            src.srcMMLID = "";
            src.row = -1;
            src.col = -1;
            src.length = 1;
            src.part = "";
            src.chip = "";
            src.chipIndex = 0;
            src.chipNumber = 0;
            src.ch = -1;
            
            src.aliesName = "";
            src.aliesNextName = "";
            src.aliesDepth = 0;
        }

        public static void Move(LinePos src, LinePos des)
        {
            if (src == null || des == null) return;

            des.srcMMLID = src.srcMMLID;
            des.row = src.row;
            des.col = src.col;
            des.length = src.length;
            des.part = src.part;
            des.chip = src.chip;
            des.chipIndex = src.chipIndex;
            des.chipNumber = src.chipNumber;
            des.ch = src.ch;

            des.aliesName = src.aliesName;
            des.aliesNextName = src.aliesNextName;
            des.aliesDepth = src.aliesDepth;
        }


        public static LinePos Copy(LinePos src)
        {
            if (src == null) return null;

            LinePos ret = new LinePos(
                src.srcMMLID,
                src.row,
                src.col,
                src.length,
                src.part,
                src.chip,
                src.chipIndex,
                src.chipNumber,
                src.ch,

                src.aliesName,
                src.aliesNextName,
                src.aliesDepth
                );

            return ret;
        }

        public override bool Equals(object obj)
        {
            return obj is LinePos pos &&
                   srcMMLID == pos.srcMMLID &&
                   row == pos.row &&
                   col == pos.col &&
                   length == pos.length &&
                   part == pos.part &&
                   chip == pos.chip &&
                   chipIndex == pos.chipIndex &&
                   chipNumber == pos.chipNumber &&
                   ch == pos.ch &&

                   aliesName == pos.aliesName &&
                   aliesNextName == pos.aliesNextName &&
                   aliesDepth == pos.aliesDepth;
        }

        public override int GetHashCode()
        {
            int hashCode = -113896206;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(srcMMLID);
            hashCode = hashCode * -1521134295 + row.GetHashCode();
            hashCode = hashCode * -1521134295 + col.GetHashCode();
            hashCode = hashCode * -1521134295 + length.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(part);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(chip);
            hashCode = hashCode * -1521134295 + chipIndex.GetHashCode();
            hashCode = hashCode * -1521134295 + chipNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + ch.GetHashCode();

            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(aliesName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(aliesNextName);
            hashCode = hashCode * -1521134295 + aliesDepth.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return string.Format(
                "srcMMLID:{0} row:{1} col:{2} length:{3} part:{4} chip:{5} chipIndex:{6} chipNumber:{7} ch:{8} aliesName:{9} aliesNextName:{10} aliesDepth:{11}"
                , srcMMLID
                , row
                , col
                , length
                , part
                , chip
                , chipIndex
                , chipNumber
                , ch

                , aliesName
                , aliesNextName
                , aliesDepth
                );
        }
    }
}
