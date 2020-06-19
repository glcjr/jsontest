using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jsontest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            try
            { 
                person.Age = Int32.Parse(txtAge.Text);
            }
            catch
            {
                person.Age = 0;
            }            
            person.Gender = cbGender.Text;
            txtJson.Text = Person.Serialize(person);
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            Person person = Person.Deserialize(txtJson.Text);
            txtName.Text = person.Name;
            txtAge.Text = person.Age.ToString();
            cbGender.Text = person.Gender;

        }
    }
}
