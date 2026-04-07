using Aspose.Cells;
namespace Exel
{
    internal class Exel_Asposs(string path)
    {
        public List<Exel_Table> Otk()
        {
            List<Exel_Table> strings = new List<Exel_Table>();
            string data, operators,
                    name, status_Nas,
                    probl_Nas, status_Peredat, lis;
            Workbook wb = new Workbook(path);

            // Получить все рабочие листы
            WorksheetCollection collection = wb.Worksheets;

    // Перебрать все рабочие листы
            for (int worksheetIndex = 0; worksheetIndex <collection.Count; worksheetIndex++)
            {

                // Получить рабочий лист, используя его индекс
                Worksheet worksheet = collection[worksheetIndex];
                    lis = worksheet.Name;
                    // Печать имени рабочего листа
                    Console.WriteLine("Worksheet: " + worksheet.Name);

                // Получить количество строк и столбцов
                int rows = worksheet.Cells.MaxDataRow;
                    int cols = worksheet.Cells.MaxDataColumn;

                // Цикл по строкам
                for (int i = 1; i<rows; i++)
                {
                    data = "Null";
                    operators = "Null";
                    name = "Null";
                    status_Nas = "Null";
                    probl_Nas = "Null";
                    status_Peredat = "Null";
                    if (worksheet.Cells[i, 0].Value != null)
                        data = worksheet.Cells[i, 0].Value.ToString();
                    if (worksheet.Cells[i, 1].Value != null)
                        operators = worksheet.Cells[i, 1].Value.ToString();
                    if (worksheet.Cells[i, 2].Value != null)
                        name = worksheet.Cells[i, 2].Value.ToString();
                    if (worksheet.Cells[i, 3].Value != null)
                        status_Nas = worksheet.Cells[i, 3].Value.ToString();
                    if (worksheet.Cells[i, 4].Value != null)
                        probl_Nas = worksheet.Cells[i, 4].Value.ToString();
                    if (worksheet.Cells[i, 5].Value != null)
                        status_Peredat = worksheet.Cells[i, 5].Value.ToString();
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
                }
            }
            return strings;
        }
    }
}
