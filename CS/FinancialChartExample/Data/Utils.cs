using DevExpress.XF.Charts;

namespace FinancialChartExample.Data {
    class AxisLabelTextFormatter : IAxisLabelTextFormatter {
        public string Format(object value) => (((double)value) / 1000000.0).ToString() + "M";
    }
}
