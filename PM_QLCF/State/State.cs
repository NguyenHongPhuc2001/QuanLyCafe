using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.State
{
    abstract class State
    {
        public abstract void HandleRequest(Model.Ban ban);
        
    }
}
