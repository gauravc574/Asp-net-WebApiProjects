using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIDemoForCRUD.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public int GetAllStudents() {
            //IList<StudentViewModel> students = null;

            //using (var ctx = new SchoolDBEntities())
            //{
            //    students = ctx.Students.Include("StudentAddress").Select(s => new StudentViewModel()
            //    {
            //        Id = s.StudentID,
            //        StudentName = s.StudentName,
            //        Address = s.StudentAddress == null || includeAddress == false ? null : new AddressViewModel()
            //        {
            //            StudentId = s.StudentAddress.StudentID,
            //            Address1 = s.StudentAddress.Address1,
            //            Address2 = s.StudentAddress.Address2,
            //            City = s.StudentAddress.City,
            //            State = s.StudentAddress.State
            //        }
            //    }).ToList<StudentViewModel>();
            //}

            //if (students == null)
            //{
            //    return NotFound();
            //}

            //return Ok(students);

            return 0;
        }
    }
}
