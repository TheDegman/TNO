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
        public MainPage()
        {
            InitializeComponent();
            top_img1.Source = ImageSource.FromResource("TNO.slike.TOP1.png");
            top_img2.Source = ImageSource.FromResource("TNO.slike.top_1.png");
            top_img3.Source = ImageSource.FromResource("TNO.slike.top_1.png");
            desc.Source = ImageSource.FromResource("TNO.slike.description.png");
            features.Source = ImageSource.FromResource("TNO.slike.fea.png");
        }
    }
}
