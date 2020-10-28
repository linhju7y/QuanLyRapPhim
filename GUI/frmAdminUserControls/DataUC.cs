using GUI.frmAdminUserControls.DataUserControl;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.frmAdminUserControls
{
    public partial class DataUC : UserControl
    {
        public DataUC()
        {
            InitializeComponent();
        }

        private void btnScreenTypeUC_Click(object sender, EventArgs e)
        {
          
            pnData.Controls.Clear();
            ScreenTypeUC screenTypeUC = new ScreenTypeUC();
            screenTypeUC.Dock = DockStyle.Fill;
            pnData.Controls.Add(screenTypeUC);
        }

        private void btnCinemaUC_Click(object sender, EventArgs e)
        {
            
            pnData.Controls.Clear();
            CinemaUC cinemaUc = new CinemaUC();
            cinemaUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(cinemaUc);
        }

        private void btnGenreUC_Click(object sender, EventArgs e)
        {
            
            pnData.Controls.Clear();
            GenreUC genreUc = new GenreUC();
            genreUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(genreUc);
        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
           
            pnData.Controls.Clear();
            MovieUC movieUc = new MovieUC();
            movieUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(movieUc);
        }

        private void btnFormatMovieUC_Click(object sender, EventArgs e)
        {
           
            pnData.Controls.Clear();
            FormatMovieUC formatMovieUc = new FormatMovieUC();
            formatMovieUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(formatMovieUc);
        }

        private void btnShowTimesUC_Click(object sender, EventArgs e)
        {
          
            pnData.Controls.Clear();
            ShowTimesUC showTimesUc = new ShowTimesUC();
            showTimesUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(showTimesUc);
        }

        private void btnTicketsUC_Click(object sender, EventArgs e)
        {
          
            pnData.Controls.Clear();
            TicketsUC ticketsUc = new TicketsUC();
            ticketsUc.Dock = DockStyle.Fill;
            pnData.Controls.Add(ticketsUc);
        }
    }
}
