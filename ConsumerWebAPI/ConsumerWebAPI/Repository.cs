using ConsumerWebAPI.Interfaces;
using ConsumerWebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ConsumerWebAPI
{
    public class Repository : IRepository
    {
        readonly XContext _xcontext;

        public Repository(XContext xcontext)
        {
            _xcontext = xcontext;
        }

        public bool Delete(int id)
        {
            bool result = false;

            User user = Find(id);

            if (user != null)
            {
                _xcontext.Users.Remove(user);
                _xcontext.SaveChanges();

                result = true;
            }

            return result;
        }

        public User Find(int id)
        {
            return _xcontext.Users.Find(id);
        }

        public User Insert(User user)
        {
            _xcontext.Users.Add(user);
            _xcontext.SaveChanges();
            return user;
        }

        public IEnumerable<User> List()
        {
            return _xcontext.Users.ToList();
        }

        public User Update(User user)
        {
            _xcontext.Users.Update(user);
            _xcontext.SaveChanges();
            return user;
        }
    }
}
