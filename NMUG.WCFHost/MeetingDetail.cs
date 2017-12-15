using System;
using System.Runtime.Serialization;

namespace NMUG.WCFHost
{
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class MeetingDetail
    {
        int meetingId;
        string meetingName;
        DateTime meetingDateTime = new DateTime();

        [DataMember]
        public int MeetingId
        {
            get { return meetingId; }
            set { meetingId = value; }
        }
        
        [DataMember]
        public DateTime MeetingDateTime
        {
            get { return meetingDateTime; }
            set { meetingDateTime = value; }
        }
        
        [DataMember]
        public string MeetingName
        {
            get { return meetingName; }
            set { meetingName = value; }
        }
    }
}