namespace SocialWinFormApp
{
    partial class ViewComment
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
            this.SuspendLayout();
            // 
            // CommentText
            // 
            this.CommentText.Location = new System.Drawing.Point(12, 12);
            this.CommentText.Name = "CommentText";
            this.CommentText.ReadOnly = true;
            this.CommentText.Size = new System.Drawing.Size(390, 96);
            this.CommentText.TabIndex = 0;
            this.CommentText.Text = "";
            // 
            // ViewComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 121);
            this.Controls.Add(this.CommentText);
            this.Name = "ViewComment";
            this.Text = "ViewComment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CommentText;
    }
}