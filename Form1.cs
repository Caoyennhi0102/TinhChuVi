namespace TinhChuVi
{
    public partial class Form1 : Form
    {
        double d;
        double r;
        public Form1()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            
            LayThongTin();


           textBox3.Text = "-Diện Tích: " + TinhHinhChuNhat(d, r) + Environment.NewLine + "Chu Vi: " + TinhChuVi(d, r);
        }
        private double TinhHinhChuNhat(double d, double r)
        {
            
            return d * r;
        }
        private double TinhChuVi(double d , double r)
        {
            
            return (d + r) * 2;
        }
        private bool LayThongTin()
        {
            try
            {
                d = Convert.ToDouble(textBox1.Text);
                r = Convert.ToDouble(textBox2.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Phải Nhập Số và Số Nguyên", "Thông Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
