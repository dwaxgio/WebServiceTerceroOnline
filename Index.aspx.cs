using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceTerceroOnline
{
    public partial class Index : System.Web.UI.Page
    {
        // Web service tomado de: http://www.dneonline.com/calculator.asmx
        // 2. Instancia para acceso global.
        WebServiceOnline.CalculatorSoapClient ws = new WebServiceOnline.CalculatorSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // suma
            Label1.Text = ws.Add(Convert.ToInt32(TxtBox1.Text), Convert.ToInt32(TxtBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Resta
            Label1.Text = ws.Subtract(Convert.ToInt32(TxtBox1.Text), Convert.ToInt32(TxtBox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // Multiplicacion
            Label1.Text = ws.Multiply(Convert.ToInt32(TxtBox1.Text), Convert.ToInt32(TxtBox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            // División
            Label1.Text = ws.Divide(Convert.ToInt32(TxtBox1.Text), Convert.ToInt32(TxtBox2.Text)).ToString();
        }
    }
}