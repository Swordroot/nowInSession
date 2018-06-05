using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class HistoryPage : ContentPage
    {
        public ObservableCollection<Invitation> invitations = new ObservableCollection<Invitation>();
        public ObservableCollection<Invitation> sentInvitations = new ObservableCollection<Invitation>();
        public HistoryPage()
        {
            InitializeComponent();

            InvitationListView.ItemsSource = invitations;
            showRecievedInvitation();
        }
        void Click_makeInvitation(object sender, EventArgs e)
        {
            Navigation.PushAsync(new createInvitationPage(), true);
        }
        void ItemTapped_HistoryList(object sender, ItemTappedEventArgs e)
        {
            Invitation selectedInvitation = (Invitation)(e.Item);
            Navigation.PushAsync(new DetailInvitationPage(selectedInvitation));
        }
        private void showRecievedInvitation()
        {
            this.Title = "受信履歴";
            invitations.Clear();
            invitations.Add(new Invitation
            {
                userId = 1,
                userName = "user1",
                displayName = "ユーザー１",
                restaurantName = "レストラン１",
                restaurantURL = "https://www.restaurant1.com",
                comment = "みんなきてね"
            });
            invitations.Add(new Invitation
            {
                userId = 2,
                userName = "user2",
                displayName = "ユーザー２",
                restaurantName = "レストラン２",
                restaurantURL = "https://www.restaurant2.com",
                comment = "みんなきてね"
            });
            invitations.Add(new Invitation
            {
                userId = 3,
                userName = "user3",
                displayName = "ユーザー３",
                restaurantName = "レストラン３",
                restaurantURL = "https://www.restaurant3.com",
                comment = "みんなきてね"
            });
        }


    }
}
