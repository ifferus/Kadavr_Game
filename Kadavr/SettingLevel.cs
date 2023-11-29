using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kadavr
{
    internal class SettingLevel
    {
        public int wolfsCount = 30;
        public int cactusCount = 10;
        public int speedWolfs = 5;


        public void EasyLevel()
        {
            wolfsCount = 30;
            cactusCount = 10;
            speedWolfs = 5;
        }

        public void MediumLevel()
        {
            wolfsCount= 40;
            cactusCount = 15;
            speedWolfs = 6;
        }

        public void HardLevel()
        {
            wolfsCount = 50;
            cactusCount = 20;
            speedWolfs = 7;
        }
    }
}
