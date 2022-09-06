using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekDevExpress
{
    public class koltukTBL
    {
        public koltukTBL()
        {

        }
        public int koltuk_id { get; set; }
        public int salon_id { get; set; }
        public string koltuk_harf { get; set; }
        public string koltuk_sira { get; set; }
        public char cinsiyet { get; set; }
    }
}
