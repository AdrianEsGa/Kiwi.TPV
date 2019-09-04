using System;
using System.Drawing;
using System.IO;
using Kiwi.Tpv.App.Util;
using Kiwi.Tpv.Database.Controllers;

namespace Kiwi.Tpv.App
{
    public static class UpdateController
    {
        public static void UpdateImages()
        {
            try
            {
                var employees = EmployeeController.GetAll();

                foreach (var employee in employees)
                {
                    if (!string.IsNullOrEmpty(employee.ImagePath))
                    {
                        if (File.Exists(employee.ImagePath))
                        {
                            var image = Image.FromFile(employee.ImagePath);
                            employee.Image = Common.ImageToBytes(image);
                            EmployeeController.SaveOrUpdate(employee);
                        }
                    }
                }

                var products = ProductController.GetAll();

                foreach (var product in products)
                {
                    if (!string.IsNullOrEmpty(product.ImagePath))
                    {
                        if (File.Exists(product.ImagePath))
                        {
                            var image = Image.FromFile(product.ImagePath);
                            product.Image = Common.ImageToBytes(image);
                            ProductController.SaveOrUpdate(product);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                ViewController.ShowError(ex.Message);
            }
        }
        

    }
}
