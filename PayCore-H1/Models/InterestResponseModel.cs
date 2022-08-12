using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayCore_H1.Models
{
    public class InterestResponseModel
    //created class to return results
    {
        public double InterestRate { get; set; }//faiz oranı
        public int InterestYield { get; set; }//faiz getirisi
        public int TotalBalance { get; set; }//toplam para
    }
}
