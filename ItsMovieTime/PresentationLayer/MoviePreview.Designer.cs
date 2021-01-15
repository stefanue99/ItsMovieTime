
namespace PresentationLayer
{
    partial class MoviePreview
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelOnlineLink = new System.Windows.Forms.Label();
            this.checkBoxFavorite = new System.Windows.Forms.CheckBox();
            this.checkBoxWatched = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(505, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDescription
            // 
            this.labelDescription.BackColor = System.Drawing.Color.Tan;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(30, 115);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(471, 274);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "opis";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(31, 58);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(138, 21);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "godina snimanja";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(31, 85);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(43, 21);
            this.labelGenre.TabIndex = 3;
            this.labelGenre.Text = "zanr";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(30, 409);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(56, 21);
            this.labelRating.TabIndex = 4;
            this.labelRating.Text = "ocena";
            // 
            // labelOnlineLink
            // 
            this.labelOnlineLink.AutoSize = true;
            this.labelOnlineLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOnlineLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnlineLink.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelOnlineLink.Location = new System.Drawing.Point(30, 449);
            this.labelOnlineLink.Name = "labelOnlineLink";
            this.labelOnlineLink.Size = new System.Drawing.Size(197, 21);
            this.labelOnlineLink.TabIndex = 5;
            this.labelOnlineLink.Text = "Link ka sajtu za gledanje";
            this.labelOnlineLink.Click += new System.EventHandler(this.labelOnlineLink_Click);
            // 
            // checkBoxFavorite
            // 
            this.checkBoxFavorite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFavorite.Location = new System.Drawing.Point(385, 403);
            this.checkBoxFavorite.Name = "checkBoxFavorite";
            this.checkBoxFavorite.Size = new System.Drawing.Size(104, 27);
            this.checkBoxFavorite.TabIndex = 9;
            this.checkBoxFavorite.Text = "Favorit";
            this.checkBoxFavorite.UseVisualStyleBackColor = true;
            // 
            // checkBoxWatched
            // 
            this.checkBoxWatched.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWatched.Location = new System.Drawing.Point(252, 403);
            this.checkBoxWatched.Name = "checkBoxWatched";
            this.checkBoxWatched.Size = new System.Drawing.Size(104, 27);
            this.checkBoxWatched.TabIndex = 8;
            this.checkBoxWatched.Text = "Odgledan";
            this.checkBoxWatched.UseVisualStyleBackColor = true;
            // 
            // MoviePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(529, 484);
            this.Controls.Add(this.checkBoxFavorite);
            this.Controls.Add(this.checkBoxWatched);
            this.Controls.Add(this.labelOnlineLink);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Name = "MoviePreview";
            this.Text = "Movie";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MoviePreview_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelOnlineLink;
        private System.Windows.Forms.CheckBox checkBoxFavorite;
        private System.Windows.Forms.CheckBox checkBoxWatched;
    }
}