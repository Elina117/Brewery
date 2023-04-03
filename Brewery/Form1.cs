using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Brewery
{
    public partial class MainForm : Form
    {
        MainForm mainForm;
        public MainForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            DialogResult result = MessageBox.Show("Вы действительно хотите закрыть приложение?", "Завершение программы",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 6;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 9;
        }

        private DataTable CreateTable()
        {
            //Create tables
            DataTable dt = new DataTable("XML.xml");
            //Create columns
            DataColumn id = new DataColumn("id", typeof(int));
            DataColumn sort = new DataColumn("sort", typeof(string));
            DataColumn name = new DataColumn("name", typeof(string));
            DataColumn volum = new DataColumn("volum", typeof(double));
            DataColumn sale = new DataColumn("sale", typeof(int));
            DataColumn done = new DataColumn("done", typeof(int));

            dt.Columns.Add(id);
            dt.Columns.Add(sort); 
            dt.Columns.Add(name);
            dt.Columns.Add(volum);
            dt.Columns.Add(sale);
            dt.Columns.Add(done);

            return dt;

        }

        private DataTable ReadXML()
        {
            DataTable dt = null;

            try
            {
                //input xml file
                XDocument xDoc = XDocument.Load(@"./../../XML.xml");
                //create table
                dt = CreateTable();
                DataRow newRow = null;
                foreach (XElement elm in xDoc.Descendants("beers"))
                {
                    newRow = dt.NewRow();
                    if (elm.HasAttributes)
                    {
                        //проверяем наличие атрибута id
                        if (elm.Attribute("id") != null)
                        {
                            //получаем значение атрибута
                            newRow["id"] = int.Parse(elm.Attribute("id").Value);
                        }
                        if (elm.Element("sort") != null)
                        {
                            //получаем значения элемента name
                            newRow["sort"] = elm.Element("sort").Value;
                        }
                        //проверяем наличие xml элемента name
                        if (elm.Element("name") != null)
                        {
                            //получаем значения элемента name
                            newRow["name"] = elm.Element("name").Value;
                        }
                        if (elm.Element("volum") != null)
                        {
                            newRow["volum"] = int.Parse(elm.Element("volum").Value);
                        }
                        if(elm.Element("sale") != null)
                        {
                            newRow["sale"] = int.Parse(elm.Element("sale").Value);
                        }
                        if (elm.Element("done") != null)
                        {
                            newRow["done"] = int.Parse(elm.Element("done").Value);
                        }
                        //добавляем новую запись в таблицу
                        dt.Rows.Add(newRow);
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

                
    }

        private void button12_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReadXML();
        }
    }

    
}
