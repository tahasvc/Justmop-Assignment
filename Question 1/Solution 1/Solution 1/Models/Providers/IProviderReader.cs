using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution_1.Models.Providers
{
    public interface IProviderReader
    {
        List<ProviderModel> ReadData();
        List<ProviderModel> ConvertJson(string json);
    }
}