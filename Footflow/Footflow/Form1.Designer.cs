namespace Footflow
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.btnFootfall = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnWoods = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.rtbComment = new System.Windows.Forms.RichTextBox();
            this.lbCategory = new System.Windows.Forms.ListBox();
            this.lblText3 = new System.Windows.Forms.Label();
            this.cbPublic = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.BackgroundImage = global::Footflow.Properties.Resources.basic_img;
            this.pbMap.Location = new System.Drawing.Point(9, 10);
            this.pbMap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(788, 783);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            // 
            // btnFootfall
            // 
            this.btnFootfall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFootfall.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFootfall.Location = new System.Drawing.Point(22, 23);
            this.btnFootfall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFootfall.Name = "btnFootfall";
            this.btnFootfall.Size = new System.Drawing.Size(230, 55);
            this.btnFootfall.TabIndex = 1;
            this.btnFootfall.Text = "toggle footfall";
            this.btnFootfall.UseVisualStyleBackColor = false;
            this.btnFootfall.Click += new System.EventHandler(this.btnFootfall_Click);
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(480, 299);
            this.btnPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(72, 40);
            this.btnPath.TabIndex = 3;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnWoods
            // 
            this.btnWoods.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWoods.Location = new System.Drawing.Point(204, 557);
            this.btnWoods.Margin = new System.Windows.Forms.Padding(2);
            this.btnWoods.Name = "btnWoods";
            this.btnWoods.Size = new System.Drawing.Size(102, 41);
            this.btnWoods.TabIndex = 4;
            this.btnWoods.Text = "Woods";
            this.btnWoods.UseVisualStyleBackColor = true;
            this.btnWoods.Click += new System.EventHandler(this.btnWoods_Click);
            // 
            // btnWater
            // 
            this.btnWater.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWater.Location = new System.Drawing.Point(143, 141);
            this.btnWater.Margin = new System.Windows.Forms.Padding(2);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(73, 41);
            this.btnWater.TabIndex = 5;
            this.btnWater.Text = "Lake";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Noto Sans Georgian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.Location = new System.Drawing.Point(819, 23);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(183, 29);
            this.lblText1.TabIndex = 6;
            this.lblText1.Text = "Chosen Location:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Noto Sans Georgian", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(819, 62);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(153, 29);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Select an Area";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("Noto Sans Georgian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.Location = new System.Drawing.Point(819, 124);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(169, 29);
            this.lblText2.TabIndex = 8;
            this.lblText2.Text = "Your Comment:";
            // 
            // rtbComment
            // 
            this.rtbComment.Font = new System.Drawing.Font("Noto Sans Georgian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbComment.Location = new System.Drawing.Point(824, 165);
            this.rtbComment.Name = "rtbComment";
            this.rtbComment.Size = new System.Drawing.Size(218, 231);
            this.rtbComment.TabIndex = 9;
            this.rtbComment.Text = "";
            // 
            // lbCategory
            // 
            this.lbCategory.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.FormattingEnabled = true;
            this.lbCategory.ItemHeight = 29;
            this.lbCategory.Items.AddRange(new object[] {
            "Select",
            "Suggestion",
            "Feedback"});
            this.lbCategory.Location = new System.Drawing.Point(896, 433);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(146, 33);
            this.lbCategory.TabIndex = 10;
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Font = new System.Drawing.Font("Noto Sans Georgian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.Location = new System.Drawing.Point(819, 399);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(214, 29);
            this.lblText3.TabIndex = 11;
            this.lblText3.Text = "Comment Category:";
            // 
            // cbPublic
            // 
            this.cbPublic.AutoSize = true;
            this.cbPublic.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPublic.Location = new System.Drawing.Point(896, 485);
            this.cbPublic.Name = "cbPublic";
            this.cbPublic.Size = new System.Drawing.Size(126, 26);
            this.cbPublic.TabIndex = 12;
            this.cbPublic.Text = "Make Public";
            this.cbPublic.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Noto Sans Georgian Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(895, 526);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 804);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbPublic);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.rtbComment);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnWoods);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnFootfall);
            this.Controls.Add(this.pbMap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button btnFootfall;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnWoods;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.RichTextBox rtbComment;
        private System.Windows.Forms.ListBox lbCategory;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.CheckBox cbPublic;
        private System.Windows.Forms.Button button1;
    }
}

