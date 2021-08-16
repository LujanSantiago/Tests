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
    public partial class popupdelete : Form
    {
        conexion CN = new conexion();
        public popupdelete()
        {
            InitializeComponent();
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            string pid = textBox1.Text;
            try
            {
                CN.abrir();
                CN.consultas("DELETE FROM inventory Where id=" + "'" + pid + "'");
                CN.cerrar();
                MessageBox.Show("Deleted");

                string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\deletes_log.txt";

                if (!File.Exists(curFile))
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    //Pass the filepath and filename to the StreamWriter Constructor
                    TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\deletes_log.txt");
                    //Write a line of text
                    sw.WriteLine("[" + strDate + time + "]" + " " + "user searched database information with id: " + pid);
                    //Close the file
                    sw.Close();
                    
                }
                else
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\deletes_log.txt");
                    sw.WriteLine("[" + strDate + time + "]" + " " + "user searched database information with id: " + pid);
                    sw.Close();

                }

                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete2_Click(object sender, EventArgs e)
        {
            string pname = textBox2.Text;
            try
            {
                CN.abrir();
                CN.consultas("DELETE FROM inventory Where uname=" + "'" + pname + "'");
                CN.cerrar();

                string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\deletes_log.txt";

                if (!File.Exists(curFile))
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    //Pass the filepath and filename to the StreamWriter Constructor
                    TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\deletes_log.txt");
                    //Write a line of text
                    sw.WriteLine("[" + strDate + time + "]" + " " + "user searched database information with name: " + pname);
                    //Close the file
                    sw.Close();

                }
                else
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\deletes_log.txt");
                    sw.WriteLine("[" + strDate + time + "]" + " " + "user searched database information with name: " + pname);
                    sw.Close();

                }
                MessageBox.Show("Deleted");

                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
