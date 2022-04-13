using System;
using System.Collections.Generic;
using System.Text;
using Utilities;

namespace Models
{
    public class User
    {
        private int _id;

        public User(string username)
        {
            UserName = username;
            _id++;
            Id = _id;
        }

        public int Id { get; set; }
        public List<Status> Statuses = new List<Status>();
        public string UserName { get; set; }

        public void ShareStatus(Status status)
        {
            Statuses.Add(status);
        }

        public Status GetStatusById(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException();
            }
            return Statuses.Find(x => x.Id == id);
        }

        public void GetAllStatuses()
        {
            foreach (var item in Statuses)
            {
                Console.WriteLine(item.GetStatusInfo());
            }
        }

        public List<Status> FilterStatusByDate(DateTime givenDate)
        {
            if (Statuses.Exists(x => x.SharedDate > givenDate))
            {
                return Statuses.FindAll(x=>x.SharedDate > givenDate);
            }
            else
            {
                throw new NotFoundException("Tapilmadi!");
            }
        }


    }
}
