using EducationalCenter_DemoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EducationalCenter_DemoBUS
{
    public class RegistrationBUS
    {
        private static RegistrationBUS _instance = null;
        public static RegistrationBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RegistrationBUS();
                }

                return _instance;
            }
        }

        public static string GetRegistrationID (string _id)
        {
            string result;
            DataTable dt = EducationalCenter_DemoDAO.RegistrationDAO.GetRegistrationID(_id);
            result = dt.Rows[0][0].ToString();
            return result;
        }

        public static List<RegistrationDTO> RegistrationDetail(string _id)
        {
            List<RegistrationDTO> result = new List<RegistrationDTO>();

            DataTable data = EducationalCenter_DemoDAO.RegistrationDAO.RegistrationDetail(_id);

            foreach (DataRow row in data.Rows)
            {
                RegistrationDTO tmp = new RegistrationDTO();
                tmp.IDSub = row["MAMH"].ToString();
                tmp.NameSub = row["TENMONHOC"].ToString();
                tmp.IDClass = row["MALOP"].ToString();
                string tmpdate = row["NGAYBATDAU"].ToString();
                tmp.StartDate = DateTime.Parse(tmpdate);
                tmp.Room = row["PHONGHOC"].ToString();
                tmp.ClassDate = row["LICH_HOC"].ToString();
              

                result.Add(tmp);
            }
            return result;
        }


    }
}
