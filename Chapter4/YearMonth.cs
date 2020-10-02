using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class YearMonth {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public bool Is21Century => Year >= 2001 && Year <= 2100 ? true : false; 
        public YearMonth(int year,int month) {
            Year = year;
            Month = month;
        }
        public YearMonth AddOneMonth() {
            if (Month == 12)
                return new YearMonth(Year + 1, 1);
            else
                return new YearMonth(Year, Month + 1);
        }
        public override string ToString() {
            return $"{Year}年{Month}月";
        }

    }
}
