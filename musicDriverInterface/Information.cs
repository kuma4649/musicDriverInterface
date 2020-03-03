using System;
using System.Collections.Generic;

namespace musicDriverInterface
{
    public class Information
    {
        public List<Tuple<int, int, string>> warningList = new List<Tuple<int, int, string>>();
        public List<Tuple<int, int, string>> errorList = new List<Tuple<int, int, string>>();
    }
}
