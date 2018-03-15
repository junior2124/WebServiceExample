using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculator;
public partial class _Default : System.Web.UI.Page
{
    CalculatorService oCalc = new CalculatorService();
 
    decimal a, b, c;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        a = Convert.ToDecimal(txtFno.Text);
        b = Convert.ToDecimal(txtSno.Text);
        c = oCalc.Add(a, b);
        lblResult.Text = c.ToString();
    }
    protected void btnSub_Click(object sender, EventArgs e)
    {
        a = Convert.ToDecimal(txtFno.Text);
        b = Convert.ToDecimal(txtSno.Text);
        c = oCalc.Sub(a, b);
        lblResult.Text = c.ToString();
    }
    protected void BtnMul_Click(object sender, EventArgs e)
    {
        a = Convert.ToDecimal(txtFno.Text);
        b = Convert.ToDecimal(txtSno.Text);
        c = oCalc.Mul(a, b);
        lblResult.Text = c.ToString();
    }
    protected void btnDiv_Click(object sender, EventArgs e)
    {

        a = Convert.ToDecimal(txtFno.Text);
        b = Convert.ToDecimal(txtSno.Text);
        c = oCalc.Div(a, b);
        lblResult.Text = c.ToString();
    }
}