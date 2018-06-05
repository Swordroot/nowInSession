using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class SentHistoryPage : ContentPage
    {
        public ObservableCollection<Invitation> sentInvitations = new ObservableCollection<Invitation>();
        public SentHistoryPage()
        {
            InitializeComponent();

            sentInvitationListView.ItemsSource = sentInvitations;
            showSentInvitation();
        }
        void Click_makeInvitation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new createInvitationPage(), true);
        }
        void ItemTapped_SentHistoryList(object sender, ItemTappedEventArgs e)
        {
            Invitation selectedInvitation = (Invitation)(e.Item);
            Navigation.PushAsync(new DetailInvitationForSenderPage(selectedInvitation));
        }
        private void showSentInvitation()
        {
            sentInvitations.Clear();
            sentInvitations.Add(new Invitation
            {
                userId = 4,
                userName = "user4",
                displayName = "わたし",
                restaurantName = "レストラン１",
                restaurantURL = "https://www.restaurant1.com",
                comment = "みんなこいや"
            });

        }
    }
}
