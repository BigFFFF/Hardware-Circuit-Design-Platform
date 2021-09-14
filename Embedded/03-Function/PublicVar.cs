using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedded._03_Function {
    public class PublicVar {
        private static readonly int PicGateH = 64;
        private static readonly int PicGateW = 64;

        public static int PicGateHV => PicGateH;

        public static int PicGateWV => PicGateW;
    }
}
