using System;
using System.Collections.Generic;
using System.Data;
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

namespace SendMailApp {
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window {
        public ConfigWindow() {
            InitializeComponent();
            

        }
        //初期値ボタン
        private void btDefault_Click(object sender, RoutedEventArgs e) {
            //初期値をもらってくる
            Config cf = (Config.GetInstance()).getDefaultStatus();
            //Config defaultData =  cf.getDefaultStatus();
            tbSmtp.Text = cf.Smtp;
            tbUseName.Text = cf.MailAddress;
            tbPort.Text = cf.Port.ToString();
            tbPass.Password = cf.PassWord;
            tbSender.Text = cf.MailAddress;
            cbsl.IsChecked = cf.Ssl;
        }
        //適用ボタン
        private void btApply_Click(object sender, RoutedEventArgs e) {
            (Config.GetInstance()).UpdateStatus(
                tbSmtp.Text,
                tbUseName.Text,
                tbPass.Password,
                int.Parse(tbPort.Text),
                cbsl.IsChecked ?? false
             );
        }
        //OKボタン
        private void btOk_Click(object sender, RoutedEventArgs e) {
            btApply_Click(sender,e);
            btCancel_Click(sender,e);
        }
        //キャンセルボタン
        private void btCancel_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
        //ロード１回呼び出し
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Config cf = Config.GetInstance();
            tbSmtp.Text = cf.Smtp;
            tbUseName.Text = cf.MailAddress;
            tbPort.Text = cf.Port.ToString();
            tbPass.Password = cf.PassWord;
            tbSender.Text = cf.MailAddress;
            cbsl.IsChecked = cf.Ssl;
        }
    }
}
