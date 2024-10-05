using System;
using System.Windows.Forms;

namespace Student_Info
{
    public partial class Form_Student_info : Form
    {
        private string id;
        private string name;
        private string surname;

        public Form_Student_info()
        {
            InitializeComponent();
        }

        private void button_SUBMIT_Click(object sender, EventArgs e)
        {

            SetID(textBox1.Text);
            SetName(textBox2.Text);
            SetSurname(textBox3.Text);

            
            if (string.IsNullOrWhiteSpace(GetID()) || string.IsNullOrWhiteSpace(GetName()) || string.IsNullOrWhiteSpace(GetSurname()))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            string ID = $"{GetID()}";
            string Name = $"{GetName()}";
            string Surname = $"{GetSurname()}";

            listBox_StudentID.Items.Add(ID);  
            listBox_LASTNAME.Items.Add(Surname);
            listBox_FIRSTNAME.Items.Add(Name);



            ClearFields();
        }


        void SetID(string id)
        {
            this.id = id;
        }

        string GetID()
        {
            return this.id;
        }

        void SetName(string name)
        {
            this.name = name;
        }

        string GetName()
        {
            return this.name;
        }

        void SetSurname(string surname)
        {
            this.surname = surname;
        }

        string GetSurname()
        {
            return this.surname;
        }


        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
