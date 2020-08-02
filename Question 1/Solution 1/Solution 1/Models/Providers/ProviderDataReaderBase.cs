using Solution_1.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution_1.Models.Providers
{
    public abstract class ProviderDataReaderBase : IProviderReader
    {
        private string _endpoint;
        public ProviderDataReaderBase(string endpoint)
        {
            this._endpoint = endpoint;
        }

        public abstract List<ProviderModel> ConvertJson(string json);

        public List<ProviderModel> ReadData()
        {
            string result = Solution1Helper.GetDataFromProvider(_endpoint);
            return this.ConvertJson(result);
        }
    }
}