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
using System.Text;


namespace App_warehouse
{
    public partial class Form1 : Form
    {
        conexion CN = new conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void cierre_Click_1(object sender, EventArgs e)
        {
            string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\exit_log.txt";

            if (!File.Exists(curFile))
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                //Pass the filepath and filename to the StreamWriter Constructor
                TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\exit_log.txt");
                //Write a line of text
                sw.WriteLine("[" + strDate + "]" + " " + "user closed the aplication");
                //Close the file
                sw.Close();

            }
            else
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\exit_log.txt");
                sw.WriteLine("[" + strDate + "]" + " " + "user closed the application");
                sw.Close();

            }
            Application.Exit();
        }

        private void menos_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usu = txtusuario.Text;
            String pass = contrasena.Text;
            CN.abrir();
            CN.consultas("SELECT * FROM users WHERE us=" + "'" + usu + "'");
            while (CN.dr.Read())
            {
                string usua = Convert.ToString(CN.dr["us"]);
  
                if (usua == usu)
                {
                    String pase = Convert.ToString(CN.dr["pass"]);

                    if (pase == pass)
                    {
                        Form2 inici = new Form2(usua);
                        this.Hide();
                        txtusuario.Text = "";
                        contrasena.Text = "";
                        inici.Show();

                        string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\logging_log.txt";

                    if (!File.Exists(curFile))
                    {
                        DateTime dateTime = new DateTime();
                            string time = DateTime.Now.ToString("hh:mm:ss");
                        dateTime = DateTime.Now;
                        string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                        //Pass the filepath and filename to the StreamWriter Constructor
                        TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\logging_log.txt");
                        //Write a line of text
                        sw.WriteLine("[" + strDate + time + "]"+ " "+ "user logged in");
                            //Close the file
                            sw.Close();
                        
                        }
                        else
                        {
                        DateTime dateTime = new DateTime();
                        dateTime = DateTime.Now;
                            string time = DateTime.Now.ToString("hh:mm:ss");
                            string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                        StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\logging_log.txt");
                            sw.WriteLine("[" + strDate + time + "]" + " " + "user logged in");
                            sw.Close();

                        }
                    
                   
                    
                }
                    else
                    {
                        MessageBox.Show("error");
                    }
                }
                else
                {
                    MessageBox.Show("error");
                }




            }
            CN.cerrar();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
