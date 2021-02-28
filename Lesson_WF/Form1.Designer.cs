using System.Windows.Forms;

namespace Lesson_WF
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
            this.Text = "Form1";

            btnOpen = new Button();
            btnOpen.Text = "Click Open";
            btnOpen.Click += Btn_Click;

            btnSave = new Button();
            btnSave.Text = "Click Save";
            btnSave.Location = new System.Drawing.Point(150, 0);
            btnSave.Click += BtnSave_Click; ;

            textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(0, 150);
            textBox.Multiline = true;
            textBox.Width = textBox.Height = 200;

            this.Controls.Add(textBox);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnOpen);

            this.FormClosing += Form1_FormClosing;

        }
        TextBox textBox;
        Button btnOpen;
        Button btnSave;
        #endregion
    }
}

