using System;
using System.Collections.Generic;

namespace NMUGStore.BusinessLibrary.Shared
{
    public class MeetingDetail
    {
        public int MeetingId { get; set; }
        public DateTime MeetingDateTime { get; set; }
        public string MeetingName { get; set; }

        public List<MeetingDetail> GetMemberDetails()
        {
            return new List<MeetingDetail>
            {
                new MeetingDetail { MeetingName = "Sept"},
                new MeetingDetail { MeetingName = "Oct"},
                new MeetingDetail { MeetingName = "December"}
            };
        }
    }
}
