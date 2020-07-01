using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //Thư viện cung cấp quyền truy cập vào các quy trình cục bộ và từ xa và cho phép bạn bắt đầu và dừng các quy trình hệ thống cục bộ.

namespace BTL_HDH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadProcessList(); //Tải lại danh sách các tiến trình
        }
        private void loadProcessList() //Tải lại danh sách các tiến trình
        {
            listView1.Items.Clear(); //Xóa các mục ở ListView
            Process[] processlist = Process.GetProcesses(); //Tạo một mảng có tên processlist để lưu trữ các tiến trình
            foreach (Process process in processlist) // Duyệt mảng : kiểm tra xem có trong mảng
            {
                ListViewItem item = new ListViewItem(process.ProcessName); //Khai bảo 1 ListViewItem là item
                item.Tag = process; 
                listView1.Items.Add(item); // nếu item là process thì thêm vào ListView
            }
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            string text = Start_TextBox.Text; // Khai báo biến text
            Process process = new Process(); //Khai báo biến process
            process.StartInfo.FileName = text; //thông tin khởi động tiến trình là text thì khởi động tiến trình
            process.Start(); 
            loadProcessList(); //Tải lại danh sách tiến trình sau khi khởi động 1 tiến trình

        }

        private void bt_End_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0]; // item lấy giá trị là mảng chứa cột đầu tiên trong ListView
            Process process = (Process)item.Tag;
            process.Kill(); //Dừng tiến trình
            loadProcessList(); //Tải lại danh sách tiến trình sau khi dừng 1 tiến trình
        }
    }
}
