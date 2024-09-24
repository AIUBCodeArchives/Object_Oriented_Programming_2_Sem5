using StudentDash.Forms;

namespace StudentDash
{
    public partial class start_page : Form
    {
        public start_page()
        {
            InitializeComponent();
        }

        private void start_page_Load(object sender, EventArgs e)
        {
            progressbar_timer.Start();
        }

        private void progressbar_timer_Tick(object sender, EventArgs e)
        {
            if (load_progressbar.Value < 100)
            {
                load_progressbar.Value += 1;
                progressbar_percentage_lbl.Text = load_progressbar.Value.ToString() + "%";
            }
            else
            {
                progressbar_timer.Stop();
                login_page lp = new login_page();
                lp.Visible = true;
                this.Visible = false;
            }
        }

        private void load_progressbar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
