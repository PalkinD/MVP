using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labArch
{
    public partial class LoginForm : Form, ILoginView
    {
        public event Action Login;
        public event Action Registration;
        public int Token { get => Convert.ToInt32(tokenTextBox.Text); }
        public string Password { get => passwordTextBox.Text; }
        public LoginForm()
        {
            InitializeComponent();
            enterButton.Click += (sender, args) => Invoke(Login);
            registrationButton.Click += (sender, args) => Invoke(Registration);
        }
       public new void Show()
        {
            Application.Run(this);
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
