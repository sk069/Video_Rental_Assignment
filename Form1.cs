﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Assignment
{
    public partial class Video_Rental : Form
    {
        Database_class Obj_Data = new Database_class();

        public object DGV_Movie { get; private set; }

        public Video_Rental()
        {
            InitializeComponent();
            tab_Customer_Data();
            Movies_Load();
            Rental_Load();
        }

        public void tab_Customer_Data()
        {
            DGV_Customer.DataSource = null;
            try
            {
                DGV_Customer.DataSource = Obj_Data.FillCustomer_Data();
                DGV_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Movies_Load()
        {
            DGV_movie.DataSource = null;
            try
            {
                DGV_movie.DataSource = Obj_Data.FillMovies_Data();
                DGV_movie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rental_Load()
        {
            DGV_Rental.DataSource = null;
            try
            {
                DGV_Rental.DataSource = Obj_Data.FillRental_Data();
                DGV_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Add_customer_Click(object sender, EventArgs e)
        {
            if (text_firstname.Text != "" && text_lastname.Text != "" && text_address.Text != "" && text_mobile.Text != "")
            {
                string message = Obj_Data.CustomerInsert(text_firstname.Text, text_lastname.Text, text_mobile.Text, text_address.Text);
                MessageBox.Show(message);
                text_firstname.Text = "";
                text_lastname.Text = "";
                text_mobile.Text = "";
                text_address.Text = "";
                tab_Customer_Data();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }

        private void DGV_Customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.CustomerID = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells[0].Value);
                text_firstname.Text = DGV_Customer.Rows[e.RowIndex].Cells[1].Value.ToString();
                text_lastname.Text = DGV_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                text_mobile.Text = DGV_Customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                text_address.Text = DGV_Customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                text_custName.Text = DGV_Customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + DGV_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }






    


    private void Btn_Update_customdata_Click(object sender, EventArgs e)
    {
        if (text_firstname.Text != "" && text_lastname.Text != "" && text_address.Text != "" && text_mobile.Text != "")
        {
            string message = Obj_Data.CustomerUpdate(text_firstname.Text, text_lastname.Text, text_mobile.Text, text_address.Text);
            MessageBox.Show(message);
            text_firstname.Text = "";
            text_lastname.Text = "";
            text_mobile.Text = "";
            text_address.Text = "";
            tab_Customer_Data();
        }
        else
        {
            MessageBox.Show("Please fill all the fileds then press Add button");
        }
    }

    private void btn_Delete_Click(object sender, EventArgs e)
    {
        string message = Obj_Data.CustomerDelete();
        MessageBox.Show(message);
        text_firstname.Text = "";
        text_lastname.Text = "";
        text_mobile.Text = "";
        text_address.Text = "";
        tab_Customer_Data();
    }



        private void Btn_addmovie_Click(object sender, EventArgs e)
        {
            if (text_Rating.Text != "" && text_Title.Text != "" && text_year.Text != "" && Text_Rental_Cost.Text != "" && text_copies.Text != "" && text_plot.Text != "" && text_genre.Text != "")
            {
                string message = Obj_Data.MoviesInsert(text_Rating.Text, text_Title.Text, text_year.Text,Text_Rental_Cost.Text,text_copies.Text, text_plot.Text, text_genre.Text);
                MessageBox.Show(message);
                text_Rating.Text = "";
                text_Title.Text = "";
                text_year.Text = "";
                Text_Rental_Cost.Text = "";
                text_copies.Text = "";
                text_plot.Text = "";
                text_genre.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }

        private void DGV_Movie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_movie.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.MoviesID = Convert.ToInt32(DGV_movie.Rows[e.RowIndex].Cells[0].Value);
                text_Rating.Text = DGV_movie.Rows[e.RowIndex].Cells[1].Value.ToString();
                text_Title.Text = DGV_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
                text_year.Text = DGV_movie.Rows[e.RowIndex].Cells[3].Value.ToString();
                Text_Rental_Cost.Text = DGV_movie.Rows[e.RowIndex].Cells[4].Value.ToString();
                text_copies.Text = DGV_movie.Rows[e.RowIndex].Cells[5].Value.ToString();
                text_plot.Text = DGV_movie.Rows[e.RowIndex].Cells[6].Value.ToString();
                text_genre.Text = DGV_movie.Rows[e.RowIndex].Cells[7].Value.ToString();
                text_TitleM.Text = DGV_movie.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }
       

        private void Btn_updatemovie_Click(object sender, EventArgs e)
        {
            if (text_Rating.Text != "" && text_Title.Text != "" && text_year.Text != "" && Text_Rental_Cost.Text != "" && text_copies.Text != "" && text_plot.Text != "" && text_genre.Text != "")
            {
                string message = Obj_Data.MoviesInsert(text_Rating.Text, text_Title.Text, text_year.Text, Text_Rental_Cost.Text, text_copies.Text, text_plot.Text, text_genre.Text);
                MessageBox.Show(message);
                text_Rating.Text = "";
                text_Title.Text = "";
                text_year.Text = "";
                Text_Rental_Cost.Text = "";
                text_copies.Text = "";
                text_plot.Text = "";
                text_genre.Text = "";
                Movies_Load();
            }
            else
            {
                MessageBox.Show("Please fill all the fileds then press Add button");
            }
        }

        private void Btn_delmovie_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.MoviesDelete();
            MessageBox.Show(message);
            text_Rating.Text = "";
            text_Title.Text = "";
            text_year.Text = "";
            Text_Rental_Cost.Text = "";
            text_copies.Text = "";
            text_plot.Text = "";
            text_genre.Text = "";
            Movies_Load();
        }

        private void btn_allrented_Click(object sender, EventArgs e)
        {
            Rental_Load();
        }

        private void btn_rentedout_Click(object sender, EventArgs e)
        {
            DGV_Rental.DataSource = null;
            try
            {
                DGV_Rental.DataSource = Obj_Data.FillAll_Rented_out();
                DGV_Rental.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
    
}
    


