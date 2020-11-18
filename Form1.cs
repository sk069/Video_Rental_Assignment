using System;
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


    }
}

