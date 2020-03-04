using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Movie_List_Basic_Challenge
{
    class Movie
    {
        public string Title { get; set; }
        public int ReleaseYear { get; set; }

        public Movie()
        {

        }

        public Movie(string myTitle, int myReleaseYear)
        {
            this.Title = myTitle;
            this.ReleaseYear = myReleaseYear;
        }

        public void ShowDetails()
        {
            string info = "Ttile: " + this.Title;
            info += "\nRelease Year:" + this.ReleaseYear;
            MessageBox.Show(info);
        }
    }
}
