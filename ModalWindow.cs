using System;
using System.Windows.Forms;

namespace Bomberman
{
    public partial class ModalWindow : Form
    {
        private FormGame _ParentForm;
        public ModalWindow(FormGame formGame)
        {
            InitializeComponent();
            _ParentForm = formGame;
        }

        private void ModalWindow_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            _ParentForm.ChangeLevel(1);
            this.Close();
        }

        private void middle_Click(object sender, EventArgs e)
        {
            _ParentForm.ChangeLevel(2);
            this.Close();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            _ParentForm.ChangeLevel(3);
            this.Close();
        }
    }
}
