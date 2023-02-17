using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqtosql2
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{// data new likha usko save kese krna h 
			mydb1DataContext dc = new mydb1DataContext();// connection
			if (textBox1.ReadOnly == false)
			{
				employe1 obj = new employe1();// crreate instance of class every record in the table  is instance
				obj.student_id = int.Parse(textBox1.Text);// string hota h toh uska conversion karte h explicitly
				obj.name = textBox2.Text;
				obj.address = textBox3.Text;
				dc.employe1s.InsertOnSubmit(obj);// it will add record to the table
												 //pending in such state = inserted but still not completed

				dc.SubmitChanges();
				MessageBox.Show("record inserted into the table");
			}
			else
			{
				employe1 obj = dc.employe1s.SingleOrDefault(E => E.student_id == int.Parse(textBox1.Text));
				//which record you want
				obj.name = textBox2.Text;
				obj.address = textBox3.Text;
				dc.SubmitChanges();
				MessageBox.Show("record updated in the table");
																										   //reference to existing record

			}


		} 
	

		private void Form4_Load(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void label6_Click(object sender, EventArgs e )
		{
			foreach (Control ctrl in this.Controls)
			{

				// we get access to all the controls present  on the form
				if (ctrl is TextBox)
				{
					TextBox tb = ctrl as TextBox;
					tb.Clear();
					tb.Focus();
					// will clear all thee text box system , foreach loop to clear all this text
				}
			}
			textBox1.Focus();
			
		}
	   
	

	}
}
