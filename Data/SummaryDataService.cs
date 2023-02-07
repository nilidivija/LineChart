using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace LineChart.Data
{
    public class SummaryDataService
    {
        public IEnumerable<SummaryData> summaryDatas { get; set; }
        public Task<IEnumerable<SummaryData>> GetSummaryDataAsync()
        {
            string FilePath = "";

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(FilePath);
            string text = xmldoc.DocumentElement.InnerText;
            summaryDatas = JsonConvert.DeserializeObject<IEnumerable<SummaryData>>(text);
            return Task.FromResult(summaryDatas);
        }
    }
}
