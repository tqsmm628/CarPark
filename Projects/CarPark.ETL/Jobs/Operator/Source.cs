using System.Threading.Tasks;
using CarPark.ETL.Models.JobData.JobSettings;
using CarPark.ETL.Utilities;

namespace CarPark.ETL.Jobs.Operator {
    public class Source {
        public Task<OperatorJob> Run(OperatorJob job) {
            return Task.FromResult(job);
        }
    }
}