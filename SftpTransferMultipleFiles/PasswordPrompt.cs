using System;
using System.Windows.Forms;

namespace ComponentPro.Samples
{
    public partial class PasswordPrompt : Form
    {
        public PasswordPrompt()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        public string Password
        {
            get
            {
                return txtPassword.Text;
            }
        }

        public string Message
        {
            get { return lblMsg.Text; }
            set { lblMsg.Text = value; }
        }

        /// <summary>
        /// Handles the OK button's Click event.
        /// </summary>
        /// <param name="sender">The button object.</param>
        /// <param name="e">The event arguments.</param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}