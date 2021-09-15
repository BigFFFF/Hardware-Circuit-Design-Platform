using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedded._03_Function {
    public class Gate {

        private bool _alreadyDisposed = false;

        /**
         * 逻辑形式
         */
        private string bd;

        /**
         * 节点IO
         */
        private string pIO;

        /**
         * 逻辑运算符
         */
        private string op;

        /**
         * 逻辑值
         */
        private bool bGateVal;

        /**
         * 上节点
         */
        private Gate lChild;

        /**
         * 下节点
         */
        private Gate rChild;

        public Gate() {
            Bd = "";
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
            Bd = "";
            PIO = pIO;
            Op = op;
            LChild = null;
            RChild = null;
        }

        public void SetGateVar(string bd) {
            if (bd.Length > 0) {
                Bd = bd.Substring(0, 1);
            }
            else if (bd.Length > 2) {
                if (bd.Substring(bd.Length - 2) == "=1") {
                    BGateVal = true;
                }
                else if (bd.Substring(bd.Length - 2) == "=0") {
                    BGateVal = false;
                }
            }
        }

        /**
         * 节点逻辑值表达式
         * 1：上引脚
         * 2：下引脚
         */
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
        /**
         * 节点逻辑值计算
         */
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
                    if ((LChild !=null) & (RChild == null)) {
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
        public bool AlreadyDisposed { get => _alreadyDisposed; set => _alreadyDisposed = value; }
    }

}
