using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminDemo.Data;
using AdminDemo.Models;
using AdminDemo.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace AdminDemo.Controllers
{
    [Authorize]
    public class TeachersController : Controller
    {
        private readonly IUserRepository _userRepository;

        private readonly AppDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;

        public TeachersController(AppDbContext context, IWebHostEnvironment hostingEnvironment, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Teachers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teachers.ToListAsync());
        }

        // GET: Teachers/Details/5
        public IActionResult Details(int? id)
        {
            TeachersModel teachers = _userRepository.Details(id.Value);
            if(teachers == null)
            {
                Response.StatusCode = 404;
                return View("ID Not Found", id.Value);
            }
            TeacherViewModel teacher = new TeacherViewModel
            {
                Teachers = teachers
            };
            return View(teacher);
        }

        // GET: Teachers/Create
        [HttpGet]
        //[Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize]
        public IActionResult Create(AddTeacherViewModel teachersModel)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(teachersModel);
               
                TeachersModel newTeachers = new TeachersModel
                {
                    TeacherName = teachersModel.TeacherName,
                    TeacherDept = teachersModel.TeacherDept,
                    TeacherDesignation = teachersModel.TeacherDesignation,
                    TeacherQualification = teachersModel.TeacherQualification,
                    PhotoPath= uniqueFileName
                   
                };
                _userRepository.Create(newTeachers);
                return RedirectToAction("Details", new {id = newTeachers.TeacherId });

            }
            return View();
        }



        // GET: Teachers/Edit/id
        [HttpGet]
        //[Authorize]
        public IActionResult Edit(int id)
        { 
              TeachersModel teachers = _userRepository.Details(id);

            EditTeachersViewModel editTeachersViewModel = new EditTeachersViewModel
            {
                Id = teachers.TeacherId,
                TeacherName= teachers.TeacherName,
                TeacherDept = teachers.TeacherDept,
                TeacherDesignation= teachers.TeacherDesignation,
                TeacherQualification= teachers.TeacherQualification,
                ExistingPhotoPath=teachers.PhotoPath

            };
            return View(editTeachersViewModel);
        }


        // POST: Teachers/Edit/id
        [HttpPost]
        //[Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditTeachersViewModel teachersModel)
        {
            if (ModelState.IsValid)
            {
                TeachersModel teachers = _userRepository.Details(teachersModel.Id);
                teachers.TeacherName = teachersModel.TeacherName;
                teachers.TeacherDept = teachersModel.TeacherDept;
                teachers.TeacherDesignation = teachersModel.TeacherDesignation;
                teachers.TeacherQualification = teachersModel.TeacherQualification;
                if(teachersModel.Photo != null)
                {
                    if(teachersModel.ExistingPhotoPath != null)
                    {
                      string filePath = Path.Combine(_hostingEnvironment.WebRootPath, 
                          "images", teachersModel.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                    teachers.PhotoPath = ProcessUploadedFile(teachersModel);
                }
             
                _userRepository.UpdateTeachers(teachers);
                return RedirectToAction("Index");

            }
            return View();
        }

        private string ProcessUploadedFile(AddTeacherViewModel teachersModel)
        {
            string uniqueFileName = null;
            if (teachersModel.Photo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + teachersModel.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                teachersModel.Photo.CopyTo(fileStream);
            }

            return uniqueFileName;
        }


        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("TeacherId,TeacherName,TeacherDept,TeacherDesignation,TeacherQualification,PhotoPath")] TeachersModel teachersModel)
        //{
        //    if (id != teachersModel.TeacherId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(teachersModel);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TeachersModelExists(teachersModel.TeacherId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(teachersModel);
        //}

        // GET: Teachers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachersModel = await _context.Teachers
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (teachersModel == null)
            {
                return NotFound();
            }

            return View(teachersModel);
        }

        // POST: Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teachersModel = await _context.Teachers.FindAsync(id);
            if (teachersModel.PhotoPath != null)
            {
                    string delfilePath = Path.Combine(_hostingEnvironment.WebRootPath,
                        "images", teachersModel.PhotoPath);
                    System.IO.File.Delete(delfilePath);
                }
                _context.Teachers.Remove(teachersModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeachersModelExists(int id)
        {
            return _context.Teachers.Any(e => e.TeacherId == id);
        }
    }
}
