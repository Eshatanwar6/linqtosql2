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
	public partial class Form2 : Form
	{
		mydb1DataContext dc;
		List<employe1> Emps;
		int rno = 0;
		public Form2()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			dc = new mydb1DataContext();//next record aajyega but previous nahi toh hm access karne k liy index based access is not available\
			Emps = dc.employe1s.ToList();
			// i want to copy all these data into a list 
			ShowData();
		}
		private void ShowData()
		{
			textBox1.Text = Emps[rno].student_id.ToString();
			textBox2.Text = Emps[rno].name;
			textBox3.Text = Emps[rno].address;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{
			if (rno > 0)
			{
				rno -= 1;
				ShowData();

			}

			else
				MessageBox.Show("First record of the table. ");

		}


		private void label7_Click(object sender, EventArgs e)
		{
			this.Close(); // you can access thew data   row by row
//  from your table with the help of linq
		}

		private void label6_Click(object sender, EventArgs e)
		{
			if (rno < Emps.Count)
			{
				rno += 1;
				ShowData();
			}
			else
				MessageBox.Show("last record of the table");
		}
	}
}
