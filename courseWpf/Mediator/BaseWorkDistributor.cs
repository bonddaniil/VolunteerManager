using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Mediator
{
    internal class BaseWorkDistributor
    {
        protected IMediator mediator;

        /*public BaseWorkDistributor(IMediator mediator = null)
        {
            this.mediator = mediator;
        }*/

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
