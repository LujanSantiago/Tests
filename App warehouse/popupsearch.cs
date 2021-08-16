using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App_warehouse
{
    public partial class popupsearch : Form
    {
        conexion CN = new conexion();
        public popupsearch()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void delete1_Click(object sender, EventArgs e)
        {
            string id = textboxid.Text;
            
            
            try
            {
                CN.abrir();
                CN.consultas("SELECT * FROM inventory WHERE id=" +  id);
                while (CN.dr.Read())
                {
                    string ids = Convert.ToString(CN.dr["id"]);
                    string names = Convert.ToString(CN.dr["uname"]);
                    string amount = Convert.ToString(CN.dr["amount"]);
                    string desc = Convert.ToString(CN.dr["description"]);

                    idtxt.Text = ids;
                    nametxt.Text = names;
                    amounttxt.Text = amount;
                    desctxt.Text = desc;


                    string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\search_log.txt";

                    if (!File.Exists(curFile))
                    {
                        DateTime dateTime = new DateTime();
                        dateTime = DateTime.Now;
                        string time = DateTime.Now.ToString("hh:mm:ss");
                        string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                        //Pass the filepath and filename to the StreamWriter Constructor
                        TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\search_log.txt");
                        //Write a line of text
                        sw.WriteLine("[" + strDate + time + "]" + " " + "user searched database information with id: " + ids);
                        //Close the file
                        sw.Close();
                        
                    }
                    else
                    {
                        DateTime dateTime = new DateTime();
                        dateTime = DateTime.Now;
                        string time = DateTime.Now.ToString("hh:mm:ss");
                        string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                        StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\search_log.txt");
                        sw.WriteLine("[" + strDate + time + "]" + " " + "user searched database information with id: " + ids);
                        sw.Close();

                    }

                }
                CN.cerrar();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void popupsearch_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void desctxt_Click(object sender, EventArgs e)
        {

        }

        private void textboxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
