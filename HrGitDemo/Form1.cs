using System;
using System.Drawing;
using System.Windows.Forms;

namespace HrGitDemo
{
    public class Form1 : Form
    {
        private readonly Label lblTitle;
        private readonly Button btnOpenForm2;
        private readonly Button btnCounter;
        private int clicks;

        public Form1()
        {
            Text = "Лабораторная работа 4";
            ClientSize = new Size(360, 200);
            StartPosition = FormStartPosition.CenterScreen;

            lblTitle = new Label
            {
                Text = "Главная форма",
                Font = new Font("Segoe UI", 14f),
                AutoSize = true,
                Location = new Point(20, 20)
            };

            btnOpenForm2 = new Button
            {
                Text = "Перейти на вторую форму",
                Size = new Size(200, 35),
                Location = new Point(20, 70)
            };
            btnOpenForm2.Click += BtnOpenForm2_Click;

            btnCounter = new Button
            {
                Text = "Нажатий: 0",
                Size = new Size(200, 35),
                Location = new Point(20, 120)
            };
            btnCounter.Click += BtnCounter_Click;

            Controls.Add(lblTitle);
            Controls.Add(btnOpenForm2);
            Controls.Add(btnCounter);
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            clicks++;
            btnCounter.Text = "Нажатий: " + clicks;
        }

        private void BtnOpenForm2_Click(object sender, EventArgs e)
        {
            using (var form2 = new Form2())
            {
                form2.ShowDialog(this);
            }
        }
    }
}
