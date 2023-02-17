using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace linqtosql2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			mydb1DataContext dc = new mydb1DataContext();// create instance for  conneting to the database (help karega)
		    Table<employe1> tab = dc.employe1s; // instead of gettable method we  can use this also for retrieving the data
			dataGridView1.DataSource = tab;//bind  the table to the grid view
		}
	}
}
