using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoBUS
{
    public class SubjectBUS
    {

        public static List<SubjectDTO> GetAllSubjects()
        {
            List<SubjectDTO> result = new List<SubjectDTO>();

            try
            {
                DataTable data = EducationalCenter_DemoDAO.SubjectDAO.GetAllSubjects();
                foreach (DataRow row in data.Rows)
                {
                    SubjectDTO tmp = new SubjectDTO();
                    tmp.IDSub = row["MAMH"].ToString();
                    tmp.NameSub = row["TENMONHOC"].ToString();

                    result.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
