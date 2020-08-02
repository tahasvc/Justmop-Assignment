using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Solution_1.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution_1.Models.Providers
{
    public class Provider1DataReader : ProviderDataReaderBase
    {
        private static readonly string _endpoint = "https://run.mocky.io/v3/e4c58892-3eaa-49e8-a2d4-88ffb0f97c27";

        public Provider1DataReader() : base(_endpoint)
        {
        }

        public override List<ProviderModel> ConvertJson(string json)
        {
            List<ProviderModel> providerModels = new List<ProviderModel>();
            dynamic resultObjects = JObject.Parse(json);
            foreach (JObject property in resultObjects.data)
            {
                ProviderModel providerModel = new ProviderModel();
                providerModel.symbol = property["symbol"].ToString();
                providerModel.amount = double.Parse(property["amount"].ToString());
                providerModels.Add(providerModel);
            }

            return providerModels;
        }
    }
}