using Newtonsoft.Json;
using Solution_1.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution_1.Models.Providers
{
    public class ProviderDataReaderAdapter : IProviderDataReaderAdapter
    {
        public string ReadCheapestCurrencies()
        {
            List<ProviderModel> result = this.ResultCheapestCurrencies(
                new Provider1DataReader().ReadData(), new Provider2DataReader().ReadData());
            Solution1Helper.SaveData(result);

            return JsonConvert.SerializeObject(result);
        }
        private List<ProviderModel> ResultCheapestCurrencies(params object[] providerModels)
        {
            List<ProviderModel> cheapestList = new List<ProviderModel>();
            List<double> usdtry = new List<double>();
            List<double> eurtry = new List<double>();
            List<double> gbptry = new List<double>();
            foreach (var item in providerModels)
            {
                List<ProviderModel> models = (List<ProviderModel>)item;
                usdtry.Add(models[0].amount);
                eurtry.Add(models[1].amount);
                gbptry.Add(models[2].amount);
            }
            cheapestList.Add(new ProviderModel() { symbol = "usdtry", amount = usdtry.Min() });
            cheapestList.Add(new ProviderModel() { symbol = "eurtry", amount = eurtry.Min() });
            cheapestList.Add(new ProviderModel() { symbol = "gbptry", amount = gbptry.Min() });

            return cheapestList;
        }
    }
}