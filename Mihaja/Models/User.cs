﻿using System;
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

        public string UserPassword

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

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   _userId == user._userId &&
                   _userName == user._userName &&
                   _userFirstName == user._userFirstName &&
                   _userBirth == user._userBirth &&
                   _userPassword == user._userPassword;
        }

        public override int GetHashCode()
        {
            int hashCode = -726363046;
            hashCode = hashCode * -1521134295 + _userId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_userName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_userFirstName);
            hashCode = hashCode * -1521134295 + _userBirth.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_userPassword);
            return hashCode;
        }

    }
}