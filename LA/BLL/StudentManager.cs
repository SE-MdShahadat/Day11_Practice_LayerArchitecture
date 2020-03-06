using LA.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA.BLL
{
    public class StudentManager
    {
        StudentRepository studentRepository = new StudentRepository();
        
        public DataTable LoadDepartment()
        {
            return studentRepository.LoadDepartment();
        }
    }
}
