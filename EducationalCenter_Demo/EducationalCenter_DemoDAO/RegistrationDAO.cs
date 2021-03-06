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

            string query = $"SELECT MAPHIEUDANGKY, NGAYDANGKY_LOPHOC " +
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
            string query = $"EXEC REGIS_DETAIL '{_regisID}' ";

            _conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(result);
            _conn.Close();
            return result;
        }

        public static DataTable GetRegisAmount()
        {
            DataTable result = new DataTable();       
            string query = $"select count(*) as ketqua from PHIEUDANGKY_LOPHOC";

            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(result);

            return result;
        }

        public static void CreateRegis(string _regisID, string _studentID)
        {
            
                string command = $"EXEC CREATE_REGIS  '{_regisID}', '{_studentID}'";

                _conn.Open();
                SqlCommand cmd = new SqlCommand(command, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
        }

        public static DataTable CheckRegisClass(string _regisID, string _classID)
        {
            DataTable result = new DataTable();
            string query = $"EXEC CHECK_ENROLL '{_classID}', '{_regisID}' ";

            _conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(result);
            _conn.Close();

            return result;
        }

        public static DataTable CheckRegisSubject (string _regisID, string _subID)
        {
            DataTable result = new DataTable();
            string query = $"EXEC CHECK_SUB '{_regisID}', '{_subID}' ";

            _conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
            adapter.Fill(result);
            _conn.Close();

            return result;
        }

    }
}
