using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using OfficeOpenXml;
using System.Text;
using Stock.ExchangeAPI.Entities;



namespace EPPlusCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Stock")]
    public class ExcelController : Controller
    {
        //private readonly IHostingEnvironment _hostingEnvironment;
        StockDBContext _db = new StockDBContext();

        //public StockController(IHostingEnvironment hostingEnvironment, StockMarketDBContext db)
        //{
        //    //_hostingEnvironment = hostingEnvironment;
        //    //_db = db;
        //}


        [HttpGet]
        [Route("ImportStock/{*filePath}")]
        public IList<Price> ImportStock(string filename)
        {
           
            {
                string filePath = @"C:\" + filename;

                //  string rootFolder = _hostingEnvironment.WebRootPath;
                // string fileName = @"ImportCustomers.xlsx";
                //  FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

                FileInfo file = new FileInfo(filePath);
                string fileName = file.Name;
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(file))
                {
                   
                    ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];
                    int totalRows = workSheet.Dimension.Rows;

                    List<Price> stockPrices = new List<Price>();

                    for (int i = 2; i <= totalRows; i++)
                    {
                        stockPrices.Add(new Price
                        {
                            CompanyCode = workSheet.Cells[i, 1].Value.ToString().Trim(),
                            StockExchange = workSheet.Cells[i, 2].Value.ToString().Trim(),
                            Pricestock = double.Parse(workSheet.Cells[i, 3].Value.ToString().Trim()),
                            DateAdded = DateTime.Parse(workSheet.Cells[i, 4].Value.ToString().Trim()),
                            //Time = workSheet.Cells[i, 5].Value.ToString(),
                        });
                    }

                    _db.StockPrices.AddRange(stockPrices);
                    _db.SaveChanges();

                    return stockPrices;
                }
                 }

          

        }

      //  [HttpGet]
        //    [Route("ExportCustomer")]
          //  string ExportCustomer()
           // {
                //string rootFolder = _hostingEnvironment.WebRootPath;
                //string fileName = @"ExportCustomers.xlsx";

                //FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

                //using (ExcelPackage package = new ExcelPackage(file))
                //{

                //    IList<Customers> customerList = _db.Customers.ToList();

                //    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Customer");
                //    int totalRows = customerList.Count();

                //    worksheet.Cells[1, 1].Value = "Customer ID";
                //    worksheet.Cells[1, 2].Value = "Customer Name";
                //    worksheet.Cells[1, 3].Value = "Customer Email";
                //    worksheet.Cells[1, 4].Value = "customer Country";
                //    int i = 0;
                //    for (int row = 2; row <= totalRows + 1; row++)
                //    {
                //        worksheet.Cells[row, 1].Value = customerList[i].CustomerId;
                //        worksheet.Cells[row, 2].Value = customerList[i].CustomerName;
                //        worksheet.Cells[row, 3].Value = customerList[i].CustomerEmail;
                //        worksheet.Cells[row, 4].Value = customerList[i].CustomerCountry;
                //        i++;
                //    }

                //    package.Save(); 

                //}

           //     return " Customer list has been exported successfully";
            //}


        }
    } 