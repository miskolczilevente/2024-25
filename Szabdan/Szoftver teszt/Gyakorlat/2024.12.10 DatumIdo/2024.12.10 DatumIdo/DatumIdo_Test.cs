using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._10_DatumIdo
{
    [TestFixture]
    internal class DatumIdo_Test
    {
        private DatumIdo datumido;

        [Setup]
        public void Setup()
        {
            datumido = new DatumIdo("2000:05:20");
        }
    }
}
