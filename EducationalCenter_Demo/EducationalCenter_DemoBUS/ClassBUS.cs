using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoBUS
{
    public class ClassBus
    {
        private static ClassBus _instance = null;
        public static ClassBus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClassBus();
                }

                return _instance;
            }
        }
        public static List<ClassDTO> GetClass(string _id, string _program)
        {
            List<ClassDTO> result = new List<ClassDTO>();

            DataTable data = EducationalCenter_DemoDAO.ClassDAO.GetClass(_id, _program);

            foreach (DataRow row in data.Rows)
            {
                ClassDTO tmp = new ClassDTO();
                tmp.IDSub = row["MAMH"].ToString();
                tmp.NameSub = row["TENMONHOC"].ToString();
                tmp.IDClass = row["MALOP"].ToString();
                string tmpdate = row["NGAYBATDAU"].ToString();
                tmp.StartDate = DateTime.Parse(tmpdate);
                tmp.Room = row["PHONGHOC"].ToString();
                tmp.ClassDate = row["LICH_HOC"].ToString();
                tmp.MaxNumber = row["SISO_TOIDA"].ToString();
                tmp.CurrentNumber = row["SISO"].ToString();
                

                //tmp.CheckBox = bool.Parse(false);

                result.Add(tmp);
            }
            return result;
        }

        public static List<ClassDTO> GetAllClasses(string _subjectID)
        {
            List<ClassDTO> result = new List<ClassDTO>();

            try
            {
                DataTable data = EducationalCenter_DemoDAO.ClassDAO.GetAllClasses(_subjectID);
                foreach (DataRow row in data.Rows)
                {
                    ClassDTO tmp = new ClassDTO();
                    tmp.IDClass = row["MALOP"].ToString();

                    result.Add(tmp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    
        public static void EnrollClass (string _regisID, string _classID)
        {
            try
            {
                EducationalCenter_DemoDAO.ClassDAO.EnrollClass(_regisID, _classID);
            }
            catch (Exception)
            {
                //
            }
        }

        public static void CancelClass (string _regisID, string _classID)
        {
            try
            {
                EducationalCenter_DemoDAO.ClassDAO.CancelClass(_regisID, _classID);
            }
            catch (Exception)
            {
                
            }
        }
    }
}
