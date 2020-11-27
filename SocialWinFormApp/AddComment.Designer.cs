namespace SocialWinFormApp
{
    partial class AddComment
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
            this.CommentText = new System.Windows.Forms.RichTextBox();
            this.CommentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(12, 39);
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(436, 96);
            this.CommentText.TabIndex = 0;
            this.CommentText.Text = "";
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(373, 206);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(75, 23);
            this.CommentButton.TabIndex = 1;
            this.CommentButton.Text = "Comment";
            this.CommentButton.UseVisualStyleBackColor = true;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // AddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 241);
            this.Controls.Add(this.CommentButton);
            this.Controls.Add(this.CommentText);
            this.Name = "AddComment";
            this.Text = "AddComment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CommentText;
        private System.Windows.Forms.Button CommentButton;
    }
}