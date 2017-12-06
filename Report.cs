using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Manager
{
    interface Report
    {
        //public decimal ClientSum { get; set; }
        //public decimal AvgReceipt {get; set;}
        //public virtual void GetSum() { }
        //public virtual void GetAvgReceipt() { }
        void SaveCompleteReport(string pathName);
                            
    }
}
