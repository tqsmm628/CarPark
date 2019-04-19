using System;
using System.Xml.Serialization;

namespace CarPark.ETL.Models.Xml {
    [XmlRoot("ParkingOperatorList")]
    public class OperatorListXml {
        public DateTime UpdateTime { get; set; }
        public int UpdateInterval { get; set; }
        public string AuthorityCode { get; set; }

        [XmlArrayItem("Operator")]
        public OperatorXml[] Operators { get; set; }
    }

    public class OperatorXml {
        public string OperatorID { get; set; }
        public NameType OperatorName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string WebURL { get; set; }
        public string LogoURL { get; set; }
        public string TsAndCsURL { get; set; }
        public string BAN { get; set; }
    }

    public class NameType {
        public string Zh_tw { get; set; }
        public string En { get; set; }
        public string Zh_cn { get; set; }
        public string Ja { get; set; }
        public string Ko { get; set; }
    }
}