using System;
using System.IO;

namespace CarPark.ETL.Models.JobData.JobSettings {
    public class OperatorJob {
        public string FilePath { get; set; } = Path.Combine(System.Environment.CurrentDirectory, "Data", "ParkingOperatorList.xml");
    }
}