﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMessenger.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Photo { get; set; }
        public ICollection<FriendList> FriendLists { get; set; }
        public ICollection<Message> Messages { get; set; }

        [NotMapped]
        public string LastMessage { get; set; }
        [NotMapped]
        public bool IsMain { get; set; }
        //[NotMapped]
        //public bool IsFriend { get; set; }
    }
}
