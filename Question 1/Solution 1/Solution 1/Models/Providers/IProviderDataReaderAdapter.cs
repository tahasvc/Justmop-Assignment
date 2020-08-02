using Solution_1.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1.Models
{
    interface IProviderDataReaderAdapter
    {
        string ReadCheapestCurrencies();
    }
}
