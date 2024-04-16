using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Xml.Linq;

namespace M03UF5AC3
{
    public class Helper
    {
        public static void CsvToXml(string csvPath, string xmlPath)
        {
            const string FileAlreadyExistsMsg = "El fitxer ja existeix i conté informació";
            if (File.Exists(xmlPath))
            {
                XDocument doc = XDocument.Load(xmlPath);
                if (doc.Root == null)
                {
                    SaveDataToXml(GetDataFromCsv(csvPath), xmlPath);
                }
                else
                {
                    Console.WriteLine(FileAlreadyExistsMsg);
                }
            }
            else
            {
                SaveDataToXml(GetDataFromCsv(csvPath), xmlPath);
            }
        }
        public static List<Consum> GetDataFromCsv(string csvPath)
        {
            using var reader = new StreamReader(csvPath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Consum>().ToList();
        }
        public static void SaveDataToXml(List<Consum> infoComarcas, string xmlPath)
        {
            const string SuccessMsg = "Dades emmagatzemades correctament";
            const string ErrorMsg = "Error: {0}";
            try
            {
                XDocument doc;

                if (File.Exists(xmlPath))
                {
                    doc = XDocument.Load(xmlPath);

                    if (doc.Root == null)
                    {
                        doc.Add(new XElement("Comarcas"));
                    }
                }
                else
                {
                    doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XElement("Comarcas"));
                }
                foreach (Consum infoComarca in infoComarcas)
                {
                    XElement comarca =
                        new XElement("Comarca",
                        new XElement("Any", infoComarca.Any),
                        new XElement("CodiComarca", infoComarca.CodiComarca),
                        new XElement("NomComarca", infoComarca.Comarca),
                        new XElement("Poblacio", infoComarca.Poblacio),
                        new XElement("DomesticXarxa", infoComarca.DomesticXarxa),
                        new XElement("ActivitatsEconomiques", infoComarca.ActivitatsEconomiques),
                        new XElement("Total", infoComarca.Total),
                        new XElement("ConsumDomesticPerCapita", infoComarca.ConsumDomesticPerCapita));
                    doc.Root.Add(comarca);
                }
                doc.Save(xmlPath);
                Console.WriteLine();
                Console.WriteLine(SuccessMsg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ErrorMsg, ex.Message);
            }
        }
        public static List<string> GetComarquesXML()
        {
            XDocument doc = XDocument.Load("../../../files/Consum.xml");
            return doc.Descendants("Comarca").Select(x => x.Element("NomComarca").Value).Distinct().ToList();
        }
        public static int GetCodiComarcaXML(string comarca)
        {
            XDocument doc = XDocument.Load("../../../files/Consum.xml");
            foreach (XElement element in doc.Descendants("Comarca"))
            {
                if (element.Element("NomComarca").Value == comarca)
                {
                    return int.Parse(element.Element("CodiComarca").Value);
                }
            }
            return -1;
        }
        public static void AddConsumToCsv(Consum consum, string csvPath)
        {
            using (var writer = new StreamWriter(csvPath, true))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    writer.WriteLine();
                    csv.WriteRecord(consum);
                }
            }
        }
        public static bool IsHighestDomCons(double cons)
        {
            List<Consum> consums = GetDataFromCsv("../../../files/Consum.csv");
            double highestCons = consums.Max(x => x.ConsumDomesticPerCapita);
            return cons == highestCons;
        }
        public static bool IsLowestDomCons(double cons)
        {
            List<Consum> consums = GetDataFromCsv("../../../files/Consum.csv");
            double lowestCons = consums.Min(x => x.ConsumDomesticPerCapita);
            return cons == lowestCons;
        }
    }
}
