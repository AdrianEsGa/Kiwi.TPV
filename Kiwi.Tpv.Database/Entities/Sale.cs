using System;
using System.Collections.Generic;
using System.Linq;

namespace Kiwi.Tpv.Database.Entities
{
    public class Sale
    {
        public Sale()
        {
            Id = 0;
            Details = new List<SaleDetail>();
            Paid = false;
            Ticket = false;
        }

        public int Id { get; set; }
        public Station Station { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public double Disscount { get; set; }
        public double Tax { get; set; }
        public PayType PayType { get; set; }
        public List<SaleDetail> Details { get; set; }
        public BarTable Table { get; set; }
        public bool Paid { get; set; }
        public bool Ticket { get; set; }

        public void Add(Product product, SaleMode saleMode)
        {
            var price = saleMode == SaleMode.Day ? product.SaleDayPrice : product.SaleNightPrice;

            foreach (var detail in Details)
                if (detail.Product.Id == product.Id && detail.Product.Type == product.Type &&
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    detail.Price == price && detail.TaxPercentaje == product.SaleTaxType.Percentaje)
                {
                    detail.Quantity += product.Quantity;
                    detail.Price = price;
                    detail.Total = Math.Round(detail.Quantity * price, 2);
                    detail.SubTotal = Math.Round(detail.Total / (product.SaleTaxType.Percentaje / 100 + 1), 2);
                    detail.TaxPercentaje = product.SaleTaxType.Percentaje;
                    detail.Tax = detail.Total - detail.SubTotal;           
                    return;
                }

            var saleDetail = new SaleDetail
            {
                Sale = this,
                Product = product,
                Quantity = product.Quantity,
                Price = price
            };

            saleDetail.Total = Math.Round(saleDetail.Quantity * saleDetail.Price, 2);
            saleDetail.SubTotal =  Math.Round(saleDetail.Total / (product.SaleTaxType.Percentaje / 100 + 1), 2);
            saleDetail.TaxPercentaje = product.SaleTaxType.Percentaje;
            saleDetail.Tax = saleDetail.Total - saleDetail.SubTotal;  

            if (product.Type == ProductType.Botella)
                saleDetail.IsBottle = true;

            Details.Add(saleDetail);
        }

        public double TotalPriceDetails()
        {
            return (Details.Sum(detail => detail.Total)) - Disscount;
        }

        public void RemoveOneUnit(SaleDetail saleDetail)
        {
            foreach (var detail in Details)
            {
                if (detail.Product.Id != saleDetail.Product.Id || detail.Product.Type != saleDetail.Product.Type ||
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    detail.Product.SalePrice != saleDetail.Product.SalePrice)
                    continue;

                if (detail.Quantity > 1)
                {
                    detail.Quantity -= 1;
                    detail.Total = Math.Round(detail.Quantity * detail.Price, 2);
                    detail.SubTotal = Math.Round(detail.Total / (detail.TaxPercentaje / 100 + 1), 2);
                    detail.TaxPercentaje = detail.TaxPercentaje;
                    detail.Tax = detail.Total - detail.SubTotal;       
                }
                else
                {
                    Details.Remove(detail);
                }

                return;
            }
        }

        public void RemoveAll(SaleDetail saleDetail)
        {
            foreach (var detail in Details)
            {
                if (detail.Product.Id != saleDetail.Product.Id || detail.Product.Type != saleDetail.Product.Type ||
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    detail.Product.SalePrice != saleDetail.Product.SalePrice)
                    continue;

                Details.Remove(detail);
                return;
            }
        }

        public double GetTotalTax()
        {
            return Details.Sum(detail => detail.Tax);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(Sale other)
        {
            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    public enum PayType
    {
        NoPaid = 0,
        Cash = 1,
        CreditCard = 2
    }

    public enum SaleMode
    {
        Day = 0,
        Night = 1
    }
}