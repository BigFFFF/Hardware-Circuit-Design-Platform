using Embedded._02_Form;
using Embedded._03_Function;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Embedded
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private User GetText(User user)
        {
            //获取用户输入信息
            user.Num = TextNum.Text.Trim();
            user.Name = TextName.Text.Trim();
            user.Pwd = TextPwd.Text.Trim();

            //判断是否为空
            if (string.IsNullOrEmpty(user.Num))
            {
                MessageBox.Show("请输入学号！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextNum.Focus();
                return null;
            }
            if (string.IsNullOrEmpty(user.Name))
            {
                MessageBox.Show("请输入姓名！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextName.Focus();
                return null;
            }
            if (string.IsNullOrEmpty(user.Pwd))
            {
                MessageBox.Show("请输入密码！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextPwd.Focus();
                return null;
            }

            return user;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = GetText(user);
            if (user == null) {
                return;
            }

            //与数据库通信
            String cs = @"server=127.0.0.1; port=3306; user=root; password=123456; database=embeddeddb;";

            using var con = new MySqlConnection(cs);
            con.Open();

            var sql = "select count(1) from userinfo where stu_num = @tNum and stu_name = @tName and stu_pwd = @tPwd";
            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@tNum", user.Num);
            cmd.Parameters.AddWithValue("@tName", user.Name);
            cmd.Parameters.AddWithValue("@tPwd", user.Pwd);
            cmd.Prepare();

            //处理结果
            object o = cmd.ExecuteScalar();
            if (o == null || o == DBNull.Value || (Convert.ToInt32(o)) == 0)
            {
                MessageBox.Show("登录学号、姓名或密码有错，请检查！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("登陆成功!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //转到主页面
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = GetText(user);
            if (user == null){
                return;
            }

            //与数据库通信
            String cs = @"server=127.0.0.1; port=3306; user=root; password=123456; database=embeddeddb;";

            using var con = new MySqlConnection(cs);
            con.Open();

            var sql = "insert into userinfo(stu_num, stu_name, stu_pwd) values(@tNum, @tName, @tPwd)";

            using var cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@tNum", user.Num);
            cmd.Parameters.AddWithValue("@tName", user.Name);
            cmd.Parameters.AddWithValue("@tPwd", user.Pwd);
            cmd.Prepare();

            //处理结果
            try
            {
                object o = cmd.ExecuteNonQuery();
                MessageBox.Show("注册成功!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("注册学号有错或重复，请检查！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
