using Solution_1_Data.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1_Data
{
    public class DataManager
    {
        public void SaveData(string symbol, double amount)
        {
            try
            {
                using (SolutionDbContext db = new SolutionDbContext())
                {
                    cheapest_currency model = new cheapest_currency();
                    model.symbol = symbol;
                    model.amount = amount;
                    db.cheapest_currency.Add(model);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
