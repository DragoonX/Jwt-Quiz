using ConsumerWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerWebAPI.Interfaces
{
    public interface IRepository
    {
        IEnumerable<User> List();
        User Find(int id);
        User Insert(User user);
        User Update(User user);
        bool Delete(int id);
    }
}
