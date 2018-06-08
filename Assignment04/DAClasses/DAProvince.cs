using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

//-----------------------
//Microsoft Visual Studio C#
//Daiana Arantes
//Conestoga College
//Apr Monday 9, 2018
//-----------------------

namespace Assignment04.DAClasses
{
    class DAProvince
    {
        public string ProvinceCode { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string TaxCode { get; set; }
        public Double TaxRate { get; set; }
        public Boolean IncludesFederalTax { get; set; }
        public Boolean IsEdit { get; set; }

        private StreamReader sr;
        private StreamWriter sw;

        //Path way to file Province.txt
        public string Path { get { return "C:\\Province.txt"; } }

        //Method to create the output record
        public override string ToString()
        {
            return
                ProvinceCode + ";" +
                Name + ";" +
                CountryCode + ";" +
                TaxCode + ";" +
                TaxRate + ";" +
                IncludesFederalTax;
        }

        //Creates a Province object from a record read in from the file
        public DAProvince DAParseProvince(string parameter)
        {
            DAProvince province = new DAProvince();
            try
            {
                string[] provinceArr = parameter.Split(';');

                province.ProvinceCode = provinceArr[0];
                province.Name = provinceArr[1];
                province.CountryCode = provinceArr[2];
                province.TaxCode = provinceArr[3];
                province.TaxRate = Convert.ToDouble(provinceArr[4]);
                province.IncludesFederalTax = 
                    Convert.ToBoolean(provinceArr[5]);

                return province;
            }
            catch (Exception ex)
            {
                throw new Exception("Not a province record\n");
            }
        }

        //Method that receive the provinceCode and check if its in the file
        public DAProvince DAGetByProvinceCode(string provinceCode)
        {
            DAProvince province = null;
            sr = new StreamReader(Path);
            while (!sr.EndOfStream)
            {
                string[] provinceArr = sr.ReadLine().Split(';');

                if(provinceCode == provinceArr[0])
                {
                    province = new DAProvince();

                    province.ProvinceCode = provinceArr[0];
                    province.Name = provinceArr[1];
                    province.CountryCode = provinceArr[2];
                    province.TaxCode = provinceArr[3];
                    province.TaxRate = Convert.ToDouble(provinceArr[4]);
                    province.IncludesFederalTax = 
                        Convert.ToBoolean(provinceArr[5]);
                }  
            }
            sr.Close();
            return province;
        }

        //Method that receive Name and check if it is in the file
        public DAProvince DAGetByProvinceName(string provinceName)
        {
            DAProvince province = null;
            sr = new StreamReader(Path);
            while (!sr.EndOfStream)
            {
                string[] provinceArr = sr.ReadLine().Split(';');

                if (provinceName == provinceArr[1])
                {
                    province = new DAProvince();
                    province.ProvinceCode = provinceArr[0];
                    province.Name = provinceArr[1];
                    province.CountryCode = provinceArr[2];
                    province.TaxCode = provinceArr[3];
                    province.TaxRate = Convert.ToDouble(provinceArr[4]);
                    province.IncludesFederalTax = 
                        Convert.ToBoolean(provinceArr[5]);
                }
            }
            sr.Close();
            return province;
        }
        //Mehod that returns a list with all province files from Province.txt
        public List<DAProvince> DAGetProvinces()
        {
            List<DAProvince>  provinceList  = new List<DAProvince>();
            DAProvince province;
            sr = new StreamReader(Path);
            while (!sr.EndOfStream)
            {
                string[] provinceArr = sr.ReadLine().Split(';');
                province = new DAProvince();
                province.ProvinceCode = provinceArr[0];
                province.Name = provinceArr[1];
                province.CountryCode = provinceArr[2];
                province.TaxCode = provinceArr[3];
                province.TaxRate = Convert.ToDouble(provinceArr[4]);
                province.IncludesFederalTax = Convert.ToBoolean(provinceArr[5]);
                provinceList.Add(province);
            }
            sr.Close();
            return provinceList;
        }
        //Method that validate and reformat inputs from user
        private void DAEdit()
        {
            string errorMessage = "";
            Regex regex;
            //Trim all string fields
            if (ProvinceCode.Trim() == null)
            {
                ProvinceCode = "";
            }
            if (Name.Trim() == null)
            {
                Name = "";
            }
            if (CountryCode.Trim() == null)
            {
                CountryCode = "";
            }
            if (TaxCode.Trim() == null)
            {
                TaxCode = "";
            }
            //Checks Name
            if(Name == "")
            {
                errorMessage += "Name is required\n";
            }
            //Checks Province Code
            regex = new Regex("^[a-zA-Z]{2}");
            if(!regex.IsMatch(ProvinceCode))
            {
                errorMessage += "Province Code is required and must be" +
                    " 2 letters\n";
            }
            else if (regex.IsMatch(ProvinceCode))
            {
                ProvinceCode = ProvinceCode.ToUpper();
            }
            //Checks Country Code
            if (!regex.IsMatch(CountryCode))
            {
                errorMessage += "Country Code is required and must be" +
                    " 2 letters\n";
            }
            else if (regex.IsMatch(CountryCode))
            {
                CountryCode = CountryCode.ToUpper();
            }

            if (TaxCode != "")
            {
                TaxCode = TaxCode.ToUpper();
            }
            //Checks Tax Code
            regex = new Regex("^[a-zA-Z]*");
            if(!regex.IsMatch(TaxCode))
            {
                errorMessage += "Tax Code must be only letters\n";
            }
            //Checks Tax Rate
            if(TaxCode == "" && TaxRate != 0)
            {
                errorMessage += "Insert first a Tax Code, then a Tax Rate\n";
            }
            else if(TaxCode != "" && (TaxRate < 0 || TaxRate > 1))
            {
                errorMessage += "Tax Rate must be between 0 and 1, inclusive\n";
            }
            //Checks federal tax
            if(TaxRate == 0 && IncludesFederalTax)
            {
                errorMessage += "Includes Federal Tax must not be selected" +
                    " if Tax Rate is zero\n";
            }
            //Checks if Province code already exists
            if(DAGetByProvinceCode(ProvinceCode) != null)
            {
                IsEdit = true;
            }
            else
            {
                IsEdit = false;
            }
            //Checks to update
            if (
                DAGetByProvinceName(Name) != null &&
                (DAGetByProvinceCode(ProvinceCode) == null ||
                DAGetByProvinceCode(ProvinceCode).ProvinceCode !=
                DAGetByProvinceName(Name).ProvinceCode))
            {
                errorMessage += "The name entered already exists!\n";
            }
            if (errorMessage != "")
            {
                throw new Exception(errorMessage);
            }
        }
        //Method to Add a new province to file
        public void DAAdd ()
        {
            try
            {
                DAEdit();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message,ex);
            }

            if(IsEdit == false)
            {
                sw = new StreamWriter(Path, append: true);
                sw.WriteLine(ToString());
            }
            else
            {
                throw new Exception("Province Code Already on file\n");
            }
            sw.Flush();
            sw.Close();
        }
        //Method to delete a province from file
        public void DADelete ()
        {
            List<DAProvince> provinceList = new List<DAProvince>();
            DAProvince province = new DAProvince();
            sr = new StreamReader(Path);
            while (!sr.EndOfStream)
            {
                string[] provinceArr = sr.ReadLine().Split(';');
                province = new DAProvince();
                province.ProvinceCode = provinceArr[0];
                province.Name = provinceArr[1];
                province.CountryCode = provinceArr[2];
                province.TaxCode = provinceArr[3];
                province.TaxRate = Convert.ToDouble(provinceArr[4]);
                province.IncludesFederalTax = Convert.ToBoolean(provinceArr[5]);

                if (this.ProvinceCode != province.ProvinceCode)
                {
                    //Add on the list all the provinces 
                    //but not the one chosen to delete
                    provinceList.Add(province);
                }
            }
            sr.Close();
            //Delete the path
            DeleteFile(Path);
            //Create a new path and fill it with the
            // provinces but not the one deleted
            sw = new StreamWriter(Path, append: true);
            if (provinceList.Count == 0)
            {
                sw.Write("");
            }
            else
            {
                foreach (DAProvince item in provinceList)
                {
                    sw.WriteLine(
                        item.ProvinceCode + ";" +
                        item.Name + ";" +
                        item.CountryCode + ";" +
                        item.TaxCode + ";" +
                        item.TaxRate + ";" +
                        item.IncludesFederalTax
                        );
                }
            }
            sw.Flush();
            sw.Close();
        }
        //Method to delete a file
        public void DeleteFile (string path)
        {
            if(File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                throw new Exception("Province Code does not exist\n");
            }
        }
        //Method to update a province 
        public void DAUpdate()
        {
            DAEdit();
            if(IsEdit == true)
            { 
                try
                {
                    DADelete();
                    DAAdd();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }  
            }
        }
    }
}
