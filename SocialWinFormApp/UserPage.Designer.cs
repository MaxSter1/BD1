namespace SocialWinFormApp
{
    partial class UserPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.ULName = new System.Windows.Forms.Label();
            this.UName = new System.Windows.Forms.Label();
            this.FollowUnfollowButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PathLenLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login:";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(124, 88);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(10, 13);
            this.Login.TabIndex = 5;
            this.Login.Text = "-";
            // 
            // ULName
            // 
            this.ULName.AutoSize = true;
            this.ULName.Location = new System.Drawing.Point(124, 54);
            this.ULName.Name = "ULName";
            this.ULName.Size = new System.Drawing.Size(10, 13);
            this.ULName.TabIndex = 4;
            this.ULName.Text = "-";
            // 
            // UName
            // 
            this.UName.AutoSize = true;
            this.UName.Location = new System.Drawing.Point(124, 24);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(10, 13);
            this.UName.TabIndex = 3;
            this.UName.Text = "-";
            // 
            // FollowUnfollowButton
            // 
            this.FollowUnfollowButton.Location = new System.Drawing.Point(377, 198);
            this.FollowUnfollowButton.Name = "FollowUnfollowButton";
            this.FollowUnfollowButton.Size = new System.Drawing.Size(75, 23);
            this.FollowUnfollowButton.TabIndex = 6;
            this.FollowUnfollowButton.Text = "Follow";
            this.FollowUnfollowButton.UseVisualStyleBackColor = true;
            this.FollowUnfollowButton.Click += new System.EventHandler(this.FollowButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mininum path between you and this user is ";
            // 
            // PathLenLable
            // 
            this.PathLenLable.AutoSize = true;
            this.PathLenLable.Location = new System.Drawing.Point(237, 130);
            this.PathLenLable.Name = "PathLenLable";
            this.PathLenLable.Size = new System.Drawing.Size(10, 13);
            this.PathLenLable.TabIndex = 8;
            this.PathLenLable.Text = "-";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 233);
            this.Controls.Add(this.PathLenLable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FollowUnfollowButton);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.ULName);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label ULName;
        private System.Windows.Forms.Label UName;
        private System.Windows.Forms.Button FollowUnfollowButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PathLenLable;
    }
}