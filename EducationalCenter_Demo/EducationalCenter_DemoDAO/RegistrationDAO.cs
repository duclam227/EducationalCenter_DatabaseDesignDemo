using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using EducationalCenter_DemoDTO;
using System.Windows.Forms;


namespace EducationalCenter_DemoDAO
{
    public class RegistrationDAO : DBConnect
    {
        public static DataTable GetRegistrationID (string _studentID)
        {
            DataTable result = new DataTable();

            string query = $"SELECT MAPHIEUDANGKY " +
                $"FROM PHIEUDANGKY_LOPHOC " +
                $"WHERE MAHV = '{_studentID}'" +
                $"ORDER BY NGAYDANGKY_LOPHOC DESC";

            _conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(result);
            _conn.Close();
            return result;
        }

        public static DataTable RegistrationDetail (string _regisID)
        {
            DataTable result = new DataTable();
            string query = $"EXEC dbo.REGIS_DETAIL '{_regisID}' ";

            _conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(result);
            _conn.Close();
            return result;
        }
    }
}
