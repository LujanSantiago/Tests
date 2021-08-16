using SpreadsheetLight;
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
    public partial class Form2 : Form
    {
        conexion CN = new conexion();
        static string estado;
        public Form2(string usua)
        {
            InitializeComponent();
            CN.abrir();
            CN.consultas("SELECT * FROM users WHERE us=" + "'" + usua + "'");
            while (CN.dr.Read())
            {
                String tipo = Convert.ToString(CN.dr["role"]);
                if (tipo == "usa")
                {

                    estado = "apagado";

                }
                else if (tipo == "usb")
                {
                    Insert.Enabled = false;
                    delete.Enabled = false;
                }
                else if (tipo == "usc")
                {
                    Edit.Visible = false;
                    delete.Visible = false;
                    Insert.Visible = false;
                }
                else
                {

                }
            }
            CN.cerrar();
        }
        private void menos_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cierre_Click(object sender, EventArgs e)
        {
            string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\exit_log.txt";

            if (!File.Exists(curFile))
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string time = DateTime.Now.ToString("hh:mm:ss");
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                //Pass the filepath and filename to the StreamWriter Constructor
                TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\exit_log.txt");
                //Write a line of text
                sw.WriteLine("[" + strDate + time + "]" + " " + "user closed the application");
                //Close the file
                sw.Close();

            }
            else
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string time = DateTime.Now.ToString("hh:mm:ss");
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\exit_log.txt");
                sw.WriteLine("[" + strDate + "]" + " " + "user closed the application");
                sw.WriteLine("[" + strDate + time + "]" + " " + "user closed the application");
                sw.Close();

            }
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'warehouseDataSet1.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.warehouseDataSet1.inventory);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            popupadd agrega = new popupadd();
            agrega.Show();
            agrega.FormClosed += new System.Windows.Forms.FormClosedEventHandler(closedform);
        }

        private void closedform(object sender, FormClosedEventArgs e)
        {
            this.inventoryTableAdapter.Fill(this.warehouseDataSet1.inventory);


        }
       

        private void delete_Click(object sender, EventArgs e)
        {
            if (estado=="apagado")
            {
                MessageBox.Show("Necesita permisos de administrador");
                
            }
            else {
                popupdelete agrega = new popupdelete();
                agrega.Show();
                agrega.FormClosed += new System.Windows.Forms.FormClosedEventHandler(closedform);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            popupupdate actualiza = new popupupdate();
            actualiza.Show();
            actualiza.FormClosed += new System.Windows.Forms.FormClosedEventHandler(closedform);
        }

        private void search_Click(object sender, EventArgs e)
        {
            popupsearch search = new popupsearch();
            search.Show();
            search.FormClosed += new System.Windows.Forms.FormClosedEventHandler(closedform);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\logouts_log.txt";

            if (!File.Exists(curFile))
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string time = DateTime.Now.ToString("hh:mm:ss");
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                //Pass the filepath and filename to the StreamWriter Constructor
                TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\logouts.txt");
                //Write a line of text
                sw.WriteLine("[" + strDate + time + "]" + " " + "user logged in");
                //Close the file
                sw.Close();

            }
            else
            {
                DateTime dateTime = new DateTime();
                dateTime = DateTime.Now;
                string time = DateTime.Now.ToString("hh:mm:ss");
                string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\logouts_log.txt");
                sw.WriteLine("[" + strDate + time + "]" + " " + "user logged out");
                sw.Close();

            }
            Program.v1.Show();
           
            this.Close();
        }

        private void ExportarDatos(DataGridView datalistado)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in datalistado.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;

                //Log de exportaciones
                string curFile = @"C:\Users\Jose\source\repos\App warehouse\logs\exports_log.txt";
                
                if (!File.Exists(curFile))
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string time = DateTime.Now.ToString("hh:mm:ss");
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    //Pass the filepath and filename to the StreamWriter Constructor
                    TextWriter sw = new StreamWriter(@"C:\Users\Jose\source\repos\App warehouse\logs\exports_log.txt");
                    //Write a line of text
                    sw.WriteLine("[" + strDate + time + "]" + " " + "user exported database information");
                    //Close the file
                    sw.Close();
                    
                }
                else
                {
                    DateTime dateTime = new DateTime();
                    dateTime = DateTime.Now;
                    string strDate = Convert.ToDateTime(dateTime).ToString("yyyy-MM-dd");
                    StreamWriter sw = File.AppendText(@"C:\Users\Jose\source\repos\App warehouse\logs\exports_log.txt");
                    sw.WriteLine("[" + strDate + "]" + " " + "user exported database information");
                    sw.Close();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("No hay Registros a Exportar.");
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportarDatos(dataGridView1);
        }
    }
}
