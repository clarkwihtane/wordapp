namespace ödev3
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openToolStripMenuItem = new System.Windows.Forms.Button();
            this.saveToolStripMenuItem = new System.Windows.Forms.Button();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.leftAlignButton = new System.Windows.Forms.Button();
            this.rightAlignButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.pasteButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(752, 393);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.openToolStripMenuItem.Location = new System.Drawing.Point(425, -1);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.openToolStripMenuItem.TabIndex = 3;
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.UseVisualStyleBackColor = false;
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Thistle;
            this.saveToolStripMenuItem.Location = new System.Drawing.Point(343, -1);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.saveToolStripMenuItem.TabIndex = 4;
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.UseVisualStyleBackColor = false;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // boldButton
            // 
            this.boldButton.BackColor = System.Drawing.Color.Thistle;
            this.boldButton.Location = new System.Drawing.Point(257, -1);
            this.boldButton.Name = "boldButton";
            this.boldButton.Size = new System.Drawing.Size(90, 32);
            this.boldButton.TabIndex = 5;
            this.boldButton.Text = "Bold";
            this.boldButton.UseVisualStyleBackColor = false;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.BackColor = System.Drawing.Color.Thistle;
            this.italicButton.Location = new System.Drawing.Point(169, -1);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(92, 32);
            this.italicButton.TabIndex = 6;
            this.italicButton.Text = "İtalic";
            this.italicButton.UseVisualStyleBackColor = false;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // leftAlignButton
            // 
            this.leftAlignButton.BackColor = System.Drawing.Color.Thistle;
            this.leftAlignButton.Location = new System.Drawing.Point(598, -2);
            this.leftAlignButton.Name = "leftAlignButton";
            this.leftAlignButton.Size = new System.Drawing.Size(92, 33);
            this.leftAlignButton.TabIndex = 7;
            this.leftAlignButton.Text = "LeftAlign";
            this.leftAlignButton.UseVisualStyleBackColor = false;
            this.leftAlignButton.Click += new System.EventHandler(this.leftAlignButton_Click);
            // 
            // rightAlignButton
            // 
            this.rightAlignButton.BackColor = System.Drawing.Color.Thistle;
            this.rightAlignButton.Location = new System.Drawing.Point(512, -1);
            this.rightAlignButton.Margin = new System.Windows.Forms.Padding(1);
            this.rightAlignButton.Name = "rightAlignButton";
            this.rightAlignButton.Padding = new System.Windows.Forms.Padding(1);
            this.rightAlignButton.Size = new System.Drawing.Size(92, 32);
            this.rightAlignButton.TabIndex = 8;
            this.rightAlignButton.Text = "RightAlign";
            this.rightAlignButton.UseVisualStyleBackColor = false;
            this.rightAlignButton.Click += new System.EventHandler(this.rightAlignButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.Color.Thistle;
            this.copyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.copyButton.Location = new System.Drawing.Point(0, -1);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(90, 32);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // pasteButton
            // 
            this.pasteButton.BackColor = System.Drawing.Color.Thistle;
            this.pasteButton.Location = new System.Drawing.Point(86, -1);
            this.pasteButton.Name = "pasteButton";
            this.pasteButton.Size = new System.Drawing.Size(92, 32);
            this.pasteButton.TabIndex = 10;
            this.pasteButton.Text = "Paste";
            this.pasteButton.UseVisualStyleBackColor = false;
            this.pasteButton.Click += new System.EventHandler(this.pasteButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(683, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Color";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(776, 441);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.pasteButton);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.boldButton);
            this.Controls.Add(this.saveToolStripMenuItem);
            this.Controls.Add(this.openToolStripMenuItem);
            this.Controls.Add(this.rightAlignButton);
            this.Controls.Add(this.leftAlignButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button openToolStripMenuItem;
        private System.Windows.Forms.Button saveToolStripMenuItem;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Button leftAlignButton;
        private System.Windows.Forms.Button rightAlignButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button pasteButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}

