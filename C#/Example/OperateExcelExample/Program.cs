using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace OperateExcelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var bankAccounts = new List<Account>
            {
                new Account
                {
                    ID = 345,
                    Balance = 32.232
                  },
                new Account{
                    ID = 23,
                    Balance = -232.32
                       }
            };

            var dispalyInExcel = new AddIn();
            dispalyInExcel.DiaplayInExcel(bankAccounts, (account, cell) => {
                cell.Value = account.ID;
                cell.Offset[0, 1].Value = account.Balance;
                if (account.Balance < 0)
                {
                    cell.Interior.Color = 255;
                    cell.Offset[0, 1].Interior.Color = 255;
                }
            });
        }
    }


}
