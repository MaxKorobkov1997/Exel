using Exel1 = Microsoft.Office.Interop.Excel;

namespace Exel
{
    internal class Exele_Reed (string path)
    {
        public List<Exel_Table> Exel_rid()
        {
            List<Exel_Table> strings = new List<Exel_Table>();
            Exel1.Application exel = new Exel1.Application();

            Exel1.Workbook workbook = exel.Workbooks.Open(path);
            for (int w = 1; w < workbook.Sheets.Count+1; w++)
            {
                Exel1.Worksheet worksheet = workbook.Sheets[w];
                string lis = worksheet.Name;
                Exel1.Range excelRange = worksheet.UsedRange;
                int rows = excelRange.Rows.Count;
                int cols = excelRange.Columns.Count;
                string data, operators,
                    name, status_Nas,
                    probl_Nas, status_Peredat;
                for (int i = 2; i <= rows; i++)
                {
                    data = "Null";
                    operators = "Null";
                    name = "Null";
                    status_Nas = "Null";
                    probl_Nas = "Null";
                    status_Peredat = "Null";
                    //for (int j = 1; j <= cols; j++)
                    //{

                    //write the console
                    if (worksheet.Cells[i, 1].Value != null)
                        data = worksheet.Cells[i, 1].Value.ToString();
                    if (worksheet.Cells[i, 2].Value != null)
                        operators = worksheet.Cells[i, 2].Value.ToString();
                    if (worksheet.Cells[i, 3].Value != null)
                        name = worksheet.Cells[i, 3].Value.ToString();
                    if (worksheet.Cells[i, 4].Value != null)
                        status_Nas = worksheet.Cells[i, 4].Value.ToString();
                    if (worksheet.Cells[i, 5].Value != null)
                        probl_Nas = worksheet.Cells[i, 5].Value.ToString();
                    if (worksheet.Cells[i, 6].Value != null)
                        status_Peredat = worksheet.Cells[i, 6].Value.ToString();
                        var q = new Exel_Table()
                        {
                            Data = data,
                            Operators = operators,
                            Name = name,
                            Status_Nas = status_Nas,
                            Probl_Nas = probl_Nas,
                            Status_Peredat = status_Peredat,
                            Name_Nast = lis,
                        };
                        strings.Add(q);
                    //}
                }
                // Выходим из программы Excel  
                //}
                // Выходим из программы Excel.
            }
            exel.Quit();
            return strings;

        }
    }
}
