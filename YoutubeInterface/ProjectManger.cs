using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeInterface
{
    class ProjectManger
    {
        public void BaseAdd(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
