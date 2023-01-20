using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinMobile.Helper;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using Newtonsoft.Json;

namespace XamarinMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatsPage : ContentPage
    {
        public int month1;
        public StatsPage()
        {
            InitializeComponent();

            DisplayChart();
        }

        public void DisplayChart()
        {
            List<AreaOrdersCount> orderCounts;

            var entries = new List<ChartEntry>();

            orderCounts = new List<AreaOrdersCount>();
            orderCounts.Add(new AreaOrdersCount { Area = "January", OrderCount = 5});
            orderCounts.Add(new AreaOrdersCount { Area = "February", OrderCount = 8});
            orderCounts.Add(new AreaOrdersCount { Area = "March", OrderCount = 9 });
            orderCounts.Add(new AreaOrdersCount { Area = "April", OrderCount = 4 });
            orderCounts.Add(new AreaOrdersCount { Area = "May", OrderCount = 15 });
            orderCounts.Add(new AreaOrdersCount { Area = "June", OrderCount = 3 });
            orderCounts.Add(new AreaOrdersCount { Area = "July", OrderCount = 1 });
            orderCounts.Add(new AreaOrdersCount { Area = "August", OrderCount = 9 });
            orderCounts.Add(new AreaOrdersCount { Area = "September", OrderCount =  10});
            orderCounts.Add(new AreaOrdersCount { Area = "October", OrderCount = 10});
            orderCounts.Add(new AreaOrdersCount { Area = "November", OrderCount = 3 });
            orderCounts.Add(new AreaOrdersCount { Area = "December", OrderCount = 25 });
            
            
            foreach(var data in orderCounts)
            {
                Random ran = new Random();
                SKColor randomColor = SKColor.FromHsv(ran.Next(256), ran.Next(256), ran.Next(256));

                var entry = new ChartEntry(data.OrderCount)
                {
                    Label = data.Area,
                    ValueLabel = data.OrderCount.ToString(),
                    Color = randomColor

                };
                entries.Add(entry);

            }
          
            var lineChart = new LineChart() { 
             Entries = entries,
             LabelTextSize = 25,
            };

            var donutChart = new DonutChart()
            {
                Entries = entries,
                LabelTextSize = 25,
            };

            var barChart = new BarChart()
            {
                Entries = entries,
                LabelTextSize = 25,
            };

            this.lineChart.Chart = lineChart;
            this.barChart.Chart = barChart;
            this.donutChart.Chart = donutChart;


        }

        public class AreaOrdersCount
        {
            public string Area { get; set; }
            public int OrderCount { get; set; }
        }
    }
}