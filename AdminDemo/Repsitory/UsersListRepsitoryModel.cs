using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDemo.Models
{
    public class UsersListRepsitoryModel : IUserRepository
    {
        private readonly List<UsersModel> _usersList;

        private readonly List<TeachersModel> _teachers;
        public UsersListRepsitoryModel()
        {
            _usersList = new List<UsersModel>()
            {
                new UsersModel() { Id =1,UserName="NULL", Department=Department.DCST, Email="NULL",Gender=Genders.Others,StudentID="NULL",Password="NULLLSSS12S",ConfirmPassword="NULLLSSS12S"}
            };
            _teachers = new List<TeachersModel>()
            {
                new TeachersModel() {TeacherId= 1 , TeacherName="NULL", TeacherDept="NULL", TeacherDesignation="NULL", TeacherQualification="NULL"}
            };
        }

        public UsersModel Add(UsersModel users)
        {
           users.Id = _usersList.Max(e => e.Id) + 1;
            _usersList.Add(users);
            return users;
        }

        public TeachersModel Create(TeachersModel model)
        {
            model.TeacherId= _teachers.Max(e => e.TeacherId) + 1;
            _teachers.Add(model);
            return model;
        }

        public UsersModel Delete(int id)
        {

           UsersModel users= _usersList.FirstOrDefault(e=> e.Id == id);
            if (users != null)
            {
                _usersList.Remove(users);
            }
            return users;
        }

        public TeachersModel Details(int Id)
        {
            return _teachers.FirstOrDefault(e => e.TeacherId == Id);
        }

     

     

        public IEnumerable<UsersModel> GetAllUserModels()
        {
            return _usersList;
        }

        public UsersModel GetUsersModel(int Id)
        {
            return _usersList.FirstOrDefault(e => e.Id == Id); 
        }

  

        public UsersModel Update(UsersModel userChanges)
        {

            UsersModel users = _usersList.FirstOrDefault(e => e.Id == userChanges.Id);
            if (users != null)
            {
                users.UserName = userChanges.UserName;
                users.Email = userChanges.Email;
                users.Department = userChanges.Department;
                users.Gender = userChanges.Gender;
            }
            return users;
        }

        public TeachersModel UpdateTeachers(TeachersModel teacherChanges)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TeachersModel> IUserRepository.List()
        {
            return _teachers;
        }
    }
}
