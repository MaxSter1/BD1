namespace SocialWinFormApp
{
    partial class StartPage
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
            this.MyPageButton = new System.Windows.Forms.Button();
            this.UserListPage = new System.Windows.Forms.Button();
            this.PostListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyPageButton
            // 
            this.MyPageButton.Location = new System.Drawing.Point(12, 12);
            this.MyPageButton.Name = "MyPageButton";
            this.MyPageButton.Size = new System.Drawing.Size(75, 23);
            this.MyPageButton.TabIndex = 0;
            this.MyPageButton.Text = "MyPage";
            this.MyPageButton.UseVisualStyleBackColor = true;
            this.MyPageButton.Click += new System.EventHandler(this.MyPageButton_Click);
            // 
            // UserListPage
            // 
            this.UserListPage.Location = new System.Drawing.Point(124, 12);
            this.UserListPage.Name = "UserListPage";
            this.UserListPage.Size = new System.Drawing.Size(75, 23);
            this.UserListPage.TabIndex = 1;
            this.UserListPage.Text = "UserList";
            this.UserListPage.UseVisualStyleBackColor = true;
            this.UserListPage.Click += new System.EventHandler(this.button2_Click);
            // 
            // PostListButton
            // 
            this.PostListButton.Location = new System.Drawing.Point(234, 12);
            this.PostListButton.Name = "PostListButton";
            this.PostListButton.Size = new System.Drawing.Size(75, 23);
            this.PostListButton.TabIndex = 2;
            this.PostListButton.Text = "PostList";
            this.PostListButton.UseVisualStyleBackColor = true;
            this.PostListButton.Click += new System.EventHandler(this.PostListButton_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 59);
            this.Controls.Add(this.PostListButton);
            this.Controls.Add(this.UserListPage);
            this.Controls.Add(this.MyPageButton);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MyPageButton;
        private System.Windows.Forms.Button UserListPage;
        private System.Windows.Forms.Button PostListButton;
    }
}