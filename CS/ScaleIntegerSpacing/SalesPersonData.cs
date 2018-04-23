using System;
using System.Collections.Generic;

namespace ScaleIntegerSpacing {
    public class ViewModel {
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public static List<ViewModel> CreateData() {
            List<ViewModel> data = new List<ViewModel>();
            var rnd = new Random(100);
            for(int i = 0; i < 12; i++) {
                ViewModel record = new ViewModel();
                record.Date = DateTime.Now.AddDays(i);
                record.Value = rnd.Next(0, 5);
                data.Add(record);
            }
            return data;
        }
    }
}