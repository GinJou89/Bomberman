
namespace Bomberman
{
    partial class ModalWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModalWindow));
            this.Easy = new System.Windows.Forms.Button();
            this.middle = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Easy
            // 
            this.Easy.Location = new System.Drawing.Point(1, 10);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(172, 23);
            this.Easy.TabIndex = 0;
            this.Easy.Text = "Легко";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // middle
            // 
            this.middle.Location = new System.Drawing.Point(1, 39);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(172, 23);
            this.middle.TabIndex = 1;
            this.middle.Text = "Средне";
            this.middle.UseVisualStyleBackColor = true;
            this.middle.Click += new System.EventHandler(this.middle_Click);
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(1, 68);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(172, 23);
            this.hard.TabIndex = 2;
            this.hard.Text = "Тяжело";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // ModalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 103);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.Easy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор сложности";
            this.Load += new System.EventHandler(this.ModalWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button middle;
        private System.Windows.Forms.Button hard;
    }
}