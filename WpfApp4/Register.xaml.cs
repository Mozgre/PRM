using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }
        private void Registraciya(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string password = Password.Password;
            string dopPassword = DopPassword.Password;
            string firstName = FirstName.Text;
            string name = Name.Text;
            string surName = SurName.Text;
            List<User> users = Singletone.DB.User.Where(user => user.Login == login).ToList();
            if (login != string.Empty && password != string.Empty && dopPassword != string.Empty && firstName != string.Empty && name != string.Empty && surName != string.Empty)
            {
                if(password == dopPassword)
                {
                        User user = new User();
                        user.Login = login;
                        user.Password = password;
                        People people = new People();
                        people.SurName = firstName;
                        people.Name = name;
                        people.SecondName = surName;
                        people.User = user;
                        if (users.Count < 1)
                        {
                        Singletone.DB.User.Add(user);
                        Singletone.DB.People.Add(people);
                        Singletone.DB.SaveChanges();
                        MessageBox.Show("Пользователь зарегистрирован");
                        //Close();
                    }
                        else
                        {
                            MessageBox.Show("Такой логин уже занят");
                        }
                }
                else
                {
                    MessageBox.Show("Пароли должны совпадать");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }
        private void Otmena(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
