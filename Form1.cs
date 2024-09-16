using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace _046_TolentinoBulalayao_FranceszDave_L3
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("First name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Department");

        }

        private void excelFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile.Title = "Open Excel";
            OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            OpenFile.Filter = "All files (*.*)|*.*|Excel File (*.xls)|*.xls";
            OpenFile.FilterIndex = 1;
            OpenFile.ShowDialog();
            display();

        }
        
        private void cboLoad_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           

        }
        void display()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
             "Data Source=" + OpenFile.FileName + "; Extended Properties='Excel 12.0 Xml; HDR=Yes'"); ;
            conn.Open();
            OleDbDataAdapter ad = new OleDbDataAdapter("select * from [Sheet1$]", conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            cboLoad.DataSource = dt;
            cboLoad.DisplayMember = "dept";
            cboLoad.ValueMember = "dept";
            cboLoad.SelectedValue.ToString();
            conn.Close();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtFname.Text,txtLname.Text,cboLoad.Text);
            dgvData.DataSource = dt;
    }

        private void btnSaveRec_Click(object sender, EventArgs e)
        {
            saveText.Title = "Save as file";
            saveText.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveText.DefaultExt = "txt";
            saveText.Filter = "All files(*.*)|*.*|Text File (*.txt)|*.txt";
            saveText.FilterIndex = 2;

            if(saveText.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter writer = File.CreateText(saveText.FileName))
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                            writer.WriteLine(dgvData.Rows[i].Cells[j].Value.ToString());
                    }
                  
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            clear();
            
            dgvData.DataSource = null;
            dt.Clear();
        }
        void clear()
        {
            txtLname.Text = "";
            txtFname.Text = "";
            cboLoad.SelectedIndex = -1;
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openText.Title = "Open Text";
            openText.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openText.Filter = "All files(*.*) | *.*| Text File(*.txt) | *.txt";
            openText.FilterIndex = 1;
            openText.ShowDialog();

            if (!string.IsNullOrWhiteSpace(openText.FileName))
            {
                string[] statement = File.ReadAllLines(openText.FileName);
                for(int i = 0; i < statement.Length; i++)
                {
                    cboLoad.Items.Add(statement[i]);
                }

            }
               
        }
    }
    }
