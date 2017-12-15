using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace NMUG.WCFHost
{
    [ServiceContract]
    public interface IMeetingService
    {

        [OperationContract]
        MeetingDetail GetMeetingDetails(DateTime meetingDateTime);

        [OperationContract]
        List<MeetingDetail> GetMeetings();

    }
}