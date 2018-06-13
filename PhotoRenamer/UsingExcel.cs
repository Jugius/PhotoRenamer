using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;

namespace PhotoRenamer
{
    internal class UsingExcel : IDisposable
    {
        private Excel.Application xlApp = null;
        public event SendMessageHandler SendMessage;

        #region Disposing Logic
        private bool iDisposed = false;
        public void Dispose()
        {
            if (!iDisposed)
            {
                iDisposed = true;
                Release(xlApp);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.SuppressFinalize(this); //говорим сборщику мусора, что наш объект уже освободил ресурсы
            }

        }
        private void Release(object sender)
        {
            try
            {
                if (sender != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(sender);
                    sender = null;
                }
            }
            catch (Exception) { sender = null; }
        }
        #endregion
        public List<PhotoIDItem> ReadExcelFile(string fileName)
        {            
            Excel.Workbook xlWorkBook = null;
            Excel.Worksheet xlWorkSheet = null;
            int lastRow;
            List<PhotoIDItem> itemsList = new List<PhotoIDItem>();

            try
            {
                xlApp = new Excel.Application();
                xlApp.Visible = false;
                xlApp.DisplayAlerts = false;
                xlWorkBook = xlApp.Workbooks.Open(fileName);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Sheets[1];
                lastRow = GetLastRow(xlWorkSheet);

                object valContractor = null;
                object valSupplier = null;

                for (int i = 2; i <= lastRow; i++)
                {
                    valContractor = xlWorkSheet.Range["A" + i].Value;
                    valSupplier = xlWorkSheet.Range["B" + i].Value;
                    if (valContractor != null && valSupplier != null)
                    {
                        string strContractor = valContractor.ToString().Trim();
                        string strSupplier = valSupplier.ToString().ToUpper().Trim();
                        if (strContractor != string.Empty && strSupplier != string.Empty)
                        {
                            itemsList.Add(new PhotoRenamer.PhotoIDItem(strContractor, strSupplier));
                        }
                        else
                        {
                            SendMessage?.Invoke($"Неожиданный конец диапазона в строке {i}. Причина: пустые ячейки");
                            break;
                        }                            
                    }
                    else
                    {
                        SendMessage?.Invoke($"Неожиданный конец диапазона в строке {i}. Причина: пустые ячейки");
                        break;
                    }
                }
                xlWorkBook.Close();
                xlApp.Quit();

                return itemsList;
            }
            catch (Exception ex) { throw ex; }
            finally
            {
                Release(xlWorkSheet);
                Release(xlWorkBook);
                Release(xlApp);
                GC.Collect();
            }

        }
        private static int GetLastRow(Excel.Worksheet sheet)
        {
            if (sheet == null)
                return 0;
            else return sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Row;
        }       
    }
}
