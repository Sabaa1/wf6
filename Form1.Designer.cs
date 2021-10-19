
namespace WindowsFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogUsernameLabel = new System.Windows.Forms.Label();
            this.LogPassLabel = new System.Windows.Forms.Label();
            this.LogResponseLabel = new System.Windows.Forms.Label();
            this.RegUsernameLabel = new System.Windows.Forms.Label();
            this.RegNameLabel = new System.Windows.Forms.Label();
            this.RegLastnameLabel = new System.Windows.Forms.Label();
            this.RegPassLabel = new System.Windows.Forms.Label();
            this.RegRePassLabel = new System.Windows.Forms.Label();
            this.RegResponseLabel = new System.Windows.Forms.Label();
            this.LogUsernameBox = new System.Windows.Forms.TextBox();
            this.LogPassBox = new System.Windows.Forms.TextBox();
            this.RegNameBox = new System.Windows.Forms.TextBox();
            this.RegUsernameBox = new System.Windows.Forms.TextBox();
            this.RegLastnameBox = new System.Windows.Forms.TextBox();
            this.RegPassBox = new System.Windows.Forms.TextBox();
            this.RegRePassBox = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.RegCourseLabel = new System.Windows.Forms.Label();
            this.RegStatusLabel = new System.Windows.Forms.Label();
            this.RegStatusBox = new System.Windows.Forms.ComboBox();
            this.RegCourseBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginButton.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Firebrick;
            this.LoginButton.Location = new System.Drawing.Point(72, 246);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(131, 50);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogUsernameLabel
            // 
            this.LogUsernameLabel.AutoSize = true;
            this.LogUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogUsernameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.LogUsernameLabel.Location = new System.Drawing.Point(12, 116);
            this.LogUsernameLabel.Name = "LogUsernameLabel";
            this.LogUsernameLabel.Size = new System.Drawing.Size(80, 16);
            this.LogUsernameLabel.TabIndex = 1;
            this.LogUsernameLabel.Text = "Username : ";
            // 
            // LogPassLabel
            // 
            this.LogPassLabel.AutoSize = true;
            this.LogPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogPassLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.LogPassLabel.Location = new System.Drawing.Point(11, 153);
            this.LogPassLabel.Name = "LogPassLabel";
            this.LogPassLabel.Size = new System.Drawing.Size(80, 16);
            this.LogPassLabel.TabIndex = 2;
            this.LogPassLabel.Text = "Password  : ";
            // 
            // LogResponseLabel
            // 
            this.LogResponseLabel.AutoSize = true;
            this.LogResponseLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogResponseLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.LogResponseLabel.Location = new System.Drawing.Point(11, 192);
            this.LogResponseLabel.Name = "LogResponseLabel";
            this.LogResponseLabel.Size = new System.Drawing.Size(80, 16);
            this.LogResponseLabel.TabIndex = 3;
            this.LogResponseLabel.Text = "Response : ";
            // 
            // RegUsernameLabel
            // 
            this.RegUsernameLabel.AutoSize = true;
            this.RegUsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegUsernameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegUsernameLabel.Location = new System.Drawing.Point(280, 116);
            this.RegUsernameLabel.Name = "RegUsernameLabel";
            this.RegUsernameLabel.Size = new System.Drawing.Size(80, 16);
            this.RegUsernameLabel.TabIndex = 4;
            this.RegUsernameLabel.Text = "Username : ";
            // 
            // RegNameLabel
            // 
            this.RegNameLabel.AutoSize = true;
            this.RegNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegNameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegNameLabel.Location = new System.Drawing.Point(280, 154);
            this.RegNameLabel.Name = "RegNameLabel";
            this.RegNameLabel.Size = new System.Drawing.Size(54, 16);
            this.RegNameLabel.TabIndex = 5;
            this.RegNameLabel.Text = "Name : ";
            // 
            // RegLastnameLabel
            // 
            this.RegLastnameLabel.AutoSize = true;
            this.RegLastnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegLastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLastnameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegLastnameLabel.Location = new System.Drawing.Point(280, 192);
            this.RegLastnameLabel.Name = "RegLastnameLabel";
            this.RegLastnameLabel.Size = new System.Drawing.Size(76, 16);
            this.RegLastnameLabel.TabIndex = 6;
            this.RegLastnameLabel.Text = "Lastname : ";
            // 
            // RegPassLabel
            // 
            this.RegPassLabel.AutoSize = true;
            this.RegPassLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPassLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegPassLabel.Location = new System.Drawing.Point(526, 153);
            this.RegPassLabel.Name = "RegPassLabel";
            this.RegPassLabel.Size = new System.Drawing.Size(77, 16);
            this.RegPassLabel.TabIndex = 7;
            this.RegPassLabel.Text = "Password : ";
            // 
            // RegRePassLabel
            // 
            this.RegRePassLabel.AutoSize = true;
            this.RegRePassLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegRePassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegRePassLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegRePassLabel.Location = new System.Drawing.Point(526, 189);
            this.RegRePassLabel.Name = "RegRePassLabel";
            this.RegRePassLabel.Size = new System.Drawing.Size(131, 16);
            this.RegRePassLabel.TabIndex = 8;
            this.RegRePassLabel.Text = "Re-enter password : ";
            // 
            // RegResponseLabel
            // 
            this.RegResponseLabel.AutoSize = true;
            this.RegResponseLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegResponseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegResponseLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegResponseLabel.Location = new System.Drawing.Point(280, 265);
            this.RegResponseLabel.Name = "RegResponseLabel";
            this.RegResponseLabel.Size = new System.Drawing.Size(80, 16);
            this.RegResponseLabel.TabIndex = 9;
            this.RegResponseLabel.Text = "Response : ";
            // 
            // LogUsernameBox
            // 
            this.LogUsernameBox.Location = new System.Drawing.Point(114, 116);
            this.LogUsernameBox.Name = "LogUsernameBox";
            this.LogUsernameBox.Size = new System.Drawing.Size(125, 20);
            this.LogUsernameBox.TabIndex = 10;
            // 
            // LogPassBox
            // 
            this.LogPassBox.Location = new System.Drawing.Point(114, 154);
            this.LogPassBox.Name = "LogPassBox";
            this.LogPassBox.Size = new System.Drawing.Size(125, 20);
            this.LogPassBox.TabIndex = 11;
            // 
            // RegNameBox
            // 
            this.RegNameBox.Location = new System.Drawing.Point(358, 153);
            this.RegNameBox.Name = "RegNameBox";
            this.RegNameBox.Size = new System.Drawing.Size(125, 20);
            this.RegNameBox.TabIndex = 12;
            // 
            // RegUsernameBox
            // 
            this.RegUsernameBox.Location = new System.Drawing.Point(375, 112);
            this.RegUsernameBox.Name = "RegUsernameBox";
            this.RegUsernameBox.Size = new System.Drawing.Size(125, 20);
            this.RegUsernameBox.TabIndex = 13;
            // 
            // RegLastnameBox
            // 
            this.RegLastnameBox.Location = new System.Drawing.Point(375, 189);
            this.RegLastnameBox.Name = "RegLastnameBox";
            this.RegLastnameBox.Size = new System.Drawing.Size(125, 20);
            this.RegLastnameBox.TabIndex = 14;
            // 
            // RegPassBox
            // 
            this.RegPassBox.Location = new System.Drawing.Point(627, 149);
            this.RegPassBox.Name = "RegPassBox";
            this.RegPassBox.Size = new System.Drawing.Size(125, 20);
            this.RegPassBox.TabIndex = 15;
            // 
            // RegRePassBox
            // 
            this.RegRePassBox.Location = new System.Drawing.Point(663, 185);
            this.RegRePassBox.Name = "RegRePassBox";
            this.RegRePassBox.Size = new System.Drawing.Size(125, 20);
            this.RegRePassBox.TabIndex = 16;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.SkyBlue;
            this.RegButton.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.ForeColor = System.Drawing.Color.Firebrick;
            this.RegButton.Location = new System.Drawing.Point(441, 284);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(162, 59);
            this.RegButton.TabIndex = 17;
            this.RegButton.Text = "Register";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RegCourseLabel
            // 
            this.RegCourseLabel.AutoSize = true;
            this.RegCourseLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegCourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegCourseLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegCourseLabel.Location = new System.Drawing.Point(526, 224);
            this.RegCourseLabel.Name = "RegCourseLabel";
            this.RegCourseLabel.Size = new System.Drawing.Size(63, 16);
            this.RegCourseLabel.TabIndex = 18;
            this.RegCourseLabel.Text = "Course  : ";
            // 
            // RegStatusLabel
            // 
            this.RegStatusLabel.AutoSize = true;
            this.RegStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.RegStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegStatusLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.RegStatusLabel.Location = new System.Drawing.Point(280, 229);
            this.RegStatusLabel.Name = "RegStatusLabel";
            this.RegStatusLabel.Size = new System.Drawing.Size(51, 16);
            this.RegStatusLabel.TabIndex = 19;
            this.RegStatusLabel.Text = "Status: ";
            // 
            // RegStatusBox
            // 
            this.RegStatusBox.FormattingEnabled = true;
            this.RegStatusBox.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.RegStatusBox.Location = new System.Drawing.Point(358, 224);
            this.RegStatusBox.Name = "RegStatusBox";
            this.RegStatusBox.Size = new System.Drawing.Size(125, 21);
            this.RegStatusBox.TabIndex = 20;
            // 
            // RegCourseBox
            // 
            this.RegCourseBox.FormattingEnabled = true;
            this.RegCourseBox.Items.AddRange(new object[] {
            "C#",
            "C++",
            "Java",
            "Python",
            "C"});
            this.RegCourseBox.Location = new System.Drawing.Point(616, 223);
            this.RegCourseBox.Name = "RegCourseBox";
            this.RegCourseBox.Size = new System.Drawing.Size(136, 21);
            this.RegCourseBox.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 452);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(82, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 23;
            this.label1.Text = "Log in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(435, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 35);
            this.label2.TabIndex = 24;
            this.label2.Text = "Register";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(627, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 100);
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegCourseBox);
            this.Controls.Add(this.RegStatusBox);
            this.Controls.Add(this.RegStatusLabel);
            this.Controls.Add(this.RegCourseLabel);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.RegRePassBox);
            this.Controls.Add(this.RegPassBox);
            this.Controls.Add(this.RegLastnameBox);
            this.Controls.Add(this.RegUsernameBox);
            this.Controls.Add(this.RegNameBox);
            this.Controls.Add(this.LogPassBox);
            this.Controls.Add(this.LogUsernameBox);
            this.Controls.Add(this.RegResponseLabel);
            this.Controls.Add(this.RegRePassLabel);
            this.Controls.Add(this.RegPassLabel);
            this.Controls.Add(this.RegLastnameLabel);
            this.Controls.Add(this.RegNameLabel);
            this.Controls.Add(this.RegUsernameLabel);
            this.Controls.Add(this.LogResponseLabel);
            this.Controls.Add(this.LogPassLabel);
            this.Controls.Add(this.LogUsernameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LogUsernameLabel;
        private System.Windows.Forms.Label LogPassLabel;
        private System.Windows.Forms.Label LogResponseLabel;
        private System.Windows.Forms.Label RegUsernameLabel;
        private System.Windows.Forms.Label RegNameLabel;
        private System.Windows.Forms.Label RegLastnameLabel;
        private System.Windows.Forms.Label RegPassLabel;
        private System.Windows.Forms.Label RegRePassLabel;
        private System.Windows.Forms.Label RegResponseLabel;
        private System.Windows.Forms.TextBox LogUsernameBox;
        private System.Windows.Forms.TextBox LogPassBox;
        private System.Windows.Forms.TextBox RegNameBox;
        private System.Windows.Forms.TextBox RegUsernameBox;
        private System.Windows.Forms.TextBox RegLastnameBox;
        private System.Windows.Forms.TextBox RegPassBox;
        private System.Windows.Forms.TextBox RegRePassBox;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label RegCourseLabel;
        private System.Windows.Forms.Label RegStatusLabel;
        private System.Windows.Forms.ComboBox RegStatusBox;
        private System.Windows.Forms.ComboBox RegCourseBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

