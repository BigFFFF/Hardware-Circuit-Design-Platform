using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedded._03_Function {


    public class BinaryTree {
        
        private Gate head;
        private string data;
        private bool bBtree;
        private bool _alreadyDisposed = false;

        public Gate Head { get => head; set => head = value; }
        public string Data { get => data; set => data = value; }
        public bool BBtree { get => bBtree; set => bBtree = value; }
        public bool AlreadyDisposed { get => _alreadyDisposed; set => _alreadyDisposed = value; }

        public BinaryTree() {
            Head = new Gate();
            Data = string.Empty;
            BBtree = false;
        }

        public BinaryTree(Gate gate) {
            Head = gate;
            Data = string.Empty;
            BBtree = false;
        }

        /// <summary>
        ///后序遍历，计算表达式及替换
        /// </summary>
        /// <param name="gate"></param>
        public void PostOrder_CalBDS_ReplaceBd(Gate gate) {
            if (gate != null) {
                PostOrder_CalBDS_ReplaceBd(gate.LChild);
                PostOrder_CalBDS_ReplaceBd(gate.RChild);
                
                gate.CalBDS(gate.PIO, gate.Op);

                ReplaceBd(gate);
            }
        }

        /// <summary>
        /// 后序遍历，计算逻辑值
        /// </summary>
        /// <param name="gate"></param>
        public void PostOrder_Cal(Gate gate) {
            if (gate != null) {
                PostOrder_Cal(gate.LChild);
                PostOrder_Cal(gate.RChild);

                gate.Cal(gate.Op);
            }
        }
        /// <summary>
        /// 后序遍历，清除
        /// </summary>
        /// <param name="gate"></param>
        public void PostOrder_Clean(Gate gate) {
            if (gate != null) {
                PostOrder_Clean(gate.LChild);
                PostOrder_Clean(gate.RChild);

                gate.Bd = string.Empty;
                gate.BGateVal = false;
                Data = string.Empty;
            }
        }

        /// <summary>
        /// 替换节点逻辑形式 
        /// </summary>
        /// <param name="gate"></param>
        private void ReplaceBd(Gate gate) {
            if ((gate.LChild != null) & (gate.RChild == null)) {
                gate.Bd = gate.Bd.Replace("1", gate.LChild.Bd);
            }
            else if ((gate.LChild == null) & (gate.RChild != null)) {
                gate.Bd = gate.Bd.Replace("2", gate.RChild.Bd);
            }
            else if ((gate.LChild != null) & (gate.RChild != null)) {
                gate.Bd = gate.Bd.Replace("1", gate.LChild.Bd);
                gate.Bd = gate.Bd.Replace("2", gate.RChild.Bd);
            }
            //Data = gate.Bd;
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~BinaryTree() {
            Dispose(false);
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDisposing) {
            if (AlreadyDisposed) {
                return;
            }
            if (isDisposing) {

            }

            AlreadyDisposed = true;

        }
    }
}
