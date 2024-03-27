using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktgk
{
    internal class KhuPho
    {
        public int iDKhuPho {  get; set; }
        public string ten {  get; set; }

        public KhuPho(int iDKhuPho, string ten)
        {
            this.iDKhuPho = iDKhuPho;
            this.ten = ten;
        }

    }
}
