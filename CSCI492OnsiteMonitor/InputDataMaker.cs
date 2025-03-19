using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace CSCI492OnsiteMonitor
{
    internal class InputDataMaker
    {
        public static int ChangeData(String RadialGauge)
        {
            if (RadialGauge == "Test")
            {
                Random rnd = new Random();
                int min = 58; // Lower bound (inclusive)
                int max = 75; // Upper bound (exclusive)

                return rnd.Next(min, max);
            }
            else
            {
                Random rnd = new Random();
                int min = 58; // Lower bound (inclusive)
                int max = 75; // Upper bound (exclusive)

                return rnd.Next(min, max);
            }
        }
    }
}
