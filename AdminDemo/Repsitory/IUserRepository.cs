using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.Models
{
    public interface IUserRepository
    {
        UsersModel GetUsersModel(int Id);
        IEnumerable<UsersModel> GetAllUserModels();
        UsersModel Add(UsersModel users);
        UsersModel Delete(int id);
        UsersModel Update(UsersModel userChanges);

        TeachersModel Details(int Id);
        IEnumerable<TeachersModel> List();
        TeachersModel Create(TeachersModel model);

        TeachersModel UpdateTeachers(TeachersModel teacherChanges);


    }
}
