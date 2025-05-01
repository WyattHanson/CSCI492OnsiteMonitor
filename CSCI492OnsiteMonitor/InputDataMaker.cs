using MongoDB.Driver;
using MongoDB.Bson;
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
        

        public static int ChangeData(String RadialGauge, Single val)
        {
            if (RadialGauge == "Test")
            {
                Random rnd = new Random();
                int min = -1; // Lower bound (inclusive)
                int max = 2; // Upper bound (exclusive)
                int ranNum = rnd.Next(min, max);
                float newval = val + ranNum;
                if (newval > 79 || newval < 1)
                {
                    return (int)val;
                }
                else
                {
                    return (int)newval;
                }
            }
            /* First Test Case           
             *           
            if (RadialGauge == "Test")
            {
                Random rnd = new Random();
                int min = 50; // Lower bound (inclusive)
                int max = 81; // Upper bound (exclusive)

                return rnd.Next(min, max);
            }
            */
            else if (RadialGauge == "Error")
            {
                Random rnd = new Random();
                int min = -1; // Lower bound (inclusive)
                int max = 2; // Upper bound (exclusive)
                int ranNum = rnd.Next(min, max);
                float newval = val + ranNum;
                if (newval > 99 || newval < 70)
                {
                    return (int)val;
                }
                else
                {
                    return (int)newval;
                }

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
