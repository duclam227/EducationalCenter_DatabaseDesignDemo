using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoBUS
{
    public class ProgramBUS
    {
        private static ProgramBUS _instance = null;
        public static ProgramBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProgramBUS();
                }

                return _instance;
            }
        }

        public static List<ProgramDTO> GetAllPrograms()
        {
            List<ProgramDTO> result = new List<ProgramDTO>();

            try
            {
                DataTable data = EducationalCenter_DemoDAO.ProgramDAO.GetAllPrograms();

                foreach (DataRow row in data.Rows)
                {
                    ProgramDTO tmp = new ProgramDTO();
                    tmp.ID = row["MA_CTDT"].ToString();
                    tmp.Name = row["TEN_CTDT"].ToString();
                    string tmpdate = row["THOIGIAN_KHAIGIANG"].ToString();
                    tmp.StartDate = DateTime.Parse(tmpdate);

                    result.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
        public static List<ProgramDTO> GetAvailablePrograms()
        {
            List<ProgramDTO> result = new List<ProgramDTO>();

            try
            {
                DataTable data = EducationalCenter_DemoDAO.ProgramDAO.GetAllPrograms();

                foreach (DataRow row in data.Rows)
                {
                    ProgramDTO tmp = new ProgramDTO();
                    tmp.ID = row["MA_CTDT"].ToString();
                    tmp.Name = row["TEN_CTDT"].ToString();
                    string tmpdate = row["THOIGIAN_KHAIGIANG"].ToString();
                    tmp.StartDate = DateTime.Parse(tmpdate);

                    if (tmp.StartDate > DateTime.Today)
                    {
                        result.Add(tmp);
                    }

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            

            return result;
        }

        public static void EnrolStudent(StudentDTO newStudent, string program)
        {
            try
            {
                EducationalCenter_DemoDAO.ProgramDAO.EnrolStudent(newStudent, program);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
