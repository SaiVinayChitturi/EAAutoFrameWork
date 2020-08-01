using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace EAAutoFrameWork.Helpers
{
    public class ExcelHelpers
    {

        public static string[] ExcelToData(string fileName)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook workbook = xlApp.Workbooks.Open(fileName);
            Excel.Worksheet worksheet = workbook.Sheets[1];
            Excel.Range xlRange = worksheet.UsedRange;
            string[] credentials = new string[2];
            int k = 0;
            for (int i = 2; i <= xlRange.Rows.Count; i++)
            {
                for (int j = 1; j <= xlRange.Columns.Count; j++)
                {
                    //new line
                    if (j == 1)
                        Console.Write("\r\n");

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                    {
                       
                        credentials[k] = xlRange.Cells[i, j].Value2.ToString();
                        k++;

                    }
                    //Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                   
                    //add useful things here!   
                }
            }
            return credentials;
        }
    }
}
