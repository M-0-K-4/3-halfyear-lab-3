namespace Server
{
    partial class Server
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
            textBox_Input = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            label_Input = new Label();
            panel1 = new Panel();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Input
            // 
            textBox_Input.BackColor = SystemColors.Desktop;
            textBox_Input.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Input.ForeColor = Color.Green;
            textBox_Input.Location = new Point(12, 35);
            textBox_Input.Multiline = true;
            textBox_Input.Name = "textBox_Input";
            textBox_Input.ReadOnly = true;
            textBox_Input.Size = new Size(660, 701);
            textBox_Input.TabIndex = 0;
            textBox_Input.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Desktop;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 739);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(684, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Tahoma", 9F);
            toolStripStatusLabel.ForeColor = SystemColors.Window;
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // label_Input
            // 
            label_Input.AutoSize = true;
            label_Input.BackColor = SystemColors.Desktop;
            label_Input.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label_Input.ForeColor = SystemColors.Window;
            label_Input.Location = new Point(12, 9);
            label_Input.Name = "label_Input";
            label_Input.Size = new Size(63, 23);
            label_Input.TabIndex = 2;
            label_Input.Text = "Input";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(label_Input);
            panel1.Controls.Add(textBox_Input);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 761);
            panel1.TabIndex = 3;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 761);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Location = new Point(1047, 130);
            MaximumSize = new Size(700, 800);
            MinimumSize = new Size(700, 800);
            Name = "Server";
            StartPosition = FormStartPosition.Manual;
            Text = "Server";
            FormClosing += Server_FormClosing;
            Load += Server_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Input;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Label label_Input;
        private Panel panel1;
    }
}