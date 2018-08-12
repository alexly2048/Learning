using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace OperateExcelExample
{
    public class AddIn
    {
        public  void DiaplayInExcel(IEnumerable<Account> accounts, Action<Account, Excel.Range> DisplayFunc)
        {
            var excelApp =new  Excel.Application();
            // Add a new Excel workbook
            excelApp.Workbooks.Add();
            excelApp.Visible = true;
            excelApp.Range["A1"].Value = "ID";
            excelApp.Range["B1"].Value = "Balance";
            excelApp.Range["A2"].Select();

            foreach(var ac in accounts)
            {
                DisplayFunc(ac, excelApp.ActiveCell);
                excelApp.ActiveCell.Offset[1, 0].Select();
            }
            // Copy the results to the Clipboard.
            excelApp.Range["A1:B3"].Copy();

            ((Excel.Range)excelApp.Columns[1]).AutoFit();
            ((Excel.Range)excelApp.Columns[2]).AutoFit();
        }
    }
}
