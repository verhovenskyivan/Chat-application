using Chat_application.Core;
using Chat_application.MVMM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_application.MVMM.viewmodel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand SendCommand { get; set; }
        public ObservableCollection <MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        private ContactModel _selectedContact;
        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set 
            { 
                _selectedContact = value; 
            OnPropertyChanged();
            }
        }

        public string _message;
        public string Message 
        {
            get { return _message; }
            set 
            { 
                _message = value;
                OnPropertyChanged();
            }                 
        } 

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });
                Message = "";
            });

            Messages.Add(new MessageModel
            {
                Username ="Alison",
                UsernameColor = "#409aff",
                ImageSource = "steve_jobs.jpg",
                Message = "application test",
                Time = DateTime.Now,
                isNativeOrigin = false,
                FirstMessage = true,

            });
         
            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Steve_Jobs",
                    UsernameColor = "#409aff",
                    ImageSource = "steve_jobs.jpg",
                    Message = "application test",
                    Time = DateTime.Now,
                    isNativeOrigin = false,
                    FirstMessage = false,

                });
            }

           

            for (int i=0;i<5;i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Steve_jobs{i}",
                    ImageSource = "steve_jobs.jpg",
                    Messages = Messages
                });
                    
            }


        }
    }
}
