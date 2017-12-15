using Microsoft.AspNetCore.Mvc;
using NMUGStore.BusinessLibrary.Shared;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NMUG.RestApi.Controllers
{
    [Route("api/[controller]")]
    public class MeetingController : Controller
    {

        MeetingDetail meetingDetail;

        public MeetingController()
        {
            meetingDetail = new MeetingDetail();
        }

        // GET: api/values
        [HttpGet]
        public List<MeetingDetail> Get()
        {
            return meetingDetail.GetMemberDetails();
        }
    }
}