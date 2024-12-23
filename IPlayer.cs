using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Vezbanje.Models
{
    public interface IPlayer 
    {
        IChoice.Choice GetChoice();
    }
}
