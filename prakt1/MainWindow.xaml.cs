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



namespace prakt1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Height += 23;
            Width += 23;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string developer = "Дудина ЕКатерина";
            int job = 1;
            string task = "Вычислить сумму целых случайных чисел, распределенных в диапазоне от - 7 до 3, \r\nпока эта сумма не превышает некоторого числа K. Вывести на экран \r\nсгенерированные числа, значение суммы, и количество сгенерированных чисел.";
            MessageBox.Show($"разработчик: {developer}\n номер работы {job}\n задание: {task}", "о программе");
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();

        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            WpfLibrary1.Class1.rnd();
            if (int.TryParse(tb1.Text, out int k));

        }
    }
}