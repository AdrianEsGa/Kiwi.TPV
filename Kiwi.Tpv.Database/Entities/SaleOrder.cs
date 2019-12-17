using System;
using System.Collections.Generic;

namespace Kiwi.Tpv.Database.Entities
{
    public class SaleOrder
    {
        public int Id { get; set; }
        public Station Station { get; set; }
        public DateTime Date { get; set; }
        public BarTable Table { get; set; }
        public List<SaleOrderDetail> Details { get; set; }
        public double Total => GetTotal() - Disscount;
        public string TotalString => Total.ToString("F");
        public double Disscount { get; set; }
        public PayType PayType { get; set; }
        public Employee Employee { get; set; }
        public bool IsPending { get; set; }
        public string PendingComment { get; set; }

        public SaleOrder()
        {
            Id = 0;
            Details = new List<SaleOrderDetail>();
        }

        public void Add(Product product, SaleMode saleMode, AlcoholModeTypes alcoholModeType)
        {
            var finalPrice = GetFinalPrice(product, saleMode, alcoholModeType);

            foreach (var detail in Details)
                if (detail.Product.Id == product.Id && detail.Product.Type == product.Type &&
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    detail.Price == finalPrice && detail.TaxPercentaje == product.SaleTaxType.Percentaje)
                {
                    detail.Quantity += product.Quantity;
                    detail.Price = finalPrice;
                    return;
                }

            var saleDetail = new SaleOrderDetail
            {
                Product = product,
                Quantity = product.Quantity,
                Price = finalPrice,
                TaxPercentaje = product.SaleTaxType.Percentaje
            };

            if (product.Type == ProductType.Botella)
                saleDetail.IsBottle = true;

            Details.Add(saleDetail);
        }

        public void RemoveOneUnit(SaleOrderDetail saleOrderDetail)
        {
            if (saleOrderDetail.Quantity > 1)
            {
                saleOrderDetail.Quantity -= 1;
            }
            else
            {
                Details.Remove(saleOrderDetail);
            }
        }

        public void AddOneUnit(SaleOrderDetail saleOrderDetail)
        {
            if (!Details.Contains(saleOrderDetail))
            {
                saleOrderDetail.Quantity = 1;
                Details.Add(saleOrderDetail);
            }
            else 
            {
                GetObjectEqualTo(saleOrderDetail).Quantity += 1;
            }       
        }

        private SaleOrderDetail GetObjectEqualTo(SaleOrderDetail target)
        {
            foreach (var detail in Details)
            {
                if (detail.Equals(target)) return detail;
            }

            return null;
        }

        private double GetFinalPrice(Product product, SaleMode saleMode, AlcoholModeTypes alcoholModeType)
        {
            var finalPrice = 0.0;

            switch (product.Type)
            {
                case ProductType.Botella:
                    finalPrice = product.SalePrice;
                    break;
                case ProductType.Alcohol when alcoholModeType != AlcoholModeTypes.Default && alcoholModeType != AlcoholModeTypes.Combined:
                    switch (alcoholModeType)
                    {
                        case AlcoholModeTypes.Cup:
                            finalPrice = saleMode == SaleMode.Day ? product.SaleCupDayPrice : product.SaleCupNightPrice;
                            break;
                        case AlcoholModeTypes.Shot:
                            finalPrice = saleMode == SaleMode.Day ? product.SaleShotDayPrice : product.SaleCupNightPrice;
                            break;
                    }
                    break;

                default:
                    finalPrice = saleMode == SaleMode.Day ? product.SaleDayPrice : product.SaleNightPrice;
                    break;
            }

            return finalPrice;
        }

        private double GetTotal()
        {
            double saleOrderTotal = 0;
            foreach (var detail in Details)
            {
                saleOrderTotal = saleOrderTotal + detail.Total;
            }
            return saleOrderTotal;
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

        public SaleOrder Copy()
        {
           return new SaleOrder()
            {
                Date = Date,
                Disscount = Disscount,
                Employee = Employee,
                PayType = PayType,
                Station = Station,
                Table = Table
            };
        }
    }

}