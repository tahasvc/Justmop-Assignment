using Solution_1.App_Start;
using Solution_1.Models;
using Solution_1.Models.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace Solution_1.Controllers
{
    public class ComparesCurrenciesController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                IProviderDataReaderAdapter providerDataReader = new ProviderDataReaderAdapter();
                string result = providerDataReader.ReadCheapestCurrencies();
                return new RawJsonActionResult(result);
            }
            catch (Exception ex)
            {
                return new RawJsonActionResult(ex.Message);
            }
        }
    }
}
