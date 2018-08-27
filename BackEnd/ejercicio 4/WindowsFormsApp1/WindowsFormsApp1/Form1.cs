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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            openFileDialog1.Filter = "in files (*.in)|*.in";
            DialogResult result = openFileDialog1.ShowDialog();

            string line;

            List<Cliente> clientes = new List<Cliente>();

            StreamReader file = new StreamReader(openFileDialog1.FileName);
            while ((line = file.ReadLine()) != null)
            {
                Cliente cliente = new Cliente();
                //line.Split('|');
                string[] palabra = line.Split('|');

                cliente.PersonalId = int.Parse(palabra[0]);
                cliente.Name = palabra[1];
                cliente.LastName = palabra[2];
                cliente.LastName = palabra[3];
                cliente.Country = palabra[4];
                cliente.Industry = palabra[5];
                cliente.NumberOfRecommendations = double.Parse(palabra[6]);
                cliente.NumberOfConnections = double.Parse(palabra[7]);

                clientes.Add(cliente);

            }
            try
            {

                clientes = clientes.OrderByDescending(c => c.NumberOfConnections != 0 && c.NumberOfRecommendations != 0 ? (c.NumberOfConnections / c.NumberOfRecommendations) : 0).ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "atencion");
            }
            saveFileDialog1.Filter = "in files (*.in)|*.in";
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;

            int w=0;
            StreamWriter sw = File.CreateText(path);
            foreach (Cliente cliente in clientes)
            {
                if (w < 100)
                {
                    sw.WriteLine(cliente.PersonalId);
                    w++;
                }
                else
                {
                    break;
                }

            }
            sw.Close();
            MessageBox.Show("Archivo nuevo creado");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
                
        }
    }
}

