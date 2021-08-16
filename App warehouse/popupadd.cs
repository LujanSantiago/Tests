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
    public partial class popupadd : Form
    {
        
        conexion CN = new conexion();
        public popupadd()
        {
            InitializeComponent();
        }
        
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            String pid = textBox1.Text;
            String pname = textBox2.Text;
            String pamount = textBox3.Text;
            string pdes=textBox4.Text;
            try
            {
                CN.abrir();
                CN.movimientos("INSERT INTO inventory VALUES(" + "'" + pid + "'" + "," + "'" + pname + "'" + "," + "'" + pamount + "'" +"," + "'" + pdes + "'" + ")");
                CN.cerrar();
                MessageBox.Show("Inserted");

                string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\adds_log.txt";

                if (!File.Exists(curFile))
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    //Pass the filepath and filename to the StreamWriter Constructor
                    TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\adds_log.txt");
                    //Write a line of text
                    sw.WriteLine("[" + strDate + time + "]" + " " + "user added database information with id: " + pid);
                    //Close the file
                    sw.Close();

                }
                else
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\adds_log.txt");
                    sw.WriteLine("[" + strDate + time + "]" + " " + "user added database information with id: " + pid);
                    sw.Close();

                }

                this.Close();
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
