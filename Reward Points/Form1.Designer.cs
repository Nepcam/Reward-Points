namespace Reward_Points
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMovieName = new System.Windows.Forms.Label();
            this.radioButtonThreeD = new System.Windows.Forms.RadioButton();
            this.radioButtonDelux = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(587, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(445, 226);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(150, 23);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(635, 226);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(150, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(12, 12);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(413, 264);
            this.listBoxDisplay.TabIndex = 4;
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.Location = new System.Drawing.Point(587, 102);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(198, 20);
            this.textBoxMovie.TabIndex = 5;
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Location = new System.Drawing.Point(442, 13);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(141, 13);
            this.labelFormTitle.TabIndex = 6;
            this.labelFormTitle.Text = "Check if points have expired";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(445, 59);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(124, 13);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Enter date of movie view";
            // 
            // labelMovieName
            // 
            this.labelMovieName.AutoSize = true;
            this.labelMovieName.Location = new System.Drawing.Point(445, 105);
            this.labelMovieName.Name = "labelMovieName";
            this.labelMovieName.Size = new System.Drawing.Size(104, 13);
            this.labelMovieName.TabIndex = 8;
            this.labelMovieName.Text = "Enter name of movie";
            // 
            // radioButtonThreeD
            // 
            this.radioButtonThreeD.AutoSize = true;
            this.radioButtonThreeD.Location = new System.Drawing.Point(587, 141);
            this.radioButtonThreeD.Name = "radioButtonThreeD";
            this.radioButtonThreeD.Size = new System.Drawing.Size(39, 17);
            this.radioButtonThreeD.TabIndex = 9;
            this.radioButtonThreeD.TabStop = true;
            this.radioButtonThreeD.Text = "3D";
            this.radioButtonThreeD.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelux
            // 
            this.radioButtonDelux.AutoSize = true;
            this.radioButtonDelux.Location = new System.Drawing.Point(587, 178);
            this.radioButtonDelux.Name = "radioButtonDelux";
            this.radioButtonDelux.Size = new System.Drawing.Size(91, 17);
            this.radioButtonDelux.TabIndex = 10;
            this.radioButtonDelux.TabStop = true;
            this.radioButtonDelux.Text = "Delux Seating";
            this.radioButtonDelux.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 293);
            this.Controls.Add(this.radioButtonDelux);
            this.Controls.Add(this.radioButtonThreeD);
            this.Controls.Add(this.labelMovieName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelFormTitle);
            this.Controls.Add(this.textBoxMovie);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMovieName;
        private System.Windows.Forms.RadioButton radioButtonThreeD;
        private System.Windows.Forms.RadioButton radioButtonDelux;
    }
}

