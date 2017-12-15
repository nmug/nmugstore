
using System;
using NMUGStore.Ui.XamarinForms.Views;
using Xamarin.Forms;
using ExpressMapper;

namespace NMUGStore.Ui.XamarinForms
{
    public partial class App : Application
    {
        public static MeetingManager MeetingManager { get; set; }


        public App()
        {
            InitializeComponent();

            InitializeMappers();

            MeetingManager = new MeetingManager();

            MainPage = new MeetingListPage();
        }

        /// <summary>
        /// One time registratation of Mappers
        /// </summary>
        private void InitializeMappers()
        {
            Mapper.Register<MeetingService.MeetingDetail, Models.MeetingDetail>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
