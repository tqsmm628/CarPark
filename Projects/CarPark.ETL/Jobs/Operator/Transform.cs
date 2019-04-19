using System.Threading.Tasks;
using CarPark.ETL.Models.JobData.JobSettings;
using CarPark.ETL.Utilities;

namespace CarPark.ETL.Jobs.Operator {
    public class Transform {
        public Task<CarPark.ETL.Models.Xml.OperatorListXml> Run(OperatorJob job) {
            var xml = XmlUtil.ParseFile<CarPark.ETL.Models.Xml.OperatorListXml>(job.FilePath);
            return Task.FromResult(xml);
        }
    }
}