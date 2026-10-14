using System.Drawing;
using System.Windows.Forms;

namespace HrGitDemo
{
    public class Form2 : Form
    {
        public Form2()
        {
            Text = "Вторая форма";
            ClientSize = new Size(360, 200);
            StartPosition = FormStartPosition.CenterParent;

            var lblInfo = new Label
            {
                Text = "Это вторая форма.",
                Font = new Font("Segoe UI", 12f),
                AutoSize = true,
                Location = new Point(20, 20)
            };

            var btnBack = new Button
            {
                Text = "Назад",
                Size = new Size(100, 35),
                Location = new Point(20, 70)
            };
            btnBack.Click += (s, e) => Close();

            Controls.Add(lblInfo);
            Controls.Add(btnBack);
        }
    }
}
