using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TNO
{
    public partial class MainPage : CarouselPage
    {
        int i = 1;
        public MainPage()
        {
            InitializeComponent();
            top_img1.Source = ImageSource.FromResource("TNO.slike.TOP1.png");
           
            desc.Source = ImageSource.FromResource("TNO.slike.description.png");
            features.Source = ImageSource.FromResource("TNO.slike.fea.png");
            //galerija();
            Extras.Source = ImageSource.FromResource("TNO.slike.extras.png");
            
        }
        private void galerija()
        {
            InitializeComponent();
            galery.Source = ImageSource.FromResource(string.Format($"TNO.galerija.{i}.jpg"));
        }

        private void next_Clicked(object sender, EventArgs e)
        {
            if (i == 6)
            {
                i = 0;
            }
            galerija();
            i++;

        }

        private void previous_Clicked(object sender, EventArgs e)
        {
            if (i==0)
            {
                i = 6;

            }
            galerija();
            i--;

        }
    }
}
