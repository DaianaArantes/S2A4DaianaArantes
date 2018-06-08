using Assignment04.DAClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//-----------------------
//Microsoft Visual Studio C#
//Daiana Arantes
//Conestoga College
//Apr Monday 9, 2018
//-----------------------

namespace Assignment04
{
    public partial class Form1 : Form
    {
        public object PAProvince { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        //Clear all fields to receive new province
        private void buttonNewRec_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "";
            textBoxPrvCd.Text = "";
            textBoxName.Text = "";
            textBoxCntryCd.Text = "";
            textBoxTaxCd.Text = "";
            textBoxTaxRate.Text = "";
            checkBoxFedTax.Checked = false;
        }

        //Save a new province, or save an updated province
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DAProvince province = new DAProvince();
            province.ProvinceCode = textBoxPrvCd.Text;
            province.Name = textBoxName.Text;
            province.CountryCode = textBoxCntryCd.Text;
            province.TaxCode = textBoxTaxCd.Text;
            province.TaxRate = Convert.ToDouble(textBoxTaxRate.Text);
            province.IncludesFederalTax = checkBoxFedTax.Checked;

            //If the province does not exist on file, create new
            if(province.DAGetByProvinceCode(province.ProvinceCode) == null)
            {
                try
                {
                    province.DAAdd();
                    UpdateListBoxDisplay(province);
                }
                catch(Exception ex)
                {
                    labelDisplay.Text += ex.Message;
                }
            }
            //If province exist on file, update changes
            else
            {
                try
                {
                    province.DAUpdate();
                }
                catch (Exception ex)
                {
                    labelDisplay.Text += ex.Message;
                }
            }          
        }

        //Update list box after deleting or saving province
        private void UpdateListBoxDisplay(DAProvince province = null)
        {
            listBoxDisplay.Items.Clear();

            List<DAProvince> provinceList = new List<DAProvince>();

            if (province != null)
            {
                provinceList = province.DAGetProvinces();

                foreach (DAProvince item in provinceList)
                {
                    listBoxDisplay.Items.Add(item.ProvinceCode);
                }
                listBoxDisplay.SelectedItem = province.ProvinceCode;
            }
            else
            {
                province = new DAProvince();
                provinceList = province.DAGetProvinces();

                foreach (DAProvince item in provinceList)
                {
                    listBoxDisplay.Items.Add(item.ProvinceCode);
                }
                listBoxDisplay.SelectedIndex = -1;
            }
            
        }
        //Delete a province from file
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "";
            DAProvince province = new DAProvince();
            province.ProvinceCode = textBoxPrvCd.Text;
            province.Name = textBoxName.Text;
            province.CountryCode = textBoxCntryCd.Text;
            province.TaxCode = textBoxTaxCd.Text;
            province.TaxRate = Convert.ToDouble(textBoxTaxRate.Text);
            province.IncludesFederalTax = checkBoxFedTax.Checked;
            try
            {
                province.DADelete();
                UpdateListBoxDisplay();
                textBoxPrvCd.Text = "";
                textBoxName.Text = "";
                textBoxCntryCd.Text = "";
                textBoxTaxCd.Text = "";
                textBoxTaxRate.Text = "";
                checkBoxFedTax.Checked = false;
                labelDisplay.Text += "Province deleted\n";
            }
            catch(Exception ex)
            {
                labelDisplay.Text += ex.Message;
            }            
        }

        //When selectedIndex changes, fill the fields with the info from province selected
        private void listBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {          
            DAProvince province = new DAProvince();
            province = province.DAGetByProvinceCode
                (listBoxDisplay.SelectedItem.ToString());
            textBoxPrvCd.Text = province.ProvinceCode;
            textBoxName.Text = province.Name;
            textBoxCntryCd.Text = province.CountryCode;
            textBoxTaxCd.Text = province.TaxCode;
            textBoxTaxRate.Text = province.TaxRate.ToString();
            checkBoxFedTax.Checked = province.IncludesFederalTax;
        }

        //When form loads, display provinces on file
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListBoxDisplay();
        }

        //Close the form
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
