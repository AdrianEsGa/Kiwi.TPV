using System;

namespace Kiwi.Tpv.Database.DTOs.ReportDTOs
{
    public class SaleDetailsReportDto
    {
        //Sale head
        public string SaleId { private get; set; }
        public string Station { private get; set; }
        public string Employee { get; set; }
        public DateTime Date { private get; set; }
        public double TotalSale { get; set; }
        public double TaxSale { get; set; }
        public double DisscountSale { private get; set; }

        //Sale details
        public string Product { get; set; } //IsBottle
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SubTotal { get; set; }
        public double TaxPercentaje { get; set; }
        public double Tax { get; set; }
        public double Total { get; set; }

        public string SaleHead
        {
            get { return ToString(); }
        }

        public override string ToString()
        {
            return SaleId + Environment.NewLine +
                   "Caja: " + Station + Environment.NewLine +
                   "Fecha/Hora: " + Date + Environment.NewLine +
                   "Descuento: " + DisscountSale + Environment.NewLine;
        }
    }
}