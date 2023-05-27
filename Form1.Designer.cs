using System.Drawing;
using System.Windows.Forms;
using System;

namespace Button_Disappear
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Hello WinForms!!!";

            this.BackColor = Color.FromArgb(255, 96, 130, 230);
            this.Size = new Size(500, 500);
            this.MaximumSize = new Size(500, 500);
            this.MinimumSize = new Size(300, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            //
            //      Button click me
            //
            btn = new Button();
            btn.Text = "Click me";
            btn.Name = $"btn_0";
            btn.ForeColor = Color.Green;
            btn.Size = new Size(90, 100);
            btn.Location = new Point(180, 150);
            btn.BackColor = Color.Aquamarine;
            btn.Font = new Font("Times New Roman", 23, FontStyle.Bold | FontStyle.Italic);
            btn.MouseHover += Btn_MouseHover;
            btn.MouseLeave += Btn_MouseLeave;
            this.Controls.Add(btn);
            this.ControlRemoved += BG_Red;
            this.ControlAdded += BG_Blue;


        }

        private void BG_Blue(object sender, ControlEventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void BG_Red(object sender, ControlEventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Btn_MouseHover(object sender, System.EventArgs e)
        {
            btnr = new Button();
            Random r = new Random();
            btnr.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            btnr.Location = new Point ( 270 , 150);
            btnr.Size = new Size(90, 100);
            this.Controls.Add(btnr);

            btnl = new Button();
            btnl.Size = new Size(90, 100);
            btnl.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            btnl.Location = new Point( 90 , 150);
            this.Controls.Add(btnl);

        }
        private void Btn_MouseLeave(object sender, System.EventArgs e)
        {
            this.Controls.Remove(btnr);
            this.Controls.Remove(btnl);

        }
        Button btn;
        Button btnr;
        Button btnl;
        #endregion
    }
}

