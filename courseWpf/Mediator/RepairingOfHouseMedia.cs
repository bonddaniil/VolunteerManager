using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Mediator
{
    internal class RepairingOfHouseMedia:BaseWorkDistributor
    {
        public House SendMessage()
        {
            return this.mediator.Notify(this, 0);
        }
    }
}
