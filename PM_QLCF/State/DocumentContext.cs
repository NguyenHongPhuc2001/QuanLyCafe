using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM_QLCF.State
{
    internal class DocumentContext
    {
        private State state;

        public void setState(State state)
        {
            this.state = state;
        }

        public void applyState(Model.Ban ban)
        {
            this.state.HandleRequest(ban);
        }
    }
}
