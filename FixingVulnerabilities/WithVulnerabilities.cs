using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixingVulnerabilities
{
    class WithVulnerabilities
    {
        public void Execute(string data)
        {
            Logger logger;
            //вставка данных как есть, содержащих уязвимость
            logger.Warn(data + " log in requested"); 
        }
    }
}
