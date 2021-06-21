
namespace WinFormsControlLab
{
    partial class ColorChooser
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HexButton = new System.Windows.Forms.RadioButton();
            this.DecButton = new System.Windows.Forms.RadioButton();
            this.BlueBox = new WinFormsControlLab.ChooseColorParametrBox(this.components);
            this.GreenBox = new WinFormsControlLab.ChooseColorParametrBox(this.components);
            this.RedBox = new WinFormsControlLab.ChooseColorParametrBox(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зеленый";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Синий";
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.Location = new System.Drawing.Point(169, 7);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(140, 133);
            this.colorPanel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HexButton);
            this.groupBox1.Controls.Add(this.DecButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Система исчисления";
            // 
            // HexButton
            // 
            this.HexButton.AutoSize = true;
            this.HexButton.Location = new System.Drawing.Point(59, 20);
            this.HexButton.Name = "HexButton";
            this.HexButton.Size = new System.Drawing.Size(44, 17);
            this.HexButton.TabIndex = 1;
            this.HexButton.TabStop = true;
            this.HexButton.Text = "Hex";
            this.HexButton.UseVisualStyleBackColor = true;
            this.HexButton.CheckedChanged += new System.EventHandler(this.HexButton_CheckedChanged);
            // 
            // DecButton
            // 
            this.DecButton.AutoSize = true;
            this.DecButton.Checked = true;
            this.DecButton.Location = new System.Drawing.Point(7, 20);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(45, 17);
            this.DecButton.TabIndex = 0;
            this.DecButton.TabStop = true;
            this.DecButton.Text = "Dec";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.CheckedChanged += new System.EventHandler(this.DecButton_CheckedChanged);
            // 
            // BlueBox
            // 
            this.BlueBox.Location = new System.Drawing.Point(63, 58);
            this.BlueBox.Name = "BlueBox";
            this.BlueBox.Size = new System.Drawing.Size(100, 20);
            this.BlueBox.TabIndex = 5;
            this.BlueBox.Text = "0";
            this.BlueBox.TextChanged += new System.EventHandler(this.BlueBox_TextChanged);
            // 
            // GreenBox
            // 
            this.GreenBox.Location = new System.Drawing.Point(63, 31);
            this.GreenBox.Name = "GreenBox";
            this.GreenBox.Size = new System.Drawing.Size(100, 20);
            this.GreenBox.TabIndex = 4;
            this.GreenBox.Text = "0";
            this.GreenBox.TextChanged += new System.EventHandler(this.GreenBox_TextChanged);
            // 
            // RedBox
            // 
            this.RedBox.Location = new System.Drawing.Point(63, 4);
            this.RedBox.Name = "RedBox";
            this.RedBox.Size = new System.Drawing.Size(100, 20);
            this.RedBox.TabIndex = 3;
            this.RedBox.Text = "0";
            this.RedBox.TextChanged += new System.EventHandler(this.RedBox_TextChanged);
            this.RedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RedBox_KeyPress);
            // 
            // ColorChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.BlueBox);
            this.Controls.Add(this.GreenBox);
            this.Controls.Add(this.RedBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ColorChooser";
            this.Size = new System.Drawing.Size(316, 148);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ChooseColorParametrBox RedBox;
        private ChooseColorParametrBox GreenBox;
        private ChooseColorParametrBox BlueBox;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton HexButton;
        private System.Windows.Forms.RadioButton DecButton;
    }
}
