
namespace ControlsProject2
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathSelect3 = new WinFormsControlLab.FilePathSelect();
            this.filePathSelect2 = new WinFormsControlLab.FilePathSelect();
            this.filePathSelect1 = new WinFormsControlLab.FilePathSelect();
            this.numberBox1 = new WinFormsControlLab.NumberBox(this.components);
            this.colorChooser1 = new WinFormsControlLab.ColorChooser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // filePathSelect3
            // 
            this.filePathSelect3.FileName = "";
            this.filePathSelect3.Location = new System.Drawing.Point(152, 95);
            this.filePathSelect3.Name = "filePathSelect3";
            this.filePathSelect3.Size = new System.Drawing.Size(284, 27);
            this.filePathSelect3.TabIndex = 4;
            // 
            // filePathSelect2
            // 
            this.filePathSelect2.FileName = "";
            this.filePathSelect2.Location = new System.Drawing.Point(152, 61);
            this.filePathSelect2.Name = "filePathSelect2";
            this.filePathSelect2.Size = new System.Drawing.Size(284, 27);
            this.filePathSelect2.TabIndex = 3;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "";
            this.filePathSelect1.Location = new System.Drawing.Point(152, 27);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(284, 27);
            this.filePathSelect1.TabIndex = 2;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(12, 27);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // colorChooser1
            // 
            this.colorChooser1.CurrentColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.colorChooser1.Location = new System.Drawing.Point(12, 128);
            this.colorChooser1.Name = "colorChooser1";
            this.colorChooser1.Size = new System.Drawing.Size(316, 148);
            this.colorChooser1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 274);
            this.Controls.Add(this.colorChooser1);
            this.Controls.Add(this.filePathSelect3);
            this.Controls.Add(this.filePathSelect2);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.numberBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WinFormsControlLab.NumberBox numberBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private WinFormsControlLab.FilePathSelect filePathSelect1;
        private WinFormsControlLab.FilePathSelect filePathSelect2;
        private WinFormsControlLab.FilePathSelect filePathSelect3;
        private WinFormsControlLab.ColorChooser colorChooser1;
    }
}

