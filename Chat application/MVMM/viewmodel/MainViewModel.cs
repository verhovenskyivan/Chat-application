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
                Username ="Steve",
                UsernameColor = "#409AFF",
                ImageSource = "https://en.wikipedia.org/wiki/File:Steve_Jobs_Headshot_2010-CROP_(cropped_2).jpg",
                Message = "This is text message for application test",
                Time = DateTime.Now,
                isNativeOrigin = false,
                FirstMessage = true,

            });
         

            Messages.Add(new MessageModel
            {
                Username = "Tim",
                UsernameColor = "#409aff",
                ImageSource = "https://en.wikipedia.org/wiki/File:%D0%A2%D0%B8%D0%BC_%D0%9A%D1%83%D0%BA_(02-09-2021).jpg",
                Message = "This is text message for application test",
                Time = DateTime.Now,
                isNativeOrigin = true,

            });

            for (int i=0;i<5;i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Steve{i}",
                    ImageSource = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fru.citaty.net%2Fmedia%2Fauthors%2Fsteve-jobs.jpeg&imgrefurl=https%3A%2F%2Fru.citaty.net%2Favtory%2Fstiv-dzhobs%2F&tbnid=KnUEPXgESMofhM&vet=12ahUKEwjXqcPPnNL4AhXBmYsKHf3wDOsQMygJegUIARDEAQ..i&docid=PaHukj9fURu8dM&w=1557&h=2489&q=steve%20jobs&ved=2ahUKEwjXqcPPnNL4AhXBmYsKHf3wDOsQMygJegUIARDEAQ",
                    Messages = Messages
                });
                    
            }


        }
    }
}
