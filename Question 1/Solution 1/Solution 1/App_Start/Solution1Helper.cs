using Newtonsoft.Json.Linq;
using Solution_1.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Solution_1.App_Start
{
    public class Solution1Helper
    {
        public static string GetDataFromProvider(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                return json;
            }
        }

        public static void SaveData(List<ProviderModel> providerModels)
        {
            foreach (var item in providerModels)
            {
                new Solution_1_Data.DataManager().SaveData(item.symbol, item.amount);
            }
        }
    }
}