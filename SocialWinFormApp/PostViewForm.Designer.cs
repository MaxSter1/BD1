namespace SocialWinFormApp
{
    partial class PostViewForm
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
            this.Title = new System.Windows.Forms.RichTextBox();
            this.Body = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LikeCount = new System.Windows.Forms.Label();
            this.DislikeCount = new System.Windows.Forms.Label();
            this.LikeButton = new System.Windows.Forms.Button();
            this.DislikeButton = new System.Windows.Forms.Button();
            this.CommentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(12, 12);
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(360, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "";
            // 
            // Body
            // 
            this.Body.Location = new System.Drawing.Point(12, 47);
            this.Body.Name = "Body";
            this.Body.ReadOnly = true;
            this.Body.Size = new System.Drawing.Size(360, 263);
            this.Body.TabIndex = 1;
            this.Body.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Likes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dislikes:";
            // 
            // LikeCount
            // 
            this.LikeCount.AutoSize = true;
            this.LikeCount.Location = new System.Drawing.Point(37, 366);
            this.LikeCount.Name = "LikeCount";
            this.LikeCount.Size = new System.Drawing.Size(10, 13);
            this.LikeCount.TabIndex = 4;
            this.LikeCount.Text = "-";
            // 
            // DislikeCount
            // 
            this.DislikeCount.AutoSize = true;
            this.DislikeCount.Location = new System.Drawing.Point(362, 366);
            this.DislikeCount.Name = "DislikeCount";
            this.DislikeCount.Size = new System.Drawing.Size(10, 13);
            this.DislikeCount.TabIndex = 5;
            this.DislikeCount.Text = "-";
            // 
            // LikeButton
            // 
            this.LikeButton.Location = new System.Drawing.Point(12, 396);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(75, 23);
            this.LikeButton.TabIndex = 6;
            this.LikeButton.Text = "Like";
            this.LikeButton.UseVisualStyleBackColor = true;
            this.LikeButton.Click += new System.EventHandler(this.LikeButton_Click);
            // 
            // DislikeButton
            // 
            this.DislikeButton.Location = new System.Drawing.Point(297, 396);
            this.DislikeButton.Name = "DislikeButton";
            this.DislikeButton.Size = new System.Drawing.Size(75, 23);
            this.DislikeButton.TabIndex = 7;
            this.DislikeButton.Text = "Dislike";
            this.DislikeButton.UseVisualStyleBackColor = true;
            this.DislikeButton.Click += new System.EventHandler(this.DislikeButton_Click);
            // 
            // CommentsButton
            // 
            this.CommentsButton.Location = new System.Drawing.Point(417, 396);
            this.CommentsButton.Name = "CommentsButton";
            this.CommentsButton.Size = new System.Drawing.Size(75, 23);
            this.CommentsButton.TabIndex = 8;
            this.CommentsButton.Text = "Comments";
            this.CommentsButton.UseVisualStyleBackColor = true;
            this.CommentsButton.Click += new System.EventHandler(this.CommentsButton_Click);
            // 
            // PostViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 431);
            this.Controls.Add(this.CommentsButton);
            this.Controls.Add(this.DislikeButton);
            this.Controls.Add(this.LikeButton);
            this.Controls.Add(this.DislikeCount);
            this.Controls.Add(this.LikeCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.Title);
            this.Name = "PostViewForm";
            this.Text = "PostViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Title;
        private System.Windows.Forms.RichTextBox Body;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LikeCount;
        private System.Windows.Forms.Label DislikeCount;
        private System.Windows.Forms.Button LikeButton;
        private System.Windows.Forms.Button DislikeButton;
        private System.Windows.Forms.Button CommentsButton;
    }
}