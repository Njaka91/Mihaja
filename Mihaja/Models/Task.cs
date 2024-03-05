using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mihaja.Models
{
    public class Task
    {
        private int _id;
        private string _taskName;
        private string _taskUser;
        private Boolean _taskStatement;

        public int TaskId
        {
            get { return _id; }
            set { _id = value; }
        }
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; }
        }
        public string TaskUser
        {
            get { return _taskUser; }
            set { _taskUser = value; }
        }
        public Boolean TaskStatement
        {
            get { return _taskStatement; }
            set { _taskStatement = value; }
        }

        public Task()
        {
        }

        public Task(int id, string taskName, string taskUser, bool taskStatement)
        {
            _id = id;
            _taskName = taskName;
            _taskUser = taskUser;
            _taskStatement = taskStatement;
        }

        public Task(string taskName, string taskUser, bool taskStatement)
        {
            _taskName = taskName;
            _taskUser = taskUser;
            _taskStatement = taskStatement;
        }
    }
}