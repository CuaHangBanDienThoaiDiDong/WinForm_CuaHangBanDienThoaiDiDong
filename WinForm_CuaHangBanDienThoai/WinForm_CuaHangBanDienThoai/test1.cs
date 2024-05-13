using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CuaHangBanDienThoai
{
    public partial class test1 : Form
    {
        private string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Thu;User Id=sa;Password=123;";
        private string imagePath;

        public test1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = imagePath;

                // Tạo tên hình ảnh từ một chuỗi số duy nhất
                string imageName = textBox1.Text;

                // Đọc dữ liệu hình ảnh từ tệp
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                // Lưu trữ dữ liệu hình ảnh và tên hình ảnh vào cơ sở dữ liệu
                button2_Click(imageName, imageBytes);
            }
            MessageBox.Show("ok");
        }



        private void button2_Click(string imageName, byte[] imageBytes)
        {
           // int newImageID = AddNewImage(imagePath); 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Images (ImageID, ImageData) VALUES (@ImageID, @ImageData)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ImageID", imageName);
                    command.Parameters.AddWithValue("@ImageData", imageBytes);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("hien r do ");
        }
    }
} 
//private void button1_Click(object sender, EventArgs e)
//{
//    OpenFileDialog openFileDialog = new OpenFileDialog();
//    openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

//    if (openFileDialog.ShowDialog() == DialogResult.OK)
//    {
//        string imagePath = openFileDialog.FileName;
//        pictureBox1.ImageLocation = imagePath;

//        // Lấy tên hình ảnh từ TextBox
//        string imageName = textBox1.Text;

//        // Đọc dữ liệu hình ảnh từ tệp
//        byte[] imageBytes = File.ReadAllBytes(imagePath);

//        // Lưu trữ dữ liệu hình ảnh và tên hình ảnh vào cơ sở dữ liệu
//        button2_Click(imageName, imageBytes);
//    }
//    MessageBox.Show("ok");

//}

//private void button2_Click(string imageName, byte[] imageBytes)
//{
//    using (SqlConnection connection = new SqlConnection(connectionString))
//    {
//        connection.Open();
//        string sql = "INSERT INTO Images (ImageID, ImageData) VALUES (@ImageID, @ImageData)";
//        using (SqlCommand command = new SqlCommand(sql, connection))
//        {
//            command.Parameters.AddWithValue("@ImageID", imageName);
//            command.Parameters.AddWithValue("@ImageData", imageBytes);
//            command.ExecuteNonQuery();
//        }
//    }
//    MessageBox.Show("hien r do ");
//}