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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private OleDbConnection Conec;
        private String conStr;
        private String Path;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.datos' Puede moverla o quitarla según sea necesario.
           // this.datosTableAdapter.Fill(this.clientesDataSet.datos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar();
            string strSelectCmd = "select * from datos";
            string strInsert = "insert into datos values(123, nombre)";

            OleDbDataAdapter objDataAdapter = new OleDbDataAdapter(strSelectCmd, Conec);

            DataSet ds = new DataSet();            
            objDataAdapter.Fill(ds);
            dg2.DataSource = ds.Tables[0];


        }
        void conectar()
        {
            Path = Directory.GetCurrentDirectory();            
            conStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path + "\\clientes.mdb";
            Conec = new OleDbConnection(conStr);
            Conec.Open();
        }
    }
}
