namespace Video_Rental_Assignment
{
    partial class Video_Rental
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
            this.tab_Movie_rental = new System.Windows.Forms.TabControl();
            this.tab_Customer = new System.Windows.Forms.TabPage();
            this.tab_Movie = new System.Windows.Forms.TabPage();
            this.tab_Rental = new System.Windows.Forms.TabPage();
            this.DGV_Rental = new System.Windows.Forms.DataGridView();
            this.DGV_movie = new System.Windows.Forms.DataGridView();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.tab_Movie_rental.SuspendLayout();
            this.tab_Customer.SuspendLayout();
            this.tab_Movie.SuspendLayout();
            this.tab_Rental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Movie_rental
            // 
            this.tab_Movie_rental.Controls.Add(this.tab_Customer);
            this.tab_Movie_rental.Controls.Add(this.tab_Movie);
            this.tab_Movie_rental.Controls.Add(this.tab_Rental);
            this.tab_Movie_rental.Location = new System.Drawing.Point(12, 12);
            this.tab_Movie_rental.Name = "tab_Movie_rental";
            this.tab_Movie_rental.SelectedIndex = 0;
            this.tab_Movie_rental.Size = new System.Drawing.Size(512, 217);
            this.tab_Movie_rental.TabIndex = 0;
            // 
            // tab_Customer
            // 
            this.tab_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tab_Customer.Controls.Add(this.DGV_Customer);
            this.tab_Customer.Location = new System.Drawing.Point(4, 22);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customer.Size = new System.Drawing.Size(504, 191);
            this.tab_Customer.TabIndex = 0;
            this.tab_Customer.Text = "Customer";
            // 
            // tab_Movie
            // 
            this.tab_Movie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tab_Movie.Controls.Add(this.DGV_movie);
            this.tab_Movie.Location = new System.Drawing.Point(4, 22);
            this.tab_Movie.Name = "tab_Movie";
            this.tab_Movie.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Movie.Size = new System.Drawing.Size(504, 191);
            this.tab_Movie.TabIndex = 1;
            this.tab_Movie.Text = "Movie";
            // 
            // tab_Rental
            // 
            this.tab_Rental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_Rental.Controls.Add(this.DGV_Rental);
            this.tab_Rental.Location = new System.Drawing.Point(4, 22);
            this.tab_Rental.Name = "tab_Rental";
            this.tab_Rental.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rental.Size = new System.Drawing.Size(504, 191);
            this.tab_Rental.TabIndex = 2;
            this.tab_Rental.Text = "Rental";
            // 
            // DGV_Rental
            // 
            this.DGV_Rental.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGV_Rental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rental.Location = new System.Drawing.Point(6, 6);
            this.DGV_Rental.Name = "DGV_Rental";
            this.DGV_Rental.Size = new System.Drawing.Size(492, 179);
            this.DGV_Rental.TabIndex = 0;
            // 
            // DGV_movie
            // 
            this.DGV_movie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DGV_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_movie.Location = new System.Drawing.Point(6, 6);
            this.DGV_movie.Name = "DGV_movie";
            this.DGV_movie.Size = new System.Drawing.Size(492, 179);
            this.DGV_movie.TabIndex = 0;
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(6, 6);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.Size = new System.Drawing.Size(495, 179);
            this.DGV_Customer.TabIndex = 0;
            // 
            // Video_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_Movie_rental);
            this.Name = "Video_Rental";
            this.Text = "Video_Rental";
            this.tab_Movie_rental.ResumeLayout(false);
            this.tab_Customer.ResumeLayout(false);
            this.tab_Movie.ResumeLayout(false);
            this.tab_Rental.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Movie_rental;
        private System.Windows.Forms.TabPage tab_Customer;
        private System.Windows.Forms.TabPage tab_Movie;
        private System.Windows.Forms.TabPage tab_Rental;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.DataGridView DGV_movie;
        private System.Windows.Forms.DataGridView DGV_Rental;
    }
}

