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
	public partial class Form3 : Form
	{ 
		mydb1DataContext dc;

	
		public Form3()
		{
			InitializeComponent();
		}
		private  void LoadData()
		{
			dc = new mydb1DataContext();
			dgView.DataSource = dc.employe1s;

		}

		private void label1_Click(object sender, EventArgs e)
		{
			Form4 f = new Form4();
			f.ShowDialog();
			LoadData();

		}

		private void Form3_Load(object sender, EventArgs e)
		{
			//dc = new mydb1DataContext();

		
			//dgView.DataSource = dc.employe1s;//. whole data ko load krdega
			LoadData();
				}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{
			if (dgView.SelectedRows.Count > 0)
			{
				Form4 f = new Form4();
				f.textBox1.ReadOnly = true;
				// change nhu hosakta
				f.label6.Enabled = false;
				f.label7.Text = "Update";
				f.textBox2.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
				f.textBox1.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
				f.textBox3.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
				f.ShowDialog();
				LoadData();
			}
			else
				MessageBox.Show("Please select a record for updation", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void label3_Click(object sender, EventArgs e)
		{
			// for deleting data row by row
			if (dgView.SelectedRows.Count > 0)
			{
				if (MessageBox.Show("are you sure of deleting the data?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					int student_id = Convert.ToInt32(dgView.SelectedRows[0].Cells[1].Value);
					employe1 obj = dc.employe1s.SingleOrDefault(E => E.student_id == student_id);
					// this obj become the refrence of existing record

					// in delete also you have to make refrence of record
					
					dc.employe1s.DeleteOnSubmit(obj);// this will delete the data in pending state 
					dc.SubmitChanges();
					LoadData();
				}
					

			}
			else
				MessageBox.Show("please select a record for deleting", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);




		}
	}
	}

