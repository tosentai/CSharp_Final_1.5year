using OfficeOpenXml;
using Final.Core.Context;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Final.Core.Models;

namespace Final.UserInterface
{
    public class ReportGenerator
    {
        private readonly FinalContext _context;

        public ReportGenerator(FinalContext context)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            _context = context;
        }

        public void GenerateReport<T>(string sheetName, string[] columns, Func<IQueryable<T>, IQueryable<object>> selector, string fileName) where T : class
        {
            var data = selector(_context.Set<T>().AsQueryable()).ToList();

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                for (int i = 0; i < columns.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = columns[i];
                }

                for (int i = 0; i < data.Count; i++)
                {
                    var row = data[i];
                    for (int j = 0; j < columns.Length; j++)
                    {
                        var propertyValue = row.GetType().GetProperty(columns[j])?.GetValue(row, null);

                        if (propertyValue != null)
                        {
                            if (propertyValue is DateTime dateTimeValue)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dateTimeValue.ToString("yyyy-MM-dd");
                            }
                            else if (propertyValue is decimal || propertyValue is double || propertyValue is float)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = Convert.ToDecimal(propertyValue);
                                worksheet.Cells[i + 2, j + 1].Style.Numberformat.Format = "#,##0.00";
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1].Value = propertyValue.ToString();
                            }
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1].Value = string.Empty;
                        }
                    }
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files (*.xlsx)|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = saveFileDialog.FileName;
                    File.WriteAllBytes(filePath, package.GetAsByteArray());
                    MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void GenerateUserReport()
        {
            string[] columns = { "Username", "Role", "Status", "DateRegister" };
            GenerateReport<Users>("Users Report", columns, users => users.Select(u => new
            {
                u.Username,
                u.Role,
                u.Status,
                u.DateRegister
            }), "UserReport.xlsx");
        }

        public void GenerateRoomReport()
        {
            string[] columns = { "RoomId", "RoomName", "Type", "Status", "Price", "DateRegister" };
            GenerateReport<Rooms>("Rooms Report", columns, rooms => rooms.Select(r => new
            {
                r.RoomId,
                r.RoomName,
                r.Type,
                r.Status,
                r.Price,
                r.DateRegister
            }), "RoomReport.xlsx");
        }

        public void GenerateCustomerReport()
        {
            string[] columns = { "BookId","FullName", "Email", "Contact", "Status", "RoomID", "DateBook", "Price" };
            GenerateReport<Customers>("Customers Report", columns, customers => customers.Select(c => new
            {
                c.BookId,
                c.FullName,
                c.Email,
                c.Contact,
                c.Status,
                c.RoomID,
                c.DateBook,
                c.Price
            }), "CustomerReport.xlsx");
        }
    }
}
