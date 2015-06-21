namespace ProjectHandlerV0
{
    partial class tagsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tagsForm));
            this.fileSelectionDrop = new System.Windows.Forms.ComboBox();
            this.tagsCheckbox = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testOut = new System.Windows.Forms.Label();
            this.Almost = new System.Windows.Forms.ToolTip(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSelectionDrop
            // 
            this.fileSelectionDrop.BackColor = System.Drawing.SystemColors.InfoText;
            this.fileSelectionDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileSelectionDrop.ForeColor = System.Drawing.SystemColors.Info;
            this.fileSelectionDrop.FormattingEnabled = true;
            this.fileSelectionDrop.Location = new System.Drawing.Point(12, 26);
            this.fileSelectionDrop.Name = "fileSelectionDrop";
            this.fileSelectionDrop.Size = new System.Drawing.Size(256, 21);
            this.fileSelectionDrop.Sorted = true;
            this.fileSelectionDrop.TabIndex = 0;
            this.fileSelectionDrop.SelectedIndexChanged += new System.EventHandler(this.TaskSelectionDrop_SelectedIndexChanged);
            // 
            // tagsCheckbox
            // 
            this.tagsCheckbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.tagsCheckbox.ForeColor = System.Drawing.SystemColors.Info;
            this.tagsCheckbox.FormattingEnabled = true;
            this.tagsCheckbox.Items.AddRange(new object[] {
            "Priority",
            "Group",
            "New",
            "Almost finished",
            "Lacking Materials",
            "Lacking Skill"});
            this.tagsCheckbox.Location = new System.Drawing.Point(12, 53);
            this.tagsCheckbox.Name = "tagsCheckbox";
            this.tagsCheckbox.Size = new System.Drawing.Size(123, 94);
            this.tagsCheckbox.TabIndex = 1;
            this.Almost.SetToolTip(this.tagsCheckbox, "Priority - Mark as urgent\r\nGroup - Needs more people\r\nNew - Little to no work don" +
        "e\r\nAlmost Finished - Needs wrapping up or finishing");
            this.tagsCheckbox.SelectedIndexChanged += new System.EventHandler(this.tagsCheckbox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // testOut
            // 
            this.testOut.AutoSize = true;
            this.testOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.testOut.Location = new System.Drawing.Point(66, 9);
            this.testOut.Name = "testOut";
            this.testOut.Size = new System.Drawing.Size(11, 13);
            this.testOut.TabIndex = 5;
            this.testOut.Text = " ";
            // 
            // Almost
            // 
            this.Almost.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Location = new System.Drawing.Point(179, 92);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(42, 22);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tagsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.testOut);
            this.Controls.Add(this.tagsCheckbox);
            this.Controls.Add(this.fileSelectionDrop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "tagsForm";
            this.Text = "Tags";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fileSelectionDrop;
        private System.Windows.Forms.CheckedListBox tagsCheckbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label testOut;
        private System.Windows.Forms.ToolTip Almost;
        private System.Windows.Forms.Button saveButton;
    }
}