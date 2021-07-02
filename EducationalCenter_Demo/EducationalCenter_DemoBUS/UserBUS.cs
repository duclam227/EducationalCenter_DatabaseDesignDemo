using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EducationalCenter_DemoBUS
{
    public class UserBUS
    {
        private string username;
        private string password;
        private static UserBUS _instance = null;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public static UserBUS Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserBUS();
                }

                return _instance;
            }
        }

        /*
         Return
        - -1: đăng nhập thất bại
        - 0: không có account
        - 1: đăng nhập thành công
         */
        public int CheckUser(string username, string password)
        {
            int result = 1;

            DataTable data = EducationalCenter_DemoDAO.UserDAO.CheckUser(username);
            string tmpName, tmpPass;

            if(data.Rows.Count == 0)
            {
                result = 0;
            }
            else
            {
                tmpName = data.Rows[0]["username"].ToString();
                tmpPass = data.Rows[0]["password"].ToString();

                if(tmpPass == password)
                {
                    result = 1;
                }
                else
                {
                    result = -1;
                }
            }



            return result;
        }
    }
}
