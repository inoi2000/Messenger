using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TopMessenger.Infrastructure.Services;
using TopMessenger.Models;
using TopMessenger.ViewModels.Commands;
using TopMessenger.Views;

namespace TopMessenger.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Commands
        public ActionCommand WindowMinimizeCommand => new ActionCommand(x => WindowMinimize());
        public ActionCommand WindowMaximizeCommand => new ActionCommand(x => WindowMaximize());
        public ActionCommand AppCloseCommand => new ActionCommand(x=> Application.Current.Shutdown());
        public ActionCommand SendMessageCommand => new ActionCommand(x => MessageBox.Show(NewText));
        #endregion

        #region Property
        private string newText;
        public string NewText
        {
            get => newText;
            set
            {
                newText = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<User> friends;
        public ObservableCollection<User> Friends
        {
            get => friends;
            set
            {
                friends = value;
                OnPropertyChanged();
            }
        }

        private User mainUserTemp;
        private event Action Chat;
        private User selectedFriend;
        public User SelectedFriend
        {
            get => selectedFriend;
            set
            {
                selectedFriend = value;
                Chat();
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Message> chatWithUser;
        public ObservableCollection<Message> ChatWithUser
        {
            get => chatWithUser;
            set
            {
                chatWithUser = value;
                OnPropertyChanged();
            }
        }
        #endregion
        private UserService userService;
        public MainViewModel()
        {
            Chat += ChatWU;
            //new RegistrationWindow().ShowDialog();
            LoadMeth().GetAwaiter();
        }

        private async void ChatWU()
        {
            ChatWithUser = await userService.GetMessageWithUser(mainUserTemp, SelectedFriend);
        }

        private async Task LoadMeth()
        {
            #region
            //var user1 = new User
            //{
            //    FirstName = "first"
            //};
            //var user2 = new User
            //{
            //    FirstName = "Second"
            //};

            //var user3 = new User
            //{
            //    FirstName = "third"
            //};
            #endregion
            userService = new UserService();

            mainUserTemp = await userService.GetUser(1);

            //await userService.AddPhotoSource(await userService.GetUser(1));
            
            ObservableCollection<User> tempUsers = await userService.GetFriendList(await userService.GetUser(1));
            foreach (var item in tempUsers)
            {
                var tempMessages = await userService.GetMessageWithUser(mainUserTemp, item);
                item.LastMessage = tempMessages.LastOrDefault()?.Text;
            }
            Friends = tempUsers;

            #region
            //ChatWithUser = await userService.GetMessageWithUser(await userService.GetUser(2), await userService.GetUser(1));
            //Message mes3 = new Message
            //{
            //    Text = "AsdasdasdText44",
            //    Sender = await userService.GetUser(1),
            //    Receiver = await userService.GetUser(2)
            //};
            //await userService.SendMessage(mes3);

            //Message mes4 = new Message
            //{
            //    Text = "AsdasdasdText44",
            //    Sender = await userService.GetUser(3),
            //    Receiver = await userService.GetUser(2)
            //};
            //await userService.SendMessage(mes4);

            //var res = await userService.GetMessageWithUser(await userService.GetUser(1), await userService.GetUser(2));
            //string text = "";
            //foreach (var item in res)
            //{
            //    text += item.Text + Environment.NewLine;
            //}
            //MessageBox.Show(text);

            //await userService.AddNewUser(user1);
            //await userService.AddNewUser(user3);
            //await userService.AddNewFriend(await userService.GetUser(1), await userService.GetUser(3));
            //await userService.GetUser(2);
            #endregion
        }


        private void WindowMaximize()
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void WindowMinimize()
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }



        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if(PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
