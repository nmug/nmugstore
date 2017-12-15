using System;

namespace NMUG.RestApi.Models
{
    public class MeetingDetail
    {
        public int Id { get; set; }
        public DateTime MeetingDateTime { get; set; }
        public string MeetingName { get; set; }
    }
}
