﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace MyPos
{
    /// <summary>
    /// Interaction logic for SalesReturnControl.xaml
    /// </summary>
    public partial class SalesReturnControl : UserControl
    {
        public SalesReturnControl()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        private int rowindex;

        //clear all text field values 
        private void clearAll()
        {
            txtProductID.Text = "";
            txtDate.Text = "";
            txtDescription.Text = "";
            txtQuantity.Text = "";
            txtQuantityReturn.Text = "";
            txtTotal.Text = "";
            txtUnitPrice.Text = "";
            txtQuantityReturn.Text = "";
        }

        //find product information
        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            long bno = long.Parse(txtbillNo.Text);
            int pID = int.Parse(txtProductID.Text);

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT date,description,quantity,unitprice,total FROM Sales WHERE billno=" + bno + " AND productID=" + pID;
                cmd.Connection = con;
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    txtDate.Text = rd.GetValue(0).ToString();
                    txtDescription.Text = rd.GetValue(1).ToString();
                    txtQuantity.Text = rd.GetValue(2).ToString();
                    txtUnitPrice.Text = rd.GetValue(3).ToString();
                    txtTotal.Text = rd.GetValue(4).ToString();
                }
            }

        }

        //not allow other than numeric value in text box
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        //add to gridview
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //to check if any empty fields available
            if (txtbillNo.Text != "" || txtProductID.Text != "")
            {
                //set attribute for data grid class
                var data = new Grid2 {
                    p1 = int.Parse(txtProductID.Text),
                    p2 = txtDescription.Text,
                    p3 = int.Parse(txtQuantityReturn.Text),
                    p4 = decimal.Parse(txtUnitPrice.Text),
                    p5 = ((decimal.Parse(txtTotal.Text)/decimal.Parse(txtQuantity.Text))*decimal.Parse(txtQuantityReturn.Text))
                };

                grdReturnDetails.Items.Add(data);
                clearAll();
            }
        }

        //for deletion
        private void grdReturnDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if (e.AddedItems != null && e.AddedItems.Count > 0)
            {
                DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromItem(e.AddedItems[0]);
                if (row != null)
                {
                    btnAdd.IsEnabled = false;
                    rowindex = row.GetIndex();
                }
            }
        }
        static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            T child = default(T);
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
                child = v as T;
                if (child == null) child = GetVisualChild<T>(v);
                if (child != null) break;
            }
            return child;
        }
    
        //remove from data grid 
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            grdReturnDetails.Items.RemoveAt(rowindex);
            btnAdd.IsEnabled = true;
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            //add return details to database
            string dt = DateTime.Now.ToString("MM/dd/yyyy");
            string date = Regex.Replace(dt, @"[^0-9]", "");
            long bn = long.Parse(txtbillNo.Text);

            //get each cell values in datagrid
            for (int i = 0; i < grdReturnDetails.Items.Count; i++)
            {
                //get each colomn value 
                TextBlock description = grdReturnDetails.Columns[1].GetCellContent(grdReturnDetails.Items[i]) as TextBlock;
                TextBlock unitPrice = grdReturnDetails.Columns[2].GetCellContent(grdReturnDetails.Items[i]) as TextBlock;
                TextBlock Quantity = grdReturnDetails.Columns[3].GetCellContent(grdReturnDetails.Items[i]) as TextBlock;
                TextBlock total = grdReturnDetails.Columns[4].GetCellContent(grdReturnDetails.Items[i]) as TextBlock;
                TextBlock productId = grdReturnDetails.Columns[0].GetCellContent(grdReturnDetails.Items[i]) as TextBlock;


                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO SalesReturn (billno, productID, description,quantity,amountreturn,date) VALUES (@bn,@pid,@des,@qu, @total,@dt)";
                    
                    cmd.Parameters.AddWithValue("@bn",long.Parse(txtbillNo.Text));
                    cmd.Parameters.AddWithValue("@pid", int.Parse(productId.Text));
                    cmd.Parameters.AddWithValue("@des", description.Text);
                    cmd.Parameters.AddWithValue("@qu", int.Parse(Quantity.Text));
                    cmd.Parameters.AddWithValue("@total", decimal.Parse(total.Text));
                    cmd.Parameters.AddWithValue("@dt", dt);


                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            //delete detalis from Sales

            //add to stock
        }
    }

    //add details to grid 
    public class Grid2
    {
        public int p1 { get; set; }
        public string p2 { get; set; }
        public int p3 { get; set; }
        public decimal p4 { get; set; }
        public decimal p5 { get; set; }
    } 
}


