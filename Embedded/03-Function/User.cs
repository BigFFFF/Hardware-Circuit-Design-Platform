using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embedded._03_Function
{
    public class User {

        private UInt16 id;
        private String num;
        private String name;
        private String pwd;

        public ushort Id { get => id; set => id = value; }
        public string Num { get => num; set => num = value; }
        public string Name { get => name; set => name = value; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}
