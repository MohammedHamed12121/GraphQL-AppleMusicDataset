using CsvHelper.Configuration;
using System.Globalization;

namespace appleMusic;
public class CsvReader
{
    public List<T> Read<T>(string filePath)
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = true
        };

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvHelper.CsvReader(reader, csvConfig))
        {
            var list = csv.GetRecords<T>().ToList();
            return list;
        }
    }
}
