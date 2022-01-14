using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Forms;
namespace WindowsFormsApp1.Forms
{
    public partial class LoginScreen : Form
    {
        bool isInDb = false;
        public LoginScreen()
        {
            InitializeComponent();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var uName = txtboxUserName.Text;
            var uPswd = txtboxUserPswd.Text;
            bool isUser = false;
            User user = new User{ usrId = Guid.NewGuid(), usrName = uName, usrPswd = uPswd, usrOnline = 0 };
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                    Table<User> users = db.GetTable<User>();
                    foreach (var u in users)
                    {
                        if (u.usrName == uName)
                        {
                            isUser = true;
                        }

                    }
                    if (isUser == false)
                    {
                        db.GetTable<User>().InsertOnSubmit(user);
                        db.SubmitChanges();
                        MessageBox.Show($"Пользователь {uName} был зарегистрирован!");
                        txtboxUserName.Clear();
                        txtboxUserPswd.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Такой пользователь уже существует");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var uName = txtboxUserName.Text;
            var uPswd = txtboxUserPswd.Text;
            
            User user = new User {usrName = uName, usrPswd = uPswd };
            try
            {
                using (var db = new MusicMixModelDataContext())
                {
                       
                    Table<User> users = db.GetTable<User>();
                    foreach (var usr in users)
                    {
                        if (usr.usrName == uName && usr.usrPswd == uPswd)
                        {
                            isInDb = true;
                            User userLogin = (from u in db.User where u.usrName == uName select u).Single<User>();
                            userLogin.usrOnline = 1;
                            db.SubmitChanges();
                        }
                        if (usr.usrName == uName && usr.usrPswd != uPswd)
                        {
                            MessageBox.Show($"Пользователь {uName} существует, но пароль неверен. Повторите ввод");
                            break;
                        }
                    }
                }
                if (isInDb == true)
                {
                    
                    MainForm showMain = new MainForm();
                    Close();
                    showMain.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Пользователь {uName} не существует. Повторите ввод");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isInDb != true)
            {
                Application.Exit();
            }

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            using (var db = new MusicMixModelDataContext())
            {
                Table<User> users = db.GetTable<User>();
                foreach (var u in users)
                {
                    u.usrOnline = 0;
                    db.SubmitChanges();
                }
            }
        }
    }
}
