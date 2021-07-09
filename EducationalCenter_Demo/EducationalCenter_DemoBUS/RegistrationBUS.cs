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
            DateTime EnrollDate;
            //DateTime StartDate = DateTime.Parse("08/08/2021");
            //DateTime Today = DateTime.Today;
            //DateTime EndDate = DateTime.Parse("15/08/2021") ;
            string tmp;

            DataTable dt = EducationalCenter_DemoDAO.RegistrationDAO.GetRegistrationID(_id);
            result = dt.Rows[0][0].ToString();
            tmp = dt.Rows[0][1].ToString();
            EnrollDate = DateTime.Parse(tmp);

            if (EnrollDate.Year < 2021)
                result = null;
            
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

        public static int GetRegisAmount()
        {
            int result = 0;

            DataTable ketqua = EducationalCenter_DemoDAO.RegistrationDAO.GetRegisAmount();
            result = int.Parse(ketqua.Rows[0][0].ToString());

            return result;
        }

        public static string CreateRegis(string _studentID)
        {
            string _regisID;
            int Amount = EducationalCenter_DemoBUS.RegistrationBUS.GetRegisAmount();
            
            if (Amount + 1 < 10)
                _regisID = "PDK0" + (Amount + 1).ToString();
            else
                _regisID = "PDK" + (Amount + 1).ToString();

            EducationalCenter_DemoDAO.RegistrationDAO.CreateRegis(_regisID, _studentID);
            return _regisID;
        }

        public static int CheckRegisClass (string _regisID, string _classID)
        {
            int result = 0;

            DataTable ketqua = EducationalCenter_DemoDAO.RegistrationDAO.CheckRegisClass(_regisID, _classID);

            int amount = int.Parse(ketqua.Rows[0][0].ToString());

                if (amount == 0)
                {
                    result = 0;
                }
                else if (amount > 0)
                {
                    result = 1;
                }
            return result;
        }

        public static int CheckRegisSubject(string _regisID, string _subID)
        {
            int result = 0;

            DataTable ketqua = EducationalCenter_DemoDAO.RegistrationDAO.CheckRegisSubject(_regisID, _subID);

            int amount = int.Parse(ketqua.Rows[0][0].ToString());

            if (amount == 0)
            {
                result = 0;
            }
            else if (amount > 0)
            {
                result = 1;
            }
            return result;
        }

    }
}
