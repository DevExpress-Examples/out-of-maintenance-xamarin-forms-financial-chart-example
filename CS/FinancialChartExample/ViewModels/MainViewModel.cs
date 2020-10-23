using DevExpress.XamarinForms.Charts;
using FinancialChartExample.Data;

namespace FinancialChartExample.ViewModels {
    public class MainViewModel {
        public CalculatedSeriesData CalculatedSeriesData { get; }
        public XYSeriesData StockSeriesData { get; }
        public XYSeriesData VolumeSeriesData { get; }
        public DateTimeRange VisualRange { get; }

        public MainViewModel() {
            StockPrices stockPrices = StockData.GetStockPrices();
            CalculatedSeriesData = new CalculatedSeriesData();
            StockSeriesData = new XYSeriesData(stockPrices, SeriesDataType.Financial);
            VolumeSeriesData = new XYSeriesData(stockPrices, SeriesDataType.DateTime);
            VisualRange = new DateTimeRange() { VisualMin = new System.DateTime(2016, 06, 10), VisualMax = new System.DateTime(2016, 08, 29) };
        }
    }
}
