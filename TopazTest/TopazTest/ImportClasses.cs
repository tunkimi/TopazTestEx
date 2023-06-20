using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopazTest
{
    public class EventLog
    {
        public string eventLogId { get; set; }
        public string operationName { get; set; }
        public Job job { get; set; }
        public int jobId { get; set; }
        public object startTime { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Job
    {
        public string ownerId { get; set; }
        public int id { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public object startTime { get; set; }
        public object endTime { get; set; }
        public object lastModifiedTimestamp { get; set; }
        public string lastModifiedUser { get; set; }
        public string targetEntityReference { get; set; }
        public string realm { get; set; }
        public object parentId { get; set; }
        public List<object> children { get; set; }
    }

    public class Links
    {
        public SELF SELF { get; set; }
    }

    public class Metadata
    {
        public string type { get; set; }
        public string name { get; set; }
        public string nsdId { get; set; }
        public string description { get; set; }
        public List<Parameter> parameters { get; set; }
    }

    public class Output
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public object value { get; set; }
        public object group { get; set; }
    }

    public class Pnf
    {
        public string id { get; set; }
        public string pnfdId { get; set; }
        public string pnfdVersion { get; set; }
        public string pnfdVendor { get; set; }
        public string name { get; set; }
        public List<string> connectionPointIds { get; set; }
        public Links links { get; set; }
        public string nsrId { get; set; }
        public string aggregatedStatus { get; set; }
        public object creationTime { get; set; }
        public object lastModifiedTime { get; set; }
        public string lastModifiedUser { get; set; }
        public List<object> eventLog { get; set; }
    }

    public class Root
    {
        public Links links { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public object vendor { get; set; }
        public string nsdId { get; set; }
        public string nsdVersion { get; set; }
        public string status { get; set; }
        public object priorityIndex { get; set; }
        public string description { get; set; }
        public List<EventLog> eventLog { get; set; }
        public long creationTime { get; set; }
        public long lastModifiedTime { get; set; }
        public string lastModifiedUser { get; set; }
        public object autoScalePolicy { get; set; }
        public object nsdVendor { get; set; }
        public object serviceDeploymentFlavour { get; set; }
        public List<object> connectionPointIds { get; set; }
        public List<Parameter> parameters { get; set; }
        public List<object> vnfs { get; set; }
        public List<Pnf> pnfs { get; set; }
        public List<object> nfps { get; set; }
        public List<Output> outputs { get; set; }
    }

    public class SELF
    {
        public string href { get; set; }
        public string method { get; set; }
    }


}
