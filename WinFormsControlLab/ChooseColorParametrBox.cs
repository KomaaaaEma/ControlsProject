using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace WinFormsControlLab
{
    public partial class ChooseColorParametrBox : TextBox
    {
        public ChooseColorParametrBox()
        {
            InitializeComponent();
            Text = "";
        }

        public ChooseColorParametrBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        ///
        protected override void OnTextChanged(EventArgs e)
        {
            int x;
            //Данное условие обеспечит, что строка никогда не будет без числового значения, а то есть
            //всегда можно будет получить какой-либо цвет
            if (Text == "") Text = "0";
            //Проверка на значение строки состоящей из десятичных чисел
            else if (int.TryParse(Text, out x))
            {
                if (x < 0) Text = "0";
                if (x > 255) Text = "255";
            }
            //Проверка на значение строки состоящей из шестнадцетиричных чисел
            else
            {
                int.TryParse(Text, System.Globalization.NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture, out x);                
                if (x < 0) Text = "0";
                if (x > 255) Text = "ff";
            }
            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (Char.ToUpper(e.KeyChar) <= 'F' && Char.ToUpper(e.KeyChar) >= 'A')) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);
        }
    }
}
