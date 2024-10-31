using System;
using System.Drawing;
using System.Windows.Forms;

namespace Infix_to_Postfix
{
    
    public partial class Form1 : Form
    {
        Class.ConvertToInfix _convertToInfix;
        Class.ConvertToPostfix _convertToPostfix;
        Class.ConvertToPrefix _convertToPrefix;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InfixCheckBox.CheckState = CheckState.Checked;
            CheckingCheckBoxes();
        }
        private void CheckingCheckBoxes()
        {
            if(InfixCheckBox.CheckState == CheckState.Checked)
            {
                txtIn.ReadOnly = false;
                txtPost.ReadOnly = true;
                txtPre.ReadOnly = true;
                txtIn.Text = "";
                txtPost.Text = @"Disabled";
                txtPre.Text = @"Disabled";
            }
            else if (PostfixCheckBox.CheckState == CheckState.Checked)
            {
                txtIn.ReadOnly = true;
                txtPost.ReadOnly = false;
                txtPre.ReadOnly = true;
                txtIn.Text = @"Disabled";
                txtPost.Text = "";
                txtPre.Text = @"Disabled";
            }
            else if(PrefixCheckBox.CheckState == CheckState.Checked)
            {
                txtIn.ReadOnly = true;
                txtPost.ReadOnly = true;
                txtPre.ReadOnly = false;
                txtIn.Text = @"Disabled";
                txtPost.Text = @"Disabled";
                txtPre.Text = "";
            }
            else
            {
                txtIn.ReadOnly = true;
                txtPost.ReadOnly = true;
                txtPre.ReadOnly = true;
                txtIn.Text = @"Disabled";
                txtPost.Text = @"Disabled";
                txtPre.Text = @"Disabled";
            }
        }

        private void InfixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PrefixCheckBox.CheckState = CheckState.Unchecked;
            PostfixCheckBox.CheckState = CheckState.Unchecked;
            CheckingCheckBoxes();
        }

        private void PostfixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InfixCheckBox.CheckState = CheckState.Unchecked;
            PrefixCheckBox.CheckState = CheckState.Unchecked;
            CheckingCheckBoxes();
        }

        private void PrefixCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InfixCheckBox.CheckState = CheckState.Unchecked;
            PostfixCheckBox.CheckState = CheckState.Unchecked;
            CheckingCheckBoxes();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (InfixCheckBox.CheckState == CheckState.Checked)
            {
                resInfix.Text = txtIn.Text;

                _convertToPostfix = new Class.ConvertToPostfix(txtIn.Text, 1);
                resPostfix.Text = _convertToPostfix.ReturnResult();

                _convertToPrefix = new Class.ConvertToPrefix(txtIn.Text, 1);
                resPrefix.Text = _convertToPrefix.ReturnResult();
            }
            else if (PostfixCheckBox.CheckState == CheckState.Checked)
            {
                resPostfix.Text = txtPost.Text;

                _convertToInfix = new Class.ConvertToInfix(txtPost.Text, 2);
                resInfix.Text = _convertToInfix.ReturnResult();

                _convertToPrefix = new Class.ConvertToPrefix(_convertToInfix.ReturnResult(), 1);
                resPrefix.Text = _convertToPrefix.ReturnResult();
            }
            else if (PrefixCheckBox.CheckState == CheckState.Checked)
            {
                _convertToPostfix = new Class.ConvertToPostfix(txtPre.Text, 3);
                resInfix.Text = _convertToPostfix.ReturnResult();

                _convertToInfix = new Class.ConvertToInfix(txtPre.Text, 3);
                resInfix.Text = _convertToInfix.ReturnResult();
            }
            else
            {
                MessageBox.Show(@"None of the checkboxes are active!
                Please activate a checkbox!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void btnConvert_MouseHover(object sender, EventArgs e)
        {
            btnConvert.BackColor = Color.Yellow;
            btnConvert.ForeColor = Color.Black;
        }

        private void btnConvert_MouseLeave(object sender, EventArgs e)
        {
            btnConvert.BackColor = Color.DarkGreen;
            btnConvert.ForeColor = Color.Yellow;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            switch (InfixCheckBox.CheckState)
            {
                case CheckState.Checked:
                    txtIn.Text = "";
                    break;
                case CheckState.Unchecked:
                    txtIn.Text = @"Disabled";
                    break;
            }
            switch (PostfixCheckBox.CheckState)
            {
                case CheckState.Checked:
                    txtPost.Text = "";
                    break;
                case CheckState.Unchecked:
                    txtPost.Text = @"Disabled";
                    break;
            }
            switch (PrefixCheckBox.CheckState)
            {
                case CheckState.Checked:
                    txtPre.Text = "";
                    break;
                case CheckState.Unchecked:
                    txtPre.Text = @"Disabled";
                    break;
            }
            resInfix.Text = "";
            resPostfix.Text = "";
            resPrefix.Text = "";
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Yellow;
            btnClear.ForeColor = Color.Black;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.DarkGreen;
            btnClear.ForeColor = Color.Yellow;
        }
    }
}
