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
    public partial class Add : Form
    {
        public Add()
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
        private void NascondiTutto()
        {
            labelArticoli.Visible = false;
            buttonAli.Visible = false;
            buttonNonAli.Visible = false;
            buttonFresh.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void labelArticoli_Click(object sender, EventArgs e)
        {

        }

        private void buttonNonAli_Click(object sender, EventArgs e)
        {
            NascondiTutto();
            OpenForm<NonAli>();
        }
        private void buttonAli_Click(object sender, EventArgs e)
        {
            NascondiTutto();
            //OpenForm<Ali>();
        }
        private void buttonFresh_Click(object sender, EventArgs e)
        {
            NascondiTutto();
            //OpenForm<Fresh>();
        }
    }
}
