namespace ThemeTussleMoveList
{
    public partial class CharacterSelect : Form
    {
        private Nina ninaForm;
        private Leo leoForm;
        private Charlie charlieForm;
        private Suzie suzieForm;
        public CharacterSelect()
        {
            InitializeComponent();
        }

        private void CharacterSelect_Load(object sender, EventArgs e)
        {
            
        }

        private void NinaBtn_Click(object sender, EventArgs e)
        {
            if (ninaForm == null || ninaForm.IsDisposed)
            {
                ninaForm = new Nina();
                ninaForm.FormClosed += (s, e) => ninaForm = null;
            }
            ninaForm.Show();
            ninaForm.BringToFront();
        }

        private void SuzieBtn_Click(object sender, EventArgs e)
        {
            if (ninaForm == null || ninaForm.IsDisposed)
            {
                ninaForm = new Nina();
                ninaForm.FormClosed += (s, e) => ninaForm = null;
            }
            ninaForm.Show();
            ninaForm.BringToFront();
        }

        private void LeoBtn_Click(object sender, EventArgs e)
        {
            if (ninaForm == null || ninaForm.IsDisposed)
            {
                ninaForm = new Nina();
                ninaForm.FormClosed += (s, e) => ninaForm = null;
            }
            ninaForm.Show();
            ninaForm.BringToFront();
        }

        private void CharlieBtn_Click(object sender, EventArgs e)
        {
            if (ninaForm == null || ninaForm.IsDisposed)
            {
                ninaForm = new Nina();
                ninaForm.FormClosed += (s, e) => ninaForm = null;
            }
            ninaForm.Show();
            ninaForm.BringToFront();
        }
    }
}