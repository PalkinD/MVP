using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labArch
{
    public partial class RegistrationForm : Form,IRegistrationView
    {
        public event Action Registration;
        public int Token { get
            {
                int token;
                try
                {
                    token = Convert.ToInt32(tokenTextBox.Text);
                }catch(Exception ex)
                {
                    token = -1;
                }
                return token;
            } }

        public string Password { get => passwordTextBox.Text; }

        public string RePassword { get => repeatPasswordTextBox.Text; }
        public string FullName { get => fullNameTextBox.Text; }
        public string Rank { get => rankTextBox.Text; }
        public string Position { get => positionTextBox.Text; }

        public RegistrationForm()
        {
            InitializeComponent();
            registr.Click += (sender, args) => Invoke(Registration);
        }
        public new void Show()
        {
            this.ShowDialog();
        }
        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
        private void Invoke(Action invokeEvent)
        {
            if (invokeEvent != null)
            {
                invokeEvent();
            }
        }
    }
}
