using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoDAO
{
    public class TuitionPaymentDAO : DBConnect
    {
        public static DataTable getTotalTuition(string MAPDK)
        {
            DataTable result = new DataTable();

            try
            {
                string query = $"EXECUTE getTotalTuition '{MAPDK}'";

                try
                {
                    _conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                    adapter.Fill(result);
                    _conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }

        public static void postBill(TuitionPaymentDTO bill)
        {
            DataTable result = new DataTable();


            string command = $"INSERT INTO HOADON VALUES(" +
                $"'{bill.NGAYLAPHOADON}', " +
                $"'{bill.MAPHIEUDANGKYLOPHOC}', " +
                $"'{bill.TONGTIEN}', " +
                $"'{bill.MANV}')";

            try
            {
                _conn.Open();
                SqlCommand cmd_a = new SqlCommand(command, _conn);
                cmd_a.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception ex)
            {
                _conn.Close();
                //throw ex;
            }
        }

        public static DataTable checkBill(TuitionPaymentDTO bill)
        {
            DataTable result = new DataTable();

            try
            {
                string query = $"SELECT COUNT(*) KETQUA FROM HOADON " +
                    $"WHERE MAPHIEUDANGKY_LOPHOC = '{bill.MAPHIEUDANGKYLOPHOC}' ";

                try
                {
                    _conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, _conn);
                    adapter.Fill(result);
                    _conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
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
