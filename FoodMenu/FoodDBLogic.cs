using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace FoodMenu
{
    public class FoodDBLogic
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["c432020fa02dangmConnectionString"].ConnectionString);

        public ArrayList getItems(string category)
        {
            string query = "SELECT itemName, itemPrice FROM Menu WHERE category = @category";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@category", SqlDbType.VarChar).Value = category;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                ArrayList l = new ArrayList();
                while (reader.Read())
                {
                    string itemName = reader.GetValue(0).ToString();
                    string itemPrice = reader.GetValue(1).ToString();
                    l.Add(itemName + " - $" + itemPrice);
                }
                reader.Close();
                command.Dispose();
                connection.Close();
                return l;
            }
            catch
            {
                return null;
            }
            
        }

        public bool addItems(string itemName,int quantity,double totalPrice)
        {
            string query = "INSERT INTO Cart VALUES (@itemName, @quantity,@totalPrice)";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@itemName", SqlDbType.VarChar).Value = itemName;
                command.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
                command.Parameters.Add("@totalPrice", SqlDbType.Float).Value = totalPrice;
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ArrayList showCarts()
        {
            string query = "SELECT itemName, quantity, totalPrice from Cart";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                ArrayList l = new ArrayList();
                while (reader.Read())
                {
                    string itemName = reader.GetValue(0).ToString();
                    string quantity = reader.GetValue(1).ToString();
                    string totalPrice = reader.GetValue(2).ToString();
                    l.Add(itemName + " (" + quantity + ") - $" + totalPrice);
                }
                reader.Close();
                command.Dispose();
                connection.Close();
                return l;
            }
            catch
            {
                return null;
            }
        }

        public string getTotal()
        {
            string query = "SELECT SUM(totalPrice) FROM Cart";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                string total = null;
                while (reader.Read())
                {
                    total = reader.GetValue(0).ToString();
                }
                reader.Close();
                command.Dispose();
                connection.Close();
                return total;
            }
            catch
            {
                return null;
            }
        }

        public bool clearCarts()
        {
            string query = "DELETE FROM Cart";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}