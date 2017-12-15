using System;
using System.Collections.Generic;

namespace NMUG.WCFHost
{

    public class MeetingService : IMeetingService
    {
        public MeetingDetail GetMeetingDetails(DateTime meetingDateTime)
        {

            switch (meetingDateTime.Date.ToShortDateString())
            {
                case "11/17/2017":
                    return new MeetingDetail { MeetingId = 1, MeetingDateTime = new DateTime(2017, 11, 17), MeetingName = "NMUG September Meeting" };
                case "12/15/2017":
                    return new MeetingDetail { MeetingId = 2, MeetingDateTime = new DateTime(2017, 12, 15), MeetingName = "NMUG December Meeting" };
                default:
                    return new MeetingDetail { MeetingId = 0, MeetingName = "N/A" };
            }
        }

        public List<MeetingDetail> GetMeetings()
        {
            return new List<MeetingDetail>()
            {
                new MeetingDetail { MeetingId = 1, MeetingDateTime = new DateTime(2017, 11, 17), MeetingName = "NMUG September Meeting" },
                new MeetingDetail { MeetingId = 2, MeetingDateTime = new DateTime(2017, 12, 15), MeetingName = "NMUG December Meeting" }
        };
        }
    }
}
