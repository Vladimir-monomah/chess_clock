namespace ChessClock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_clock1 = new System.Windows.Forms.Label();
            this.label_clock2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_start = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_5min = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_2min = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_1hour = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_start_separator = new System.Windows.Forms.ToolStripSeparator();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_clock1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_clock2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_clock1
            // 
            this.label_clock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_clock1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clock1.Location = new System.Drawing.Point(3, 0);
            this.label_clock1.Name = "label_clock1";
            this.label_clock1.Size = new System.Drawing.Size(394, 422);
            this.label_clock1.TabIndex = 0;
            this.label_clock1.Text = "label1";
            this.label_clock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_clock1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_clock1_MouseClick);
            this.label_clock1.MouseEnter += new System.EventHandler(this.label_clock1_MouseEnter);
            // 
            // label_clock2
            // 
            this.label_clock2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_clock2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_clock2.Location = new System.Drawing.Point(403, 0);
            this.label_clock2.Name = "label_clock2";
            this.label_clock2.Size = new System.Drawing.Size(394, 422);
            this.label_clock2.TabIndex = 1;
            this.label_clock2.Text = "label2";
            this.label_clock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_clock2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label_clock1_MouseClick);
            this.label_clock2.MouseEnter += new System.EventHandler(this.label_clock2_MouseEnter);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_start});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_start
            // 
            this.menu_start.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_1hour,
            this.menu_2min,
            this.menu_5min,
            this.menu_start_separator,
            this.menu_exit});
            this.menu_start.Name = "menu_start";
            this.menu_start.Size = new System.Drawing.Size(127, 24);
            this.menu_start.Text = "Запустить часы";
            // 
            // menu_5min
            // 
            this.menu_5min.Name = "menu_5min";
            this.menu_5min.Size = new System.Drawing.Size(216, 26);
            this.menu_5min.Text = "5 минут";
            this.menu_5min.Click += new System.EventHandler(this.menu_5min_Click);
            // 
            // menu_2min
            // 
            this.menu_2min.Name = "menu_2min";
            this.menu_2min.Size = new System.Drawing.Size(216, 26);
            this.menu_2min.Text = "2 мин";
            this.menu_2min.Click += new System.EventHandler(this.menu_2min_Click);
            // 
            // menu_1hour
            // 
            this.menu_1hour.Name = "menu_1hour";
            this.menu_1hour.Size = new System.Drawing.Size(216, 26);
            this.menu_1hour.Text = "1 час";
            this.menu_1hour.Click += new System.EventHandler(this.menu_1hour_Click);
            // 
            // menu_start_separator
            // 
            this.menu_start_separator.Name = "menu_start_separator";
            this.menu_start_separator.Size = new System.Drawing.Size(213, 6);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(216, 26);
            this.menu_exit.Text = "Выход";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шахматные часы";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_clock1;
        private System.Windows.Forms.Label label_clock2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_start;
        private System.Windows.Forms.ToolStripMenuItem menu_1hour;
        private System.Windows.Forms.ToolStripMenuItem menu_2min;
        private System.Windows.Forms.ToolStripMenuItem menu_5min;
        private System.Windows.Forms.ToolStripSeparator menu_start_separator;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
    }
}

