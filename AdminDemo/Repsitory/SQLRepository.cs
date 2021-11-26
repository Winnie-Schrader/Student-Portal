using AdminDemo.Data;
using AdminDemo.Models;
using AdminDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.Repsitory
{
    public class SQLRepository : IUserRepository
    { 
        private readonly AppDbContext context;
   public SQLRepository(AppDbContext context)
    {
            this.context = context;
            
    }
        //public UsersModel Add(UsersModel users)
        //{
        //    context.Users.Add(users);
        //    context.SaveChanges();
        //    return users;
        //}

        //public UsersModel Delete(int id)
        //{
        //    UsersModel users = context.Users.Find(id);
        //    if(users != null)
        //    {
        //        context.Users.Remove(users);
        //        context.SaveChanges();
        //    }
        //    return users;
        //}

        IEnumerable<TeachersModel> IUserRepository.List()
        {
            return context.Teachers;
        }

        public TeachersModel Details(int Id)
        {
            return context.Teachers.Find(Id);
        }

        //public IEnumerable<UsersModel> GetAllUserModels()
        //{
        //    return context.Users;
        //}

        //public UsersModel GetUsersModel(int id)
        //{
        //    return context.Users.Find(id);
        //}

  

        //public UsersModel Update(RegisterViewModels userChanges)
        //{
        //     var users = context.Users.Attach(userChanges);
        //    users.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    context.SaveChanges();
        //    return userChanges;
        //}

        public TeachersModel Create(TeachersModel model)
        {
            context.Teachers.Add(model);
            context.SaveChanges();
            return model;
        }

     

        public TeachersModel UpdateTeachers(TeachersModel teacherChanges)
        {
            var teachers = context.Teachers.Attach(teacherChanges);
            teachers.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return teacherChanges;
        }

        public UsersModel GetUsersModel(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsersModel> GetAllUserModels()
        {
            throw new NotImplementedException();
        }

        public UsersModel Add(UsersModel users)
        {
            throw new NotImplementedException();
        }

        public UsersModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UsersModel Update(UsersModel userChanges)
        {
            throw new NotImplementedException();
        }
    }
}
