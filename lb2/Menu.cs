using System;
using System.Windows.Forms;
using System.Linq;

namespace lb2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public University selected;

        private void lbUniversities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbUniversities.SelectedIndex != -1)
            {
                selected = (University)lbUniversities.Items[lbUniversities.SelectedIndex];
                lN.Text = selected.Name;
                lF.Text = selected.Faculty.ToString();
                lL.Text = selected.Labs.ToString();
                lLc.Text = selected.Lectures.ToString();
                lS.Text = selected.Students.ToString();
                lT.Text = selected.Teachers.ToString();
            }
        }

        private void btAddUniversity_Click(object sender, EventArgs e)
        {
            var dialog = new AddUniversity();
            dialog.ShowDialog();
            if(dialog.DialogResult == DialogResult.OK && dialog.addedUniversity != null)
            {
                lbUniversities.Items.Add(dialog.addedUniversity);
            }
        }

        private void btDeleteUniversity_Click(object sender, EventArgs e)
        {
            lbUniversities.Items.RemoveAt(lbUniversities.SelectedIndex);
            lF.Text = string.Empty;
            lL.Text = string.Empty;
            lLc.Text = string.Empty;
            lS.Text = string.Empty;
            lT.Text = string.Empty;
            lE.Text = string.Empty;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddDelete();
            dialog.Text = "Додавання";
            dialog.ShowDialog();
            if(dialog.DialogResult == DialogResult.OK)
            {
                switch(dialog.selectedItem)
                {
                    case "rbStuds":
                        selected.AddStudents(dialog.number);
                            break;
                    case "rbTeachs":
                        selected.AddTeachers(dialog.number);
                        break;
                    case "rbEngin":
                        selected.AddEngineers(dialog.number);
                        break;
                    case "rbLecs":
                        selected.AddLectures(dialog.number);
                        break;
                    case "rbLabs":
                        selected.AddLabs(dialog.number);
                        break;
                    default:
                        break;
                }
            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            var dialog = new AddDelete();
            dialog.Text = "Видалення";
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                switch (dialog.selectedItem)
                {
                    case "rbStuds":
                        selected.DeleteStudents(dialog.number);
                        break;
                    case "rbTeachs":
                        selected.DeleteTeachers(dialog.number);
                        break;
                    case "rbEngin":
                        selected.DeleteEngineers(dialog.number);
                        break;
                    case "rbLecs":
                        selected.DeleteLectures(dialog.number);
                        break;
                    case "rbLabs":
                        selected.DeleteLabs(dialog.number);
                        break;
                    default:
                        break;
                }
            }
        }

        private void btCompare_Click(object sender, EventArgs e)
        {
            var dialog = new CompareMerge();
            dialog.Text = "Порівняння";
        
            foreach (var item in lbUniversities.Items)
            {
                dialog.lbFirst.Items.Add(item);
                dialog.lbSecond.Items.Add(item);
            }
            dialog.ShowDialog();
            if (dialog.index1 != -1 && dialog.index2 != -1)
            {
                if(University.Equals(lbUniversities.Items[dialog.index1], lbUniversities.Items[dialog.index2]))
                {
                    MessageBox.Show("Університети однакові");
                }
                else
                {
                    MessageBox.Show("Університети не однакові");
                }
            }
        }

        private void btMerge_Click(object sender, EventArgs e)
        {
            var dialog = new CompareMerge();
            dialog.Text = "Злиття";
            foreach (var item in lbUniversities.Items)
            {
                dialog.lbFirst.Items.Add(item);
                dialog.lbSecond.Items.Add(item);
            }
            dialog.ShowDialog();
            if(dialog.DialogResult == DialogResult.OK)
            {
                if (dialog.index1 != -1 && dialog.index2 != -1 && dialog.index1 != dialog.index2)
                {
                    var u1 = (University)lbUniversities.Items[dialog.index1];
                    var u2 = (University)lbUniversities.Items[dialog.index2];
                    var newUniversity = (u1 + u2).Clone();
                    lbUniversities.Items.Remove(u1);
                    lbUniversities.Items.Remove(u2);
                    lbUniversities.Items.Add(newUniversity);

                }
            }
        }
    }
}

