using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAutoBuy
{
    public class Equipa
    {
        public string Nome { get; set; }
        public string Vaue { get; set; }
        public TypeEquipa Type { get; set; }
        public Bitmap Resources { get; set; }

        public enum TypeEquipa
        {
            Pistolas,
            Escopetas,
            Sub_Metralhadoras,
            Rifles,
            Metralhadoras,
            Municoes,
            Equipamentos
        }
    }
}
