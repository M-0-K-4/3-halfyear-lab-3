namespace Client
{
    partial class Client
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
            label_Output = new Label();
            textBox_Output = new TextBox();
            label_Input = new Label();
            textBox_Input = new TextBox();
            button_Send = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            button_EXIT = new Button();
            panel = new Panel();
            statusStrip1.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // label_Output
            // 
            label_Output.BackColor = SystemColors.Desktop;
            label_Output.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_Output.ForeColor = SystemColors.Window;
            label_Output.Location = new Point(12, 373);
            label_Output.Name = "label_Output";
            label_Output.Size = new Size(192, 28);
            label_Output.TabIndex = 0;
            label_Output.Text = "Output console";
            // 
            // textBox_Output
            // 
            textBox_Output.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Output.BackColor = SystemColors.Desktop;
            textBox_Output.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox_Output.ForeColor = Color.Green;
            textBox_Output.Location = new Point(12, 404);
            textBox_Output.Multiline = true;
            textBox_Output.Name = "textBox_Output";
            textBox_Output.Size = new Size(660, 300);
            textBox_Output.TabIndex = 1;
            textBox_Output.WordWrap = false;
            textBox_Output.KeyPress += textBox_Output_KeyPress;
            // 
            // label_Input
            // 
            label_Input.BackColor = SystemColors.Desktop;
            label_Input.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label_Input.ForeColor = SystemColors.Window;
            label_Input.Location = new Point(12, 8);
            label_Input.Name = "label_Input";
            label_Input.Size = new Size(195, 27);
            label_Input.TabIndex = 2;
            label_Input.Text = "Input console";
            // 
            // textBox_Input
            // 
            textBox_Input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Input.BackColor = SystemColors.Desktop;
            textBox_Input.Font = new Font("Tahoma", 11.25F);
            textBox_Input.ForeColor = Color.Green;
            textBox_Input.Location = new Point(12, 38);
            textBox_Input.Multiline = true;
            textBox_Input.Name = "textBox_Input";
            textBox_Input.Size = new Size(660, 300);
            textBox_Input.TabIndex = 3;
            textBox_Input.TabStop = false;
            // 
            // button_Send
            // 
            button_Send.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_Send.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_Send.BackColor = SystemColors.Desktop;
            button_Send.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
            button_Send.ForeColor = SystemColors.Window;
            button_Send.Location = new Point(12, 710);
            button_Send.Name = "button_Send";
            button_Send.Size = new Size(57, 26);
            button_Send.TabIndex = 4;
            button_Send.Text = "Send";
            button_Send.TextAlign = ContentAlignment.MiddleLeft;
            button_Send.UseVisualStyleBackColor = false;
            button_Send.Click += button_Send_Click;
            button_Send.MouseEnter += button_Send_MouseEnter;
            button_Send.MouseLeave += button_Send_MouseLeave;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Desktop;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new Point(0, 739);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(684, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripStatusLabel.ForeColor = SystemColors.Window;
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // button_EXIT
            // 
            button_EXIT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_EXIT.BackColor = SystemColors.Desktop;
            button_EXIT.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_EXIT.ForeColor = SystemColors.Window;
            button_EXIT.Location = new Point(617, 9);
            button_EXIT.Name = "button_EXIT";
            button_EXIT.Size = new Size(55, 26);
            button_EXIT.TabIndex = 6;
            button_EXIT.Text = "EXIT";
            button_EXIT.TextAlign = ContentAlignment.MiddleRight;
            button_EXIT.UseVisualStyleBackColor = false;
            button_EXIT.Click += button_EXIT_Click;
            button_EXIT.MouseEnter += button_EXIT_MouseEnter;
            button_EXIT.MouseLeave += button_EXIT_MouseLeave;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.Desktop;
            panel.Controls.Add(button_EXIT);
            panel.Controls.Add(button_Send);
            panel.Controls.Add(label_Output);
            panel.Controls.Add(textBox_Output);
            panel.Controls.Add(label_Input);
            panel.Controls.Add(textBox_Input);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(684, 761);
            panel.TabIndex = 7;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 761);
            Controls.Add(statusStrip1);
            Controls.Add(panel);
            Location = new Point(173, 130);
            MaximumSize = new Size(700, 800);
            MinimumSize = new Size(700, 800);
            Name = "Client";
            StartPosition = FormStartPosition.Manual;
            Text = "Client";
            FormClosing += Client_FormClosing;
            Load += Client_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Output;
        private TextBox textBox_Output;
        private Label label_Input;
        private TextBox textBox_Input;
        private Button button_Send;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Button button_EXIT;
        private Panel panel;
    }
}