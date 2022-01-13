using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaBD_Banca_de_actiuni.ContentForms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void OnLogoutClick(object sender, EventArgs e)
        {
            MainForm.Instance.LogOut();
            MainForm.Instance.OpenContentForm(new ContentForms.LoginForm());
        }
    }
}
