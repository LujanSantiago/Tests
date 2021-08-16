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
    public partial class popupupdate : Form
    {
        conexion CN = new conexion();
        public popupupdate()
        {
            InitializeComponent();
        }

        private void originalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orid = originalID.Text;
            string otroname = textBox5.Text;
            try
            {
                CN.abrir();
                CN.consultas("UPDATE inventory SET uname=" + "'" + otroname + "'" + "WHERE id =" + orid);
                CN.cerrar();
                MessageBox.Show("Name Updated");
                log();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string orid = originalID.Text;
            string otracant = textBox6.Text;
            try
            {
                CN.abrir();
                CN.consultas("UPDATE inventory SET amount=" + "'" + otracant + "'" + "WHERE id =" + orid);
                CN.cerrar();
                MessageBox.Show("Cuantity Updated");
                log();
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

        private void button6_Click(object sender, EventArgs e)
        {
            string orid = originalID.Text;
            string otradesc = textBox1.Text;
            try
            {
                CN.abrir();
                CN.consultas("UPDATE inventory SET description=" + "'" + otradesc + "'" + "WHERE id =" + orid);
                CN.cerrar();
                MessageBox.Show("Description Updated");
                log();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void originalname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ornam = originalname.Text;
            string otronam = textBox7.Text;
            try
            {
                CN.abrir();
                CN.consultas("UPDATE inventory SET uname=" + "'" + otronam + "'" + "WHERE uname =" + "'" + ornam + "'");
                CN.cerrar();
                MessageBox.Show("ID Updated");
                log();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ornam = originalname.Text;
            string otracant = textBox8.Text;
            try
            {
                CN.abrir();
                CN.consultas("UPDATE inventory SET amount=" + "'" + otracant + "'" + "WHERE uname =" + "'"+ornam+"'");
                CN.cerrar();
                MessageBox.Show("ID Updated");
                log();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string ornam = originalname.Text;
            string otradesc = textBox2.Text;
            try
            {
                CN.abrir();
                CN.consultas("UPDATE inventory SET description=" + "'" + otradesc + "'" + "WHERE uname =" + "'" + ornam + "'");
                CN.cerrar();
                MessageBox.Show("ID Updated");
                log();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void log()
        {
            string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\updates_log.txt";

            if (!File.Exists(curFile))
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                //Pass the filepath and filename to the StreamWriter Constructor
                TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\updates_log.txt");
                //Write a line of text
                sw.WriteLine("[" + strDate + "]" + " " + "user updated database information"  );
                //Close the file
                sw.Close();

            }
            else
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\updates_log.txt");
                sw.WriteLine("[" + strDate + "]" + " " + "user updated database information");
                sw.Close();

            }
        }
    }
}
