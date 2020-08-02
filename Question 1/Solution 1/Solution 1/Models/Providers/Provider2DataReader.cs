using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Solution_1.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution_1.Models.Providers
{
    public class Provider2DataReader : ProviderDataReaderBase
    {
        private static readonly string _endpoint = "https://run.mocky.io/v3/cff2fa19-a599-46c7-a83c-c891ba721561";

        public Provider2DataReader() : base(_endpoint)
        {
        }

        public override List<ProviderModel> ConvertJson(string json)
        {
            List<ProviderModel> providerModels = new List<ProviderModel>();
            dynamic resultObjects = JObject.Parse(json);
            foreach (JObject property in resultObjects.result)
            {
                ProviderModel providerModel = new ProviderModel();
                providerModel.symbol = property["from"].ToString() + property["to"].ToString();
                providerModel.amount = double.Parse(property["value"].ToString());
                providerModels.Add(providerModel);
            }

            return providerModels;
        }
    }
}