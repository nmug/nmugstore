using ExpressMapper.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NMUGStore.Ui.XamarinForms
{
    public class MeetingManager
    {
        MeetingService.IMeetingService meetingService;
        HttpClient client;

        public List<Models.MeetingDetail> MeetingDetails { get; private set; }

        public MeetingManager()
        {

            meetingService = new MeetingService.MeetingServiceClient(
                new BasicHttpBinding(),
                new EndpointAddress(Helpers.Settings.WCFHostUrl));

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

            //var authData = string.Format("{0}:{1}", "Username", "Password");
            //var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
        }

        public async Task<List<Models.MeetingDetail>> GetMeetingDetailsAsync()
        {
            MeetingDetails = new List<Models.MeetingDetail>();

            try
            {
                var meetingdetails = await Task.Factory.FromAsync<ObservableCollection<MeetingService.MeetingDetail>>(meetingService.BeginGetMeetings, meetingService.EndGetMeetings, null, TaskCreationOptions.None);

                MeetingDetails = meetingdetails.Map<ObservableCollection<MeetingService.MeetingDetail>, List<Models.MeetingDetail>>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"Erorr {0}", ex.Message);
            }

            return MeetingDetails;
        }


        public async Task<List<Models.MeetingDetail>> GetMeetingDetailsFromRestApiAsync()
        {
            MeetingDetails = new List<Models.MeetingDetail>();

            var uri = new Uri(string.Format("http://192.168.10.167/NMUG.RestApi/api/meeting", string.Empty));

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    MeetingDetails = JsonConvert.DeserializeObject<List<Models.MeetingDetail>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }


            return MeetingDetails;
        }


    }
}
