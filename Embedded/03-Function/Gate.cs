using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedded._03_Function {

    /// <summary>
    /// 门电路节点类
    /// </summary>
    public class Gate {

        private bool disposedValue = false; // 要检测冗余调用

        /// <summary>
        /// 逻辑形式
        /// </summary>
        private string bd;

        /// <summary>
        /// 节点IO
        /// </summary>
        private string pIO;

        /// <summary>
        /// 逻辑运算符
        /// </summary>
        private string op;

        /// <summary>
        /// 逻辑值
        /// </summary>
        private bool bGateVal;

        /// <summary>
        /// 上节点
        /// </summary>
        private Gate lChild;

        /// <summary>
        /// 下节点
        /// </summary>
        private Gate rChild;

        public Gate() {
            Bd = string.Empty;
            LChild = null;
            RChild = null;
        }

        public Gate(string bd) {

            Bd = bd.Substring(0, 1);

            if (bd.Length > 2) {
                if (bd.Substring(bd.Length - 2) == "=1") {
                    BGateVal = true;
                }
                else if (bd.Substring(bd.Length - 2) == "=0") {
                    BGateVal = false;
                }
            }
            LChild = null;
            RChild = null;
        }

        public Gate(string pIO, string op) {
            Bd = string.Empty;
            PIO = pIO;
            Op = op;
            LChild = null;
            RChild = null;
        }

        /// <summary>
        /// 电路逻辑值映射
        /// </summary>
        /// <param name="bd"></param>
        public void SetGateVar(string bd) {
            if (bd.Substring(bd.Length - 2) == "=1") {
                BGateVal = true;
            }
            else if (bd.Substring(bd.Length - 2) == "=0") {
                BGateVal = false;
            }
        }

        /// <summary>
        /// 节点逻辑值表达式
        /// 1：上引脚
        /// 2：下引脚
        /// </summary>
        /// <param name="pIO"></param>
        /// <param name="op"></param>
        public void CalBDS(string pIO, string op) {

            PIO = pIO;
            Op = op;

            switch (Op) {
                case "and":
                    Bd = "(12)";
                    break;
                case "or":
                    Bd = "(1+2)";
                    break;
                case "not":
                    if (PIO.Substring(0, 1) == "s") {
                        Bd = "(!1)";
                    }
                    else {
                        Bd = "(!2)";
                    }
                    break;
                case "nand":
                    Bd = "(!(12))";
                    break;
                case "nor":
                    Bd = "(!(1+2))";
                    break;
                case "xor":
                    Bd = "(1@2)";
                    break;
                case "xnor":
                    Bd = "(!(1@2))";
                    break;
                case "wire":
                    if(PIO.Substring(0, 1) == "s") {
                        Bd = "(1)";
                    }
                    else {
                        Bd = "(2)";
                    }
                    break;
                default:
                    return;
            }
        }
        /// <summary>
        /// 节点逻辑值计算
        /// </summary>
        /// <param name="op"></param>
        public void Cal(string op) {
            Op = op;
            switch (Op) {
                case "and":
                    BGateVal = LChild.BGateVal & RChild.BGateVal;
                    break;
                case "or":
                    BGateVal = LChild.BGateVal | RChild.BGateVal;
                    break;
                case "not":
                    if ((LChild != null) & (RChild == null)) {
                        BGateVal = !LChild.BGateVal;
                    }
                    else if ((LChild == null) & (RChild != null)) {
                        BGateVal = !RChild.BGateVal;
                    }
                    break;
                case "nand":
                    BGateVal = !(LChild.BGateVal & RChild.BGateVal);
                    break;
                case "nor":
                    BGateVal = !(LChild.BGateVal | RChild.BGateVal);
                    break;
                case "xor":
                    BGateVal = LChild.BGateVal ^ RChild.BGateVal;
                    break;
                case "xnor":
                    BGateVal = !(LChild.BGateVal ^ RChild.BGateVal);
                    break;
                case "wire":
                    if ((LChild != null) & (RChild == null)) {
                        BGateVal = LChild.BGateVal;
                    }
                    else if ((LChild == null) & (RChild != null)) {
                        BGateVal = RChild.BGateVal;
                    }
                    break;
                default:
                    return;
            }
        }

        public string Bd { get => bd; set => bd = value; }
        public Gate LChild { get => lChild; set => lChild = value; }
        public Gate RChild { get => rChild; set => rChild = value; }
        public string PIO { get => pIO; set => pIO = value; }
        public string Op { get => op; set => op = value; }
        public bool BGateVal { get => bGateVal; set => bGateVal = value; }


        #region IDisposable Support       
        /// <summary>
        /// IDisposable自动生成Dispose及析构函数
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    // TODO: 释放托管状态(托管对象)。
                }

                // TODO: 释放未托管的资源(未托管的对象)并在以下内容中替代终结器。
                // TODO: 将大型字段设置为 null。

                disposedValue = true;
            }
        }

        // TODO: 仅当以上 Dispose(bool disposing) 拥有用于释放未托管资源的代码时才替代终结器。
        ~Gate() {
          // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(false);
        }

        // 添加此代码以正确实现可处置模式。
        public void Dispose() {
            // 请勿更改此代码。将清理代码放入以上 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果在以上内容中替代了终结器，则取消注释以下行。
            GC.SuppressFinalize(this);
        }
        #endregion
    }

}
