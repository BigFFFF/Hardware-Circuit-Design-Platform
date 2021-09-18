using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedded._03_Function {

    /// <summary>
    /// 公共常量类
    /// </summary>
    public class PublicVar {

        /// <summary>
        /// 门电路图片高
        /// </summary>
        private static readonly int PicGateH = 64;

        /// <summary>
        /// 门电路图片宽
        /// </summary>
        private static readonly int PicGateW = 64;

        public static int PicGateHV => PicGateH;

        public static int PicGateWV => PicGateW;
    }
}
