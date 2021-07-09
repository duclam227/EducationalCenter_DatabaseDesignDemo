using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EducationalCenter_DemoDTO;

namespace EducationalCenter_DemoBUS
{
    public class TuitionPaymentBUS
    {
        public static float getTotalTuition(string MAPDK)
        {
            float result = 0;

            try
            {
                DataTable ketqua = EducationalCenter_DemoDAO.TuitionPaymentDAO.getTotalTuition(MAPDK);             
                result = float.Parse(ketqua.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static int postBill(TuitionPaymentDTO newBill)
        {
            int result = 0;
            try
            {
                DataTable ketqua = EducationalCenter_DemoDAO.TuitionPaymentDAO.checkBill(newBill);
                result = int.Parse(ketqua.Rows[0][0].ToString());

                if(result > 0)
                    return 0;
                

                EducationalCenter_DemoDAO.TuitionPaymentDAO.postBill(newBill);
                return 1;
            }
            catch(Exception ex)
            {
                return -1;
            }
        }
    }
}
