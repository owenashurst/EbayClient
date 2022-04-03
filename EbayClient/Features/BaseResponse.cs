using System.Xml.Serialization;

namespace EbayClient.Features
{
    public class BaseResponse
    {
        public DateTime Timestamp { get; set; }

        public string Ack { get; set; }

        [XmlElement(ElementName = "Errors")]
        public List<Error> Errors { get; set; }

        public bool HasErrors
        {
            get
            {
                return this.Errors != null && this.Errors.Count > 0;
            }
        }

        public string Build { get; set; }
    }

    public class Error
    {
        public string ShortMessage { get; set; }

        public string LongMessage { get; set; }

        public int ErrorCode { get; set; }

        public string SeverityCode { get; set; }

        public string ErrorClassification { get; set; }
    }
}