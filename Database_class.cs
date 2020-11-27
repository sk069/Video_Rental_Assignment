﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Rental_Assignment
{
    public class Database_class
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;
        public int CustomerID, MoviesID;
        public Database_class()
        {
            string ConnString = @"Data Source=LAPTOP-QI9DM23C\SQLEXPRESS;Initial Catalog=VideoRental_SQL;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }

        public DataTable FillCustomer_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable FillMovies_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Movies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable FillRental_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From RentedMovies";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public string CustomerInsert(string FName, string LName, string Phone, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address,Phone) Values(@FirstName,@LastName,@Address, @Phone)";
                Cmd.Parameters.AddWithValue("@FirstName", FName);
                Cmd.Parameters.AddWithValue("@LastName", LName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Phone", Phone);
                Cmd.CommandText = QueryString;

                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string CustomerUpdate(string firstname, string lastname, string Phone, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "update Customer set FirstName = @FirstName,LastName = @LastName,Address = @Address, Phone = @Phone where CustID =@CustID";
                Cmd.Parameters.AddWithValue("@FirstName", firstname);
                Cmd.Parameters.AddWithValue("@LastName", lastname);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Phone);
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string CustomerDelete()
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;

                Cmd.CommandText = "Customer_Delete";
                Cmd.CommandType = CommandType.StoredProcedure;

                // QueryString = "Delete from Customer where CustID =@CustID";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                // Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }

        }
        public string MoviesInsert(string rating, string Title, string year, string Rental_Cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Movies(Title,rating,year,Rental_Cost,copies,plot,genre) Values(@Title,@Rating, @Year,@Rental_cost,@Copies,@Plot,@Genre)";
                Cmd.Parameters.AddWithValue("@Rating", rating);
                Cmd.Parameters.AddWithValue("@Title", Title);
                Cmd.Parameters.AddWithValue("@Year", year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Copies", copies);
                Cmd.Parameters.AddWithValue("@Plot", plot);
                Cmd.Parameters.AddWithValue("@Genre", genre);
                Cmd.CommandText = QueryString;

                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string updatemovie(string rating, string Title, string year, string Rental_Cost, string copies, string plot, string genre)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "update into movies set rating = @rating,title = @title,year = @year, rental_cost = @rental_cost, copies= @copies, plot= @plot, genre= @genre where MoviesID =@MoviesID";
                Cmd.Parameters.AddWithValue("@rating", rating);
                Cmd.Parameters.AddWithValue("@title", Title);
                Cmd.Parameters.AddWithValue("@year", year);
                Cmd.Parameters.AddWithValue("@Rental_Cost", Rental_Cost);
                Cmd.Parameters.AddWithValue("@Copies", copies);
                Cmd.Parameters.AddWithValue("@Plot", plot);
                Cmd.Parameters.AddWithValue("@Genre", genre);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string MoviesDelete()
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Movies where MovieID =@MovieID";
                Cmd.Parameters.AddWithValue("@MovieID", MoviesID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Movie Deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public DataTable Rental_Load()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From All_Rented_view";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
       
    
        public DataTable FillAll_Rented_out()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From All_Rented_out";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }


    }




}
           






    









