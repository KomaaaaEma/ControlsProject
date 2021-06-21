using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLab
{
    public partial class ColorChooser : UserControl
    {
        #region Основные цвтеа
        /// <summary>
        /// Красный
        /// </summary>
        int r;
        /// <summary>
        /// Зеленый
        /// </summary>
        int g;
        /// <summary>
        /// Синий
        /// </summary>
        int b;
        #endregion
        public ColorChooser()
        {
            InitializeComponent();
            r = CurrentColor.R;
            g = CurrentColor.G;
            b = CurrentColor.B;
            RedBox.Text = r.ToString();
            GreenBox.Text = g.ToString();
            BlueBox.Text = b.ToString();
        }
        /// <summary>
        /// Текущий цвет
        /// </summary>
        public Color CurrentColor
        {
            get
            {
                return colorPanel.BackColor;
            }
            set
            {
                colorPanel.BackColor = (Color)value;
            }
        }

        private void RedBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(RedBox.Text, out r)) ;
            else int.TryParse(RedBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out r);
            CurrentColor = Color.FromArgb(r, g, b);
        }

        private void GreenBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(GreenBox.Text, out g)) ;
            else int.TryParse(GreenBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out g);
            CurrentColor = Color.FromArgb(r, g, b);
        }

        private void BlueBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(BlueBox.Text, out b)) ;
            else int.TryParse(BlueBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out b);
            CurrentColor = Color.FromArgb(r, g, b);
        }
        private void DecButton_CheckedChanged(object sender, EventArgs e)
        {
            if(DecButton.Checked == true)
            {
                int rDex = int.Parse(RedBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier);
                int gDex = int.Parse(GreenBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier);
                int bDex = int.Parse(BlueBox.Text, System.Globalization.NumberStyles.AllowHexSpecifier);
                string rStr = rDex.ToString();
                string gStr = gDex.ToString();
                string bStr = bDex.ToString();
                RedBox.Text = rStr;
                GreenBox.Text = gStr;
                BlueBox.Text = bStr;
            }
        }
        private void HexButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HexButton.Checked == true)
            {
                int rHex = int.Parse(RedBox.Text);
                int gHex = int.Parse(GreenBox.Text);
                int bHex = int.Parse(BlueBox.Text);
                string rStr = rHex.ToString("x");
                string gStr = gHex.ToString("x");
                string bStr = bHex.ToString("x");
                RedBox.Text = rStr;
                GreenBox.Text = gStr;
                BlueBox.Text = bStr;
            }
        }

        private void RedBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DecButton.Checked == true)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)))
                    e.Handled = true;
                base.OnKeyPress(e);
            }
            else if(HexButton.Checked == true)
            {
                base.OnKeyPress(e);
            }
        }
    }
}
