using System.Collections.Generic;

namespace NMUGStore.Dal
{
    public interface IMeetingDao
    {
        List<MeetingDto> GetMeetings();
    }
}
