using EducationalCenter_DemoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EducationalCenter_DemoBUS
{
    public class StudentBUS
    {
        /*
         Return:
            - 0: chưa tồn tại
            - 1: đã tồn tại
         */
        public static int CheckExist(StudentDTO newStudent)
        {
            int result = 0;

            try
            {
                DataTable ketqua = EducationalCenter_DemoDAO.StudentDAO.CheckExist(newStudent);

                int amount = int.Parse(ketqua.Rows[0][0].ToString());

                if (amount == 0)
                {
                    result = 0;
                }
                else if (amount > 0)
                {
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            return result;
        }

        /*
        Return:
           - 0: chưa tồn tại
           - 1: đã tồn tại
        */
        public static int CheckExist(StudentDTO newStudent, string program)
        {
            int result = 0;

            try
            {
                DataTable ketqua = EducationalCenter_DemoDAO.StudentDAO.CheckExist(newStudent, program);

                int amount = int.Parse(ketqua.Rows[0][0].ToString());

                if (amount == 0)
                {
                    result = 0;
                }
                else if (amount > 0)
                {
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static void AddStudent(StudentDTO newStudent)
        {
            newStudent.ID = "HV0" + (GetStudentAmount() + 1).ToString();

            try
            {
                EducationalCenter_DemoDAO.StudentDAO.AddStudent(newStudent);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public static int GetStudentAmount()
        {
            int result = 0;

            try
            {
                DataTable ketqua = EducationalCenter_DemoDAO.StudentDAO.GetStudentAmount();
                result = int.Parse(ketqua.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static string GetID(StudentDTO newStudent)
        {
            string result = "";

            try
            {
                DataTable dt = EducationalCenter_DemoDAO.StudentDAO.GetID(newStudent);
                result = dt.Rows[0][0].ToString();
            }
            catch(Exception ex)
            {
                throw (ex);
            }

            return result;
        }
    }
}
