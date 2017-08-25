using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevUCSharpCS_ASP_021
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            //simplified array instantiation example
            string[] values = new string[5] { "Bob", "Steve", "Chuck", "Brian", "Andy" };
            ViewState.Add("MyValues", values);
            resultLabel.Text = "Values added...";

            //example of instantiating array with each value on a separate line and explicitly assigned a position 
            //string[] values = new string[5];
            //values[0] = TextBox1.Text;
            //values[1] = TextBox2.Text;
            //values[2] = TextBox3.Text;
            //values[3] = TextBox4.Text;
            //values[4] = TextBox5.Text;

            //resultLabel.Text = values[2];
            resultLabel.Text = "Values added...";
        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            //casts the vlaue of MyValues to string
            //because the array gets stored in the dictionary
            //as a generic object which can't be implicitly 
            //converted to a string. 
            string[] values = (string[])ViewState["MyValues"];
            TextBox1.Text = values[0];
            TextBox2.Text = values[1];
            TextBox3.Text = values[2];
            TextBox4.Text = values[3];
            TextBox5.Text = values[4];

            resultLabel.Text = "Values retrieved ...";
        }
    }
}