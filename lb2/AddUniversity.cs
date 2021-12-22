using System;
using System.Windows.Forms;

namespace lb2
{
    public partial class AddUniversity : Form
    {
        public AddUniversity()
        {
            InitializeComponent();
        }
        public University addedUniversity;

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                addedUniversity = new University
                (tbName.Text,
                 Convert.ToInt32(numUpDownFacs.Value),
                 Convert.ToInt32(numUpDownLabs.Value),
                 Convert.ToInt32(numUpDownLecs.Value),
                 Convert.ToInt32(numUpDownStuds.Value),
                 Convert.ToInt32(numUpDownTeachs.Value),
                 Convert.ToInt32(numUpDownEngin.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;
        }

    }
}
