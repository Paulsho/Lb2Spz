using System;
using System.Windows.Forms;

namespace lb2
{
    public partial class AddDelete : Form
    {
        public AddDelete()
        {
            InitializeComponent();
        }

        public string selectedItem;
        public int number;
        private void btApply_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(numUpDown.Value);
            this.DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void rbStuds_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if(rb.Checked)
            {
                selectedItem = rb.Name;
            }
        }
    }
}
