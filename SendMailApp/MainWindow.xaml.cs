﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMailApp {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        SmtpClient sc = new SmtpClient();
        public MainWindow() {
            InitializeComponent();
            sc.SendCompleted += Sc_sendCompleted;

        }

        //送信完了イベント
        private void Sc_sendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e) {
            if (e.Cancelled) {
                MessageBox.Show("送信はキャンセルされました");
            } else {
                MessageBox.Show(e.Error?.Message ?? "送信完了");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e) {

            sc.SendAsyncCancel();
        }

        //メース送信処理
        private void SendButton_Click(object sender, RoutedEventArgs e) {
            try {
                Config cf = Config.GetInstance();


                MailMessage msg = new MailMessage(cf.MailAddress, tbTo.Text);
                var ccList = tbCc.Text.Split(',').ToString().ToList();
                var bccList = tbBcc.Text.Split(',').ToString().ToList();
                if(tbCc.Text!="")
                    msg.CC.Add(tbCc.Text);
                if(tbBcc.Text!="")
                    msg.Bcc.Add(tbBcc.Text);
                //msg.Attachments.Add(tempList.Items.);

                msg.Subject = tbTitle.Text; //件名
                msg.Body = tbBody.Text; //本文

                foreach (var item in tempList.Items) {
                    msg.Attachments.Add(new Attachment(item.ToString()));
                }
                


                sc.Host = cf.Smtp; //SMTPサーバの設定
                sc.Port = cf.Port;
                sc.EnableSsl = cf.Ssl;
                sc.Credentials = new NetworkCredential(cf.MailAddress, cf.PassWord);

                //sc.Send(msg);  //送信
                sc.SendMailAsync(msg);


            }catch (ArgumentException) {
                MessageBox.Show("Toに送信先メールアドレスを入力してください");
            }catch (SmtpException) {
                MessageBox.Show("SMTPを確認してください");
            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
        //設定画面表示
        private void btConfig_Click(object sender, RoutedEventArgs e) {
            ConfigWindowShow();
            
        }

        private static void ConfigWindowShow() {
            ConfigWindow configWindow = new ConfigWindow(); //設定画面のインスタンス
            configWindow.ShowDialog();  //表示
        }

        //メインウィンドウがロードされるタイミングで呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            try {
                Config.GetInstance().DeSerialize();
            } catch (FileNotFoundException) {
                ConfigWindowShow();
            } catch (Exception ex) {
                  MessageBox.Show(ex.Message);
            }
        }
        //閉じるタイミング
        private void Window_Closed(object sender, EventArgs e) {
            Config.GetInstance().Serialize();
        }
        //添付追加
        private void addButton_Click(object sender, RoutedEventArgs e) {
            var openD = new OpenFileDialog();
            openD.Filter = "全てのファイル (*.*)|*.*";
            if (openD.ShowDialog()==true) {
                tempList.Items.Add(openD.FileName);
            }
        }
        //添付削除
        private void deleteButton_Click(object sender, RoutedEventArgs e) {
            tempList.Items.Clear();
        }
    }
}
