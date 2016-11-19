using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindBasketApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> empList = new List<Employee>();
        List<Customer> custList = new List<Customer>();
        List<Product> proList = new List<Product>();
        List<Shipper> shipList = new List<Shipper>();
        Customer cus;
        Employee emp;
        Product pro;
        Shipper ship;
        object result;
        private int stock;
        private int productID;
        private string productName;
        private string employeeName;
        private int employeeID;
        private string customerName;
        private string customerID;
        private string shipperName;
        private int shipperID;
        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployee();
            GetCustomer();
            GetProduct();
            GetShipper();
        }

        public void GetEmployee()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.Cnn;
            cmd.CommandText = "select EmployeeID,FirstName,LastName From Employees";
            SqlHelper.Cnn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    emp = new Employee();
                    emp.EmployeeID = int.Parse(dataReader[0].ToString());
                    emp.EmployeFirstName = (string)dataReader[1];
                    emp.EmployeeLastName = (string)dataReader[2];
                    empList.Add(emp);
                }

                cmbEmployee.DataSource = empList;
            }
            SqlHelper.Cnn.Close();
        }

        public void GetCustomer()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.Cnn;
            cmd.CommandText = "select CustomerID,CompanyName From Customers";
            SqlHelper.Cnn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    cus = new Customer();
                    cus.CustomerID = dataReader[0].ToString();
                    cus.CompanyName = (string)dataReader[1];

                    custList.Add(cus);
                }

                cmbCustomer.DataSource = custList;   
            }

            SqlHelper.Cnn.Close();
        }

        public void GetProduct()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.Cnn;
            cmd.CommandText = "select ProductID, ProductName,UnitsInStock from Products";
            SqlHelper.Cnn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    pro = new Product();
                    pro.ProductID = int.Parse(dataReader[0].ToString());
                    pro.ProductName = (string)dataReader[1];
                    pro.UnitsInStock = short.Parse(dataReader[2].ToString());

                    proList.Add(pro);
                }

                cmbProducts.DataSource = proList;
            }

            SqlHelper.Cnn.Close();
        }

        public void GetShipper() 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.Cnn;
            cmd.CommandText = "select ShipperID, CompanyName from Shippers";
            SqlHelper.Cnn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    ship = new Shipper();
                    ship.shipperID = int.Parse(dataReader[0].ToString());
                    ship.shipperName = (string)dataReader[1];
 
                    shipList.Add(ship);
                }

                cmbShipper.DataSource = shipList;
            }

            SqlHelper.Cnn.Close();
        }

        public void GetOrderDetails()
        {
            listView1.Visible = true;
            SqlHelper.Cnn.Close();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("Select emp.FirstName+' '+emp.LastName,cus.CompanyName,shp.CompanyName,p.ProductName,p.UnitsInStock ,odt.Quantity From Shippers shp inner join Orders od on shp.ShipperID=od.ShipVia inner join Employees emp on emp.EmployeeID=od.EmployeeID inner join Customers cus on cus.CustomerID=od.CustomerID inner join [Order Details] odt on odt.OrderID=od.OrderID inner join Products p on p.ProductID=odt.ProductID Where od.OrderID={0}",result);
            cmd.Connection = SqlHelper.Cnn;

            try
            {
                cmd.Connection.Open();
                SqlDataReader dataRader = cmd.ExecuteReader();
                if (dataRader.HasRows)
                {
                    while (dataRader.Read())
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = dataRader[0].ToString();
                        li.SubItems.Add(dataRader[1].ToString());
                        li.SubItems.Add(dataRader[2].ToString());
                        li.SubItems.Add(dataRader[3].ToString());
                        li.SubItems.Add(dataRader[4].ToString());
                        li.SubItems.Add(dataRader[5].ToString());

                        listView1.Items.Add(li);
                        
                    }
                }
                cmd.Connection.Close();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnOrderCreate_Click(object sender, EventArgs e)
        {
            SqlHelper.Cnn.Close();


            foreach (Employee item in empList)
            {
                if (cmbEmployee.SelectedValue.ToString() == item.FullName)
                {
                    employeeName = item.FullName;
                    employeeID = item.EmployeeID;
                }
            }
            foreach (Customer item in custList)
            {
                if (cmbCustomer.SelectedValue.ToString() == item.CompanyName)
                {
                    customerID = item.CustomerID;
                    customerName = item.CompanyName;
                }
            }
            foreach (Shipper item in shipList)
            {
                if (cmbShipper.SelectedValue.ToString() == item.shipperName)
                {
                    shipperID = item.shipperID;
                    shipperName = item.shipperName;
                }
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.Cnn;
            cmd.CommandText = "sp_CreateOrder";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeID",employeeID);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            cmd.Parameters.AddWithValue("@shipvia", shipperID);
            try
            {
                cmd.Connection.Open();
                
                result = cmd.ExecuteScalar();

                if (result!=null)
                {

                    MessageBox.Show("Siparişiniz Oluşturulmuştur. Lütfen siparişinize Ürün Ekleyiniz.");
                    groupBoxProductsAdd.Visible = true;
                }
                else
                {
                    MessageBox.Show("Siparişiniz Oluşturulamadı!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally 
            {
                cmd.Connection.Close();
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
                  
            SqlHelper.Cnn.Close();

            foreach (Product item in proList)
            {
                if (cmbProducts.SelectedValue.ToString() == item.ProductName)
                {
                    stock = item.UnitsInStock;
                    productID = item.ProductID;
                    productName = item.ProductName;

                }
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = SqlHelper.Cnn;
            cmd.CommandText = "sp_ProducSend";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@orderID",result);
            cmd.Parameters.AddWithValue("@productID", productID);
            cmd.Parameters.AddWithValue("@quantity", txtProductCount.Text);

            try
            {
                cmd.Connection.Open();

                
                if (stock > int.Parse(txtProductCount.Text))
                {
                    int isAdd = cmd.ExecuteNonQuery();

                    if (isAdd > 0)
                    {
                        SqlHelper.Cnn.Close();
                        SqlCommand cmdProductUpdate = new SqlCommand();
                        cmdProductUpdate.Connection = SqlHelper.Cnn;
                        cmdProductUpdate.CommandText="sp_Destock";
                        cmdProductUpdate.CommandType = CommandType.StoredProcedure;
                        cmdProductUpdate.Parameters.AddWithValue("@orderCount",txtProductCount.Text);
                        cmdProductUpdate.Parameters.AddWithValue("@productID", productID);

                        try
                        {
                            cmdProductUpdate.Connection.Open();
                            int stockUpdate = cmdProductUpdate.ExecuteNonQuery();
                            if (stockUpdate > 0)
                            {
                                MessageBox.Show(productName + "  İsimli Siparişinizden " + txtProductCount.Text + " adet yollanmıştır. Stokta " + stock + " adet ürün kalmıştır.");
                                GetOrderDetails();
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            cmdProductUpdate.Connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Siparişiniz yollanamadı!");
                    }
                }
                else 
                {
                    MessageBox.Show("Stokta Yeterli Ürün yoktur!");
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
    }
}
