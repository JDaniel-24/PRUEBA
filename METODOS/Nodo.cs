using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_09
{
    internal class Nodo
    {
        private int vinfo;
        private Nodo vizq;
        private Nodo vder;

        public int info
        {
            get { return vinfo;}
            set { vinfo = value; }
        }
        public Nodo izq
        {
            get { return vizq; }
            set { vizq = value; }
        }
        public Nodo der
        {
            get { return vder; }
            set { vder = value; }
        }
        public Nodo (int vinfo)
        {
            info = vinfo;
            izq = null;
            der = null;
        }
    }
}
