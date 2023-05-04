using NotDefteri.Context;
using NotDefteri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri.Repository
{
    internal class UserRepository
    {
        public UserRepository()
        {
            dbContext = new AppDbContext();
        }
        AppDbContext dbContext;

        public User GetById(int id)
        {
            User user = dbContext.Users.Find(id);
            return user;
        }

        public List<User> GetAll()
        {
            return dbContext.Users.Where(a=>a.UserType == Enums.UserType.Standart).ToList();
        }
        public User GetByUserName(string name)
        {
            return dbContext.Users.FirstOrDefault(a=>a.UserName == name);
        }

        public bool Add(User user)
        {
            dbContext.Users.Add(user);
            return dbContext.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            User user = GetById(id);
            dbContext.Users.Remove(user);
            return dbContext.SaveChanges() > 0;
        }
        public bool Update(User user)
        {
            dbContext.Users.Update(user);   //Database de veri yok ise gider ekler, var ise gunceller 
            return dbContext.SaveChanges() > 0;
        }
    }
}
