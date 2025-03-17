
using DHEA_CHARISSED_BARTE_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DHEA_CHARISSED_BARTE_GUI
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Barte Dhea";
            StudentAgeLabel.Text = "22";
            StudentAddressLabel.Text = "Cadre Site";
            StudentContactLabel.Text = "0950365790";
            StudentEmailLabel.Text = "dheabarte66@gmail.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Hacel Barte";
            ParentContactLabel.Text = "09074260127";
            HobbiesLabel.Text = "Singing";
            NicknameLabel.Text = "beay";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}