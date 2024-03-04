using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mihaja.Models
{
    public class User
    {
        private int _userId;
        private string _userName;
        private string _userFirstName;
        private DateTime _userBirth;


        private string _userPassword;

        public string MyProperty
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public int UserId   
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }      
        public string UserFirstName
        {
            get { return _userFirstName; }
            set { _userFirstName = value; }
        }
        public DateTime UserBirth
        {
            get { return _userBirth; }
            set { _userBirth = value; }
        }

        public User()
        {
        }

        public User(int userId, string userName, string userFirstName, DateTime userBirth, string userPassword)
        {
            _userId = userId;
            _userName = userName;
            _userFirstName = userFirstName;
            _userBirth = userBirth;
            _userPassword = userPassword;
        }

        public User(string userName, string userFirstName, DateTime userBirth, string userPassword)
        {
            _userName = userName;
            _userFirstName = userFirstName;
            _userBirth = userBirth;
            _userPassword = userPassword;
        }
    }
}