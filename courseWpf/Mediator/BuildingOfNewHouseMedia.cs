using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using courseWpf.Houses;

namespace courseWpf.Mediator
{
    internal class BuildingOfNewHouseMedia:BaseWorkDistributor
    {
        public House SendMessage()
        {
            return this.mediator.Notify(this, 2);
        }
    }
}
