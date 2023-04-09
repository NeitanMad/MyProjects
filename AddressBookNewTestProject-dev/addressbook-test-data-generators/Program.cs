using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBookNewTestProject;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Excel = Microsoft.Office.Interop.Excel;

namespace addressbook_test_data_generators
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(args[0]);
            StreamWriter sw = new StreamWriter(args[1]);
            for (int i = 0; i < count; i++)
            {
                sw.WriteLine(string.Format("${0}, ${1}, ${2}",
                    TestBase.GenerateRandomString(10),
                    TestBase.GenerateRandomString(10),
                    TestBase.GenerateRandomString(10)));
            }
            sw.Close();
            


            //    Console.Write("Колличество строк: ");
            //    int count = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Формат файла: ");
            //    string format = Console.ReadLine();

            //    Console.Write("Путь файла: ");
            //    string path = Console.ReadLine();


            //    List<GroupData> groups = new List<GroupData>();
            //    for (int i = 0; i < count; i++)
            //    {
            //        groups.Add(new GroupData(TestBase.GenerateRandomString(10))
            //        {
            //            Header = TestBase.GenerateRandomString(100),
            //            Footer = TestBase.GenerateRandomString(100),
            //        });
            //    }

            //    if (format == "excel")
            //    {
            //        WriteGroupsToEXCELFile(groups, path);
            //    }
            //    else
            //    {
            //        StreamWriter writer = new StreamWriter(path);

            //        if (format == "csv")
            //        {
            //            WriteGroupsToCSVFile(groups, writer);
            //        }
            //        else if (format == "xml")
            //        {
            //            WriteroupsToXMLFile(groups, writer);
            //        }
            //        else if (format == "json")
            //        {
            //            WriteroupsToJSONFile(groups, writer);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Unrecognized format " + format);// 
            //        }

            //        writer.Close();
            //    }

            //}

            //private static void WriteGroupsToEXCELFile(List<GroupData> groups, string path)
            //{
            //    Excel.Application app = new Excel.Application();
            //    app.Visible = true;
            //    Excel.Workbook wb = app.Workbooks.Add();
            //    Excel.Worksheet sheet = wb.ActiveSheet;
            //    sheet.Cells[1, 1] = "test";


            //    // Лекция 6.4 08:15 To Be Continue...
            //}

            //public static void WriteGroupsToCSVFile(List<GroupData> groups, StreamWriter writer)
            //{
            //    foreach (GroupData group in groups)
            //    {
            //        writer.WriteLine(string.Format("${0}, ${1}, ${2}",
            //            group.Name, group.Header, group.Footer));
            //    }
            //}

            //public static void WriteroupsToXMLFile(List<GroupData> groups, StreamWriter writer)
            //{
            //    new XmlSerializer(typeof(List<GroupData>)).Serialize(writer, groups);
            //}

            //public static void WriteroupsToJSONFile(List<GroupData> groups, StreamWriter writer)
            //{
            //    writer.Write(JsonConvert.SerializeObject(groups, Newtonsoft.Json.Formatting.Indented));
            //}
        }
    }
}
