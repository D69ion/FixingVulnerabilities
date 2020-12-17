using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixingVulnerabilities
{
    class WithoutVulnerabilities
    {
        public void Execute(string data)
        {
            Logger logger;
            //вставка измененных данных, которые избавлены от уязвимости
            logger.Warn(data.Replace(Environment.NewLine, "") + " log in requested");
        }
    }
}
