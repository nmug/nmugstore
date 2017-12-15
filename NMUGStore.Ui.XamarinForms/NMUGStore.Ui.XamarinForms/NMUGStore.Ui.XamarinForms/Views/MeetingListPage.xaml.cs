using System;
using Xamarin.Forms;

namespace NMUGStore.Ui.XamarinForms.Views
{
    public partial class MeetingListPage : ContentPage
    {
        public MeetingListPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await  App.MeetingManager.GetMeetingDetailsAsync();

            //listView.ItemsSource = await App.MeetingManager.GetMeetingDetailsFromRestApiAsync();
        }

        void OnAddItemClicked (object sender, EventArgs e)
        {

        }

        void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
        {


        }

    }
}