using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace nowInSession
{
    public partial class historyPage : ContentPage
    {
        public ObservableCollection<Invitation> invitations = new ObservableCollection<Invitation>();
        public historyPage()
        {
            InitializeComponent();

            InvitationListView.ItemsSource = invitations;
            showRecievedInvitation();
        }
        void Click_makeInvitation(object sender, EventArgs e)
        {
            DisplayAlert("開発中", "鋭意開発中、しばらくお待ちください", "OK");
        }
        void Click_recievedList(object sender, EventArgs e)
        {
            //DisplayAlert("開発中", "鋭意開発中、しばらくお待ちください", "OK");
            showRecievedInvitation();
        }
        void Click_sentList(object sender, EventArgs e)
        {
            showSentInvitation();
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
        private void showSentInvitation()
        {
            this.Title = "送信履歴";
            invitations.Clear();
            invitations.Add(new Invitation
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
