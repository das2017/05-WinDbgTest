using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WindbgTest;

namespace windbgTest
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnHighCPU_Click(object sender, EventArgs e)
        {
            try
            {
                CityDBQuery city = new CityDBQuery();
                while (true)
                {
                    var citysSql = city.GetCityList();
                }
                Label1.Text = "CPU崩溃了";
                //while (true)
                //{
                //    int i = 0;
                //    Response.Write(123 / i);
                //}
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}