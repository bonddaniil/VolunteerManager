using courseWpf.Houses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseWpf.Mediator
{
    public interface IMediator
    {
        House Notify(object sender, int typeOfWork);
    }
}
