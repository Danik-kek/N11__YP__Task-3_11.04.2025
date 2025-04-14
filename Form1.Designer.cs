namespace task3
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            abobaToolStripMenuItem = new ToolStripMenuItem();
            form1ToolStripMenuItem = new ToolStripMenuItem();
            from2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { abobaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // abobaToolStripMenuItem
            // 
            abobaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { form1ToolStripMenuItem, from2ToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            abobaToolStripMenuItem.Name = "abobaToolStripMenuItem";
            abobaToolStripMenuItem.Size = new Size(116, 24);
            abobaToolStripMenuItem.Text = "я хочу пицы !";
            // 
            // form1ToolStripMenuItem
            // 
            form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            form1ToolStripMenuItem.Size = new Size(224, 26);
            form1ToolStripMenuItem.Text = "Form1";
            form1ToolStripMenuItem.Click += form1ToolStripMenuItem_Click;
            // 
            // from2ToolStripMenuItem
            // 
            from2ToolStripMenuItem.Name = "from2ToolStripMenuItem";
            from2ToolStripMenuItem.Size = new Size(224, 26);
            from2ToolStripMenuItem.Text = "From2";
            from2ToolStripMenuItem.Click += from2ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem abobaToolStripMenuItem;
        private ToolStripMenuItem form1ToolStripMenuItem;
        private ToolStripMenuItem from2ToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    }
}
