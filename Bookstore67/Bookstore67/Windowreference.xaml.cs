using System;
using System.Collections.Generic;
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

namespace Bookstore67
{
    /// <summary>
    /// Логика взаимодействия для Windowreference.xaml
    /// </summary>
    public partial class Windowreference : Window
    {
        public Windowreference()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для поиска товара начните писать наименование товара в соответствующие поле. " +
                "Для сортировки выберите поле по которому хотите сортировать в соответствующем выпадающем окне" +
                "Функциональное взаимодействия с товаром :" +
                "Для удаления товара нажмите кнопку удалить напротив него " +
                "Для редактирования товара нажмите кнопку изменить напротив него" +
                "для добавления нового товара нажмите кнопку добавить товар " +
                "для просмотра ежемесячного отчёта нажмите соответствующую кнопку");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для поиска товара начните писать наименование товара в соответствующие поле. " +
                "Для сортировки выберите поле по которому хотите сортировать в соответствующем выпадающем окне" +
                "Функциональное взаимодействия с товаром :" +
                "Для удаления товара нажмите кнопку удалить напротив него " +
                "Для редактирования товара нажмите кнопку изменить напротив него" +
                "для добавления нового товара нажмите кнопку добавить товар ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для покупки товара создайте аккаунт или авторизируйтесь");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Для поиска товара начните писать наименование товара в соответствующие поле. " +
               "Для сортировки выберите поле по которому хотите сортировать в соответствующем выпадающем окне" +
               "Для покупки товара нажмите на кнопку  Купить напротив соответствуещего товара.В появивишемся окне укажите количество" +
               "товар появится в вашей корзине " +
               "Для оплаты выбранных вами товаров откройте корзину. Чтобы оплатить нажмите соответствующую кнопку " +
               "для очищения корзины нажмите Очистить " +
               "По кнопке история можно ознакомится с историей заказов");
        }
    }
}
