using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAutoBuy
{
    public class Configs
    {
        public string Cfg { get; set; }
        public List<Bind> Binds { get; set; }

        public Configs()
        {
            this.Cfg = "";
            this.Binds = new List<Bind>();
        }
    }
}
