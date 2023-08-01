using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2WinApp
{
    public partial class LookupForm : Form
    {
        //Create example object for function testing
        private object exampleObject = new
        {
            fruit = new
            {
                fruit1 = "Orange",
                fruit2 = "Apple",
            },
             vegetables = new
             {
                 vegetables1 = "Tomato",
                 vegetables2 = "Potato",
             }
        };
        public LookupForm()
        {
            InitializeComponent();
        }

        private void LookupForm_Load(object sender, EventArgs e)
        {
            // Initial UI setup
            lblResult.Text = "";
            txtLookupPath.Text = "";
            lblObject.Text = exampleObject.ToString();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            //set textbox value to a new variable
            string lookupPath = txtLookupPath.Text.Trim();
            //only execute function if there is text in the lookup textbox
            if (lookupPath != "")
            {
                object value = ObjectUtils.Lookup(exampleObject, lookupPath);
                //if my function returns null (returns null in case of errors) type out error message as result, otherwise type result 
                lblResult.Text = value != null ? value.ToString() : "Value not found or invalid path";
            }
        }
    }
    public static class ObjectUtils
    {
        public static object Lookup(object obj, string path)
        {
            //a try catch block for error handling
            try
            {
                //split textbox input into strings every time a dot is found
                var keys = path.ToLower().Split('.');
                var value = obj;

                //for every string in keys try to find a matching value in our object
                foreach (var key in keys)
                {
                    var type = value.GetType();
                    var propertyInfo = type.GetProperty(key);

                    if (propertyInfo == null)
                    {
                        throw new ArgumentException($"Property '{key}' not found in object");
                    }

                    value = propertyInfo.GetValue(value);
                }

                return value;
            }
            catch (Exception)
            {
                return null; // Return null in case of any errors
            }
        }
    }
}
