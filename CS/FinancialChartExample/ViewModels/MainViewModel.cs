using DevExpress.XamarinForms.Charts;
using FinancialChartExample.Data;

namespace FinancialChartExample.ViewModels {
    public class MainViewModel {
        readonly CalculatedSeriesData calculatedSeriesData;
        readonly XYSeriesData stockSeriesData;
        readonly XYSeriesData volumeSeriesData;
        DateTimeRange visualRange;

        public CalculatedSeriesData CalculatedSeriesData => calculatedSeriesData;
        public XYSeriesData StockSeriesData => stockSeriesData;
        public XYSeriesData VolumeSeriesData => volumeSeriesData;
        public DateTimeRange VisualRange => visualRange;

        public MainViewModel() {
            StockPrices stockPrices = StockData.GetStockPrices();
            calculatedSeriesData = new CalculatedSeriesData();
            stockSeriesData = new XYSeriesData(stockPrices, DevExpress.XamarinForms.Charts.SeriesDataType.Financial);
            volumeSeriesData = new XYSeriesData(stockPrices, DevExpress.XamarinForms.Charts.SeriesDataType.DateTime);
            visualRange = new DateTimeRange() { VisualMin = new System.DateTime(2016, 7, 29), VisualMax = new System.DateTime(2016, 10, 15) };
        }
    }
}
