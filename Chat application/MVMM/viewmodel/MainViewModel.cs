using Chat_application.MVMM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_application.MVMM.viewmodel
{
    internal class MainViewModel
    {
        public ObservableCollection <MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

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
