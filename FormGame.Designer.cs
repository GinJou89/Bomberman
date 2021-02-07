
namespace Bomberman
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глупыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.умныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыйУмныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обИгреToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обавтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.timerFireClear = new System.Windows.Forms.Timer(this.components);
            this.timerGameOver = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(121, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.сложностьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // сложностьToolStripMenuItem
            // 
            this.сложностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.глупыйToolStripMenuItem,
            this.умныйToolStripMenuItem,
            this.самыйУмныйToolStripMenuItem});
            this.сложностьToolStripMenuItem.Name = "сложностьToolStripMenuItem";
            this.сложностьToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.сложностьToolStripMenuItem.Text = "Сложность";
            // 
            // глупыйToolStripMenuItem
            // 
            this.глупыйToolStripMenuItem.Name = "глупыйToolStripMenuItem";
            this.глупыйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.глупыйToolStripMenuItem.Text = "Глупый";
            this.глупыйToolStripMenuItem.Click += new System.EventHandler(this.глупыйToolStripMenuItem_Click);
            // 
            // умныйToolStripMenuItem
            // 
            this.умныйToolStripMenuItem.Name = "умныйToolStripMenuItem";
            this.умныйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.умныйToolStripMenuItem.Text = "Умный";
            this.умныйToolStripMenuItem.Click += new System.EventHandler(this.умныйToolStripMenuItem_Click);
            // 
            // самыйУмныйToolStripMenuItem
            // 
            this.самыйУмныйToolStripMenuItem.Name = "самыйУмныйToolStripMenuItem";
            this.самыйУмныйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.самыйУмныйToolStripMenuItem.Text = "Самый умный";
            this.самыйУмныйToolStripMenuItem.Click += new System.EventHandler(this.самыйУмныйToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.выходToolStripMenuItem.Checked = true;
            this.выходToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обИгреToolStripMenuItem,
            this.обавтореToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // обИгреToolStripMenuItem
            // 
            this.обИгреToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.обИгреToolStripMenuItem.Name = "обИгреToolStripMenuItem";
            this.обИгреToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.обИгреToolStripMenuItem.Text = "Об игре";
            this.обИгреToolStripMenuItem.Click += new System.EventHandler(this.обИгреToolStripMenuItem_Click);
            // 
            // обавтореToolStripMenuItem
            // 
            this.обавтореToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.обавтореToolStripMenuItem.Name = "обавтореToolStripMenuItem";
            this.обавтореToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.обавтореToolStripMenuItem.Text = "Об авторе";
            this.обавтореToolStripMenuItem.Click += new System.EventHandler(this.обавтореToolStripMenuItem_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panelGame.Location = new System.Drawing.Point(0, 27);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(576, 384);
            this.panelGame.TabIndex = 1;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.labelScore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.ForeColor = System.Drawing.Color.Snow;
            this.labelScore.Location = new System.Drawing.Point(124, 1);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(434, 24);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "NewGame";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerFireClear
            // 
            this.timerFireClear.Enabled = true;
            this.timerFireClear.Interval = 1000;
            this.timerFireClear.Tick += new System.EventHandler(this.timerFireClear_Tick);
            // 
            // timerGameOver
            // 
            this.timerGameOver.Tick += new System.EventHandler(this.timerGameOver_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(545, 378);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bomberman";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обИгреToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обавтореToolStripMenuItem;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timerFireClear;
        private System.Windows.Forms.Timer timerGameOver;
        private System.Windows.Forms.ToolStripMenuItem сложностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem глупыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem умныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыйУмныйToolStripMenuItem;
    }
}

