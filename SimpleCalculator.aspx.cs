using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simple_calculator
{
    public partial class SimpleCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtDisplay2.Text = "0";
            }
        }
        private double EvaluateExpression(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", typeof(double), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return (double)row["expression"];
        }
        protected void Button1_Click1(object sender, EventArgs e)//addition
        {
            if (txtDisplay2.Text.Length > 0)
            {
                if (txtDisplay2.Text.Length >= 0)
                {
                    if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                    {
                        int itext = txtDisplay1.Text.Length - 1;
                        int istart = itext - 0;
                        string x = txtDisplay1.Text.Substring(istart);
                        if (x != "+" || x != "-" || x != "*" || x != "/")
                        {

                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "+";


                        }
                        else if (x == "+" || x == "-" || x == "*" || x == "/")
                        {
                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            string n = txtDisplay1.Text + txtDisplay2.Text;
                            txtDisplay2.Text = "";
                            txtDisplay2.Text = EvaluateExpression(n).ToString();

                        }
                    }
                    else
                    {
                        txtDisplay1.Text += txtDisplay2.Text + "+";
                        txtDisplay2.Text = "";
                    }
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
                else
                {
                    txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "+";
                    txtDisplay2.Text = "";
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
            }
            else if (txtDisplay2.Text.Length == 0 && txtDisplay1.Text.Length == 0)
            {
                txtDisplay1.Text = "0+";
                txtDisplay2.Text = "";
            }
            else if (txtDisplay2.Text == "")
            {
                txtDisplay1.Text += "+";
            }


        }

        protected void Button6_Click(object sender, EventArgs e)//subtraction
        {
            if (txtDisplay2.Text.Length > 0)
            {
                if (txtDisplay2.Text.Length >= 0)
                {
                    if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                    {
                        int itext = txtDisplay1.Text.Length - 1;
                        int istart = itext - 0;
                        string x = txtDisplay1.Text.Substring(istart);
                        if (x != "+" || x != "-" || x != "*" || x != "/")
                        {

                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "-";


                        }
                        else if (x == "+" || x == "-" || x == "*" || x == "/")
                        {
                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            string n = txtDisplay1.Text + txtDisplay2.Text;
                            txtDisplay2.Text = "";
                            txtDisplay2.Text = EvaluateExpression(n).ToString();

                        }
                    }
                    else
                    {
                        txtDisplay1.Text += txtDisplay2.Text + "-";
                        txtDisplay2.Text = "";
                    }
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
                else
                {
                    txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "-";
                    txtDisplay2.Text = "";
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
            }
            else if (txtDisplay2.Text.Length == 0 && txtDisplay1.Text.Length == 0)
            {
                txtDisplay1.Text = "0-";
                txtDisplay2.Text = "";
            }
            else if (txtDisplay2.Text == "")
            {
                txtDisplay1.Text += "-";
            }

        }

        protected void Button7_Click1(object sender, EventArgs e)//multiplication
        {
            if (txtDisplay2.Text.Length > 0)
            {
                if (txtDisplay2.Text.Length >= 0)
                {
                    if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                    {
                        int itext = txtDisplay1.Text.Length - 1;
                        int istart = itext - 0;
                        string x = txtDisplay1.Text.Substring(istart);
                        if (x != "+" || x != "-" || x != "*" || x != "/")
                        {

                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "*";


                        }
                        else if (x == "+" || x == "-" || x == "*" || x == "/")
                        {
                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            string n = txtDisplay1.Text + txtDisplay2.Text;
                            txtDisplay2.Text = "";
                            txtDisplay2.Text = EvaluateExpression(n).ToString();

                        }
                    }
                    else
                    {
                        txtDisplay1.Text += txtDisplay2.Text + "*";
                        txtDisplay2.Text = "";
                    }
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
                else
                {
                    txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "*";
                    txtDisplay2.Text = "";
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
            }
            else if (txtDisplay2.Text.Length == 0 && txtDisplay1.Text.Length == 0)
            {
                txtDisplay1.Text = "0*";
                txtDisplay2.Text = "";
            }
            else if (txtDisplay2.Text == "")
            {
                txtDisplay1.Text += "*";
            }

        }

        protected void Button8_Click(object sender, EventArgs e)//div
        {
            if (txtDisplay2.Text.Length > 0)
            {
                if (txtDisplay2.Text.Length >= 0)
                {
                    if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                    {
                        int itext = txtDisplay1.Text.Length - 1;
                        int istart = itext - 0;
                        string x = txtDisplay1.Text.Substring(istart);
                        if (x != "+" || x != "-" || x != "*" || x != "/")
                        {

                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "/";


                        }
                        else if (x == "+" || x == "-" || x == "*" || x == "/")
                        {
                            txtDisplay1.Text += txtDisplay2.Text;
                            txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                            string n = txtDisplay1.Text + txtDisplay2.Text;
                            txtDisplay2.Text = "";
                            txtDisplay2.Text = EvaluateExpression(n).ToString();

                        }
                    }
                    else
                    {
                        txtDisplay1.Text += txtDisplay2.Text + "/";
                        txtDisplay2.Text = "";
                    }
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
                else
                {
                    txtDisplay1.Text = EvaluateExpression(txtDisplay1.Text).ToString() + "/";
                    txtDisplay2.Text = "";
                    //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();
                }
            }
            else if (txtDisplay2.Text.Length == 0 && txtDisplay1.Text.Length == 0)
            {
                txtDisplay1.Text = "0/";
                txtDisplay2.Text = "";
            }
            else if (txtDisplay2.Text == "")
            {
                txtDisplay1.Text += "/";
            }

        }



        protected void Button2_Click1(object sender, EventArgs e)//7
        {
            if (txtDisplay1.Text == "")//initial entry
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "7";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "7";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater than 15 not allowed
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "7";
                            }
                            else
                            {
                                txtDisplay2.Text += "7";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "7";
                        }
                        else
                        {
                            txtDisplay2.Text += "7";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "7";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }

        }

        protected void Button3_Click1(object sender, EventArgs e)//8
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "8";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "8";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "8";
                            }
                            else
                            {
                                txtDisplay2.Text += "8";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "8";
                        }
                        else
                        {
                            txtDisplay2.Text += "8";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "8";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }

        }


        protected void Button4_Click1(object sender, EventArgs e)//9
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "9";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "9";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "9";
                            }
                            else
                            {
                                txtDisplay2.Text += "9";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "9";
                        }
                        else
                        {
                            txtDisplay2.Text += "9";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "9";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }

        }

        protected void Button5_Click1(object sender, EventArgs e)//bs
        {
            if (txtDisplay2.Text.Length > 0)
            {
                txtDisplay2.Text = txtDisplay2.Text.Substring(0, txtDisplay2.Text.Length - 1);
                if (txtDisplay2.Text.Length == 0)// after clear all display 0
                {
                    txtDisplay2.Text = "0";
                }
            }

        }

        protected void Button9_Click(object sender, EventArgs e)//4
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "4";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "4";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "4";
                            }
                            else
                            {
                                txtDisplay2.Text += "4";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "4";
                        }
                        else
                        {
                            txtDisplay2.Text += "4";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "4";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }

        }

        protected void Button10_Click(object sender, EventArgs e)//5
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "5";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "5";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "5";
                            }
                            else
                            {
                                txtDisplay2.Text += "5";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "5";
                        }
                        else
                        {
                            txtDisplay2.Text += "5";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "5";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }
        }

        protected void Button11_Click(object sender, EventArgs e)//6
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "6";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "6";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "6";
                            }
                            else
                            {
                                txtDisplay2.Text += "6";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "6";
                        }
                        else
                        {
                            txtDisplay2.Text += "6";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "6";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }
        }

        protected void Button12_Click(object sender, EventArgs e)//1
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "1";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "1";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "1";
                            }
                            else
                            {
                                txtDisplay2.Text += "1";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "1";
                        }
                        else
                        {
                            txtDisplay2.Text += "1";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "1";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }
        }

        protected void Button13_Click1(object sender, EventArgs e)//2
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "2";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "2";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "2";
                            }
                            else
                            {
                                txtDisplay2.Text += "2";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "2";
                        }
                        else
                        {
                            txtDisplay2.Text += "2";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "2";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }

        }

        protected void Button14_Click(object sender, EventArgs e)//3
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0" || txtDisplay2.Text == "0.00")
                {
                    txtDisplay2.Text = "3";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "3";
                }
            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "3";
                            }
                            else
                            {
                                txtDisplay2.Text += "3";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "3";
                        }
                        else
                        {
                            txtDisplay2.Text += "3";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "3";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }
        }

        protected void Button15_Click(object sender, EventArgs e)//0
        {
            if (txtDisplay1.Text == "")
            {
                if (txtDisplay2.Text == "0")
                {
                    txtDisplay2.Text = "0";
                }
                else if (txtDisplay2.Text.Length >= 15)//greater
                {
                    int max = 15;
                    if (txtDisplay2.Text.Length > max)
                    {
                        txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                    }
                }
                else
                {
                    txtDisplay2.Text += "0";
                }

            }
            else if (txtDisplay2.Text.Length >= 15)//greater
            {
                int max = 15;
                if (txtDisplay2.Text.Length > max)
                {
                    txtDisplay2.Text = txtDisplay2.Text.Substring(0, max);
                }
            }
            else if (txtDisplay1.Text.Length > 0)
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                if (txtDisplay1.Text.Contains("+") || txtDisplay1.Text.Contains("-") || txtDisplay1.Text.Contains("*") || txtDisplay1.Text.Contains("/"))
                {
                    if (last == "+" || last == "-" || last == "*" || last == "/")
                    {
                        if (txtDisplay2.Text.Length > 0)
                        {

                            if (txtDisplay2.Text == (txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1)))
                            {
                                txtDisplay2.Text = "0";
                            }
                            else
                            {
                                txtDisplay2.Text += "0";
                            }
                            //txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                            //txtDisplay2.Text = EvaluateExpression(txtDisplay1.Text).ToString();

                        }

                        else if (txtDisplay2.Text.Length <= 0)
                        {
                            txtDisplay2.Text = "0";
                        }
                        else
                        {
                            txtDisplay2.Text += "0";
                        }
                    }
                    else if (last != "+" || last != "-" || last != "*" || last != "/")
                    {
                        txtDisplay2.Text += "0";
                        txtDisplay1.Text = txtDisplay1.Text;
                        //txtDisplay2.Text= EvaluateExpression(txtDisplay1.Text).ToString();
                    }
                }
            }


        }

        protected void Button16_Click1(object sender, EventArgs e)//.
        {


            if (txtDisplay2.Text.Length > 0 || txtDisplay2.Text.Length == 0)
            {
                int itext = txtDisplay2.Text.Length - 1;
                int istart = itext - 0;
                string x = txtDisplay2.Text.Substring(istart);

                if (x == "." || txtDisplay2.Text.Contains("."))// last digit "." or  display contains "." check display contains operators
                {



                    if (txtDisplay2.Text.Contains("+") || txtDisplay2.Text.Contains("-") || txtDisplay2.Text.Contains("*") || txtDisplay2.Text.Contains("/"))//check if display contains any operators 
                    {
                        //char[] mychar = {'+','-','*','/' };
                        string[] parts = txtDisplay2.Text.Split(new[] { "+", "-", "*", "/" }, StringSplitOptions.RemoveEmptyEntries);

                        if (parts.Length > 0 && parts.Last().Contains(".")) // after operator doesnot allow two "."
                        {
                            return;
                        }
                        else
                        {
                            txtDisplay2.Text += ".";
                        }

                    }
                    else
                    {
                        txtDisplay2.Text = txtDisplay2.Text;
                    }


                }
                else
                {
                    txtDisplay2.Text += ".";
                }
            }


        }

        protected void Button17_Click(object sender, EventArgs e)//ac
        {
            if (txtDisplay2.Text == "0" || txtDisplay2.Text == "")//if res disp is 0 
            {
                txtDisplay1.Text = "";//clear small dis
            }
            else
            {
                txtDisplay2.Text = "";
            }

        }

        protected void Button18_Click(object sender, EventArgs e)//=
        {
            try
            {
                string text1 = txtDisplay1.Text;
                string last = text1.Substring(text1.Length - 1);
                string val = txtDisplay1.Text.Remove(txtDisplay1.Text.Length - 1);
                if (last == "=")
                {
                    int index = val.IndexOfAny(new char[] { '+', '-', '*', '/' });
                    string result = index >= 0 ? val.Substring(index) : val;
                    txtDisplay2.Text = txtDisplay2.Text + result;
                    var text = EvaluateExpression(txtDisplay2.Text).ToString();
                    txtDisplay2.Text = Convert.ToDouble(text).ToString("N");
                }
                else
                {
                    txtDisplay1.Text = txtDisplay1.Text + txtDisplay2.Text;
                    var text = EvaluateExpression(txtDisplay1.Text).ToString();
                    txtDisplay1.Text += "=";
                    txtDisplay2.Text = Convert.ToDouble(text).ToString("N");
                }
            }
            catch (Exception)
            {
                txtDisplay2.Text = "Error";
            }
        }



        protected void txtDisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtDisplay2_TextChanged(object sender, EventArgs e)
        {
            //var text = EvaluateExpression(txtDisplay1.Text).ToString();
            //if (txtDisplay2.Text==text)
            //{
            //    txtDisplay2.Text = "";
            //}
        }


    }
}