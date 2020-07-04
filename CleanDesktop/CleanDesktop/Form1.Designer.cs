namespace CleanDesktop
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorSettings = new System.Windows.Forms.Button();
            this.myLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.defaultPanel = new System.Windows.Forms.Panel();
            this.defaultLabel = new System.Windows.Forms.Label();
            this.defaultIcon = new System.Windows.Forms.PictureBox();
            this.defaultBackground = new System.Windows.Forms.PictureBox();
            this.defaultShading = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.myLayout.SuspendLayout();
            this.defaultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultShading)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.searchBtn);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Controls.Add(this.colorSettings);
            this.mainPanel.Controls.Add(this.myLayout);
            this.mainPanel.Location = new System.Drawing.Point(1, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1421, 604);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(80, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 3);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(510, 30);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(125, 49);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(83, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 33);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // colorSettings
            // 
            this.colorSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.colorSettings.BackColor = System.Drawing.Color.White;
            this.colorSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorSettings.Location = new System.Drawing.Point(671, 30);
            this.colorSettings.Name = "colorSettings";
            this.colorSettings.Size = new System.Drawing.Size(125, 49);
            this.colorSettings.TabIndex = 2;
            this.colorSettings.Text = "Color";
            this.colorSettings.UseVisualStyleBackColor = false;
            this.colorSettings.Click += new System.EventHandler(this.colorSettings_Click);
            // 
            // myLayout
            // 
            this.myLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myLayout.AutoScroll = true;
            this.myLayout.Controls.Add(this.defaultPanel);
            this.myLayout.Location = new System.Drawing.Point(3, 121);
            this.myLayout.Name = "myLayout";
            this.myLayout.Padding = new System.Windows.Forms.Padding(70, 0, 70, 0);
            this.myLayout.Size = new System.Drawing.Size(1415, 480);
            this.myLayout.TabIndex = 1;
            this.myLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.myLayout_Paint);
            // 
            // defaultPanel
            // 
            this.defaultPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.defaultPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.defaultPanel.Controls.Add(this.defaultLabel);
            this.defaultPanel.Controls.Add(this.defaultIcon);
            this.defaultPanel.Controls.Add(this.defaultBackground);
            this.defaultPanel.Controls.Add(this.defaultShading);
            this.defaultPanel.Location = new System.Drawing.Point(73, 3);
            this.defaultPanel.Name = "defaultPanel";
            this.defaultPanel.Size = new System.Drawing.Size(344, 144);
            this.defaultPanel.TabIndex = 0;
            // 
            // defaultLabel
            // 
            this.defaultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.defaultLabel.BackColor = System.Drawing.Color.White;
            this.defaultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultLabel.Location = new System.Drawing.Point(116, 26);
            this.defaultLabel.Name = "defaultLabel";
            this.defaultLabel.Size = new System.Drawing.Size(201, 80);
            this.defaultLabel.TabIndex = 2;
            this.defaultLabel.Text = "+";
            this.defaultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defaultIcon
            // 
            this.defaultIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.defaultIcon.BackColor = System.Drawing.Color.Lavender;
            this.defaultIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defaultIcon.Location = new System.Drawing.Point(26, 26);
            this.defaultIcon.Name = "defaultIcon";
            this.defaultIcon.Size = new System.Drawing.Size(80, 80);
            this.defaultIcon.TabIndex = 1;
            this.defaultIcon.TabStop = false;
            // 
            // defaultBackground
            // 
            this.defaultBackground.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.defaultBackground.BackColor = System.Drawing.Color.White;
            this.defaultBackground.Location = new System.Drawing.Point(3, 3);
            this.defaultBackground.Name = "defaultBackground";
            this.defaultBackground.Size = new System.Drawing.Size(325, 125);
            this.defaultBackground.TabIndex = 0;
            this.defaultBackground.TabStop = false;
            // 
            // defaultShading
            // 
            this.defaultShading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.defaultShading.BackColor = System.Drawing.Color.Black;
            this.defaultShading.Location = new System.Drawing.Point(13, 13);
            this.defaultShading.Name = "defaultShading";
            this.defaultShading.Size = new System.Drawing.Size(325, 125);
            this.defaultShading.TabIndex = 1;
            this.defaultShading.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1424, 607);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "CleanDesktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.myLayout.ResumeLayout(false);
            this.defaultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.defaultIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultShading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel defaultPanel;
        private System.Windows.Forms.Label defaultLabel;
        private System.Windows.Forms.PictureBox defaultIcon;
        private System.Windows.Forms.PictureBox defaultBackground;
        private System.Windows.Forms.PictureBox defaultShading;
        private System.Windows.Forms.FlowLayoutPanel myLayout;
        private System.Windows.Forms.Button colorSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

