using DevExpress.XamarinForms.Charts;
using FinancialChartExample.Data;

namespace FinancialChartExample.ViewModels {
    public class MainViewModel {
        public StockPrices StockPrices { get; }
        public DateTimeRange VisualRange { get; }

        public MainViewModel() {
            StockPrices = StockData.GetStockPrices();
            VisualRange = new DateTimeRange() {
                VisualMin = new System.DateTime(2016, 06, 10),
                VisualMax = new System.DateTime(2016, 08, 29)
            };
        }
    }
}
