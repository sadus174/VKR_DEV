namespace VKR_DEV
{
    partial class MainForm
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
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(315, 23);
            button1.TabIndex = 0;
            button1.Text = "Список сотрудников";
            button1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 289);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(339, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(12, 41);
            button2.Name = "button2";
            button2.Size = new Size(315, 23);
            button2.TabIndex = 2;
            button2.Text = "Редактировать свои данные";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(12, 70);
            button3.Name = "button3";
            button3.Size = new Size(315, 23);
            button3.TabIndex = 3;
            button3.Text = "Управление сотрудниками";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(12, 99);
            button4.Name = "button4";
            button4.Size = new Size(315, 23);
            button4.TabIndex = 4;
            button4.Text = "Управление пользователя";
            button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 311);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Главная";
            Load += MainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
