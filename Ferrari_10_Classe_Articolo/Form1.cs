using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferrari_10_Classe_Articolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void OpenForm<MyForm>() where MyForm : Form, new()
        {
            Form viewedForm;
            viewedForm = panelMain.Controls.OfType<MyForm>().FirstOrDefault();
            if (viewedForm == null)
            {
                viewedForm = new MyForm();
                viewedForm.TopLevel = false;
                viewedForm.FormBorderStyle = FormBorderStyle.None;
                viewedForm.Dock = DockStyle.Fill;
                panelMain.Controls.Add(viewedForm);
                panelMain.Tag = viewedForm;
                viewedForm.Show();
                viewedForm.BringToFront();
            }
            else
            {
                viewedForm.BringToFront();
            }
        }
        private void CloseForms()
        {
            Form[] forms = new Form[panelMain.Controls.Count];
            for (int i = 0; i < panelMain.Controls.Count; i++)
            {
                forms[i] = panelMain.Controls[i] as Form;
            }
            foreach (Form form in forms)
            {
                form.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CloseForms();
            OpenForm<Add>();
        }
        private void buttonSpesa_Click(object sender, EventArgs e)
        {
            CloseForms();
            OpenForm<Spesa>();
        }
    }
}
