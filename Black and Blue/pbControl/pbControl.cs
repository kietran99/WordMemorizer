using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbControl
{
    public partial class pbControl: PictureBox
    {
        public pbControl()
        {
            InitializeComponent();
        }

        private Image normalImage;
        public Image NormalImage
        {
            get { return normalImage; }
            set { normalImage = value; }
        }

        private Image hoverImage;
        public Image HoverImage
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }

        private void pbControl_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void pbControl_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
