﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;

namespace SendMailApp {
    public class Config {
        private static Config instance = null;
        public static Config GetInstance() {
            if (instance==null) {
                instance = new Config();
            }
            return instance;
        }

        public string Smtp { get; set; } //SMTPサーバ
        public string MailAddress { get; set; } //自メールアドレス（送信元）
        public string PassWord { get; set; }    //パスワード
        public int Port { get; set; }    //ポート番号
        public bool Ssl { get; set; }   //SSL設定

 

        //コンストラクタnew禁止
        private Config() {

        }
        //初期設定用
        public void DefaultSet() {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }
        //初期値取得用
        public Config getDefaultStatus() {
            Config obj = new Config(){
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true,
            };
            return obj;
        }
        //設定データ更新
        public bool UpdateStatus(string smtp,string address,string pass,int port, bool ssl) {
            this.Smtp = smtp;
            this.MailAddress = address;
            this.PassWord = pass;
            this.Port = port;
            this.Ssl = ssl;
            return true;
        }
        //シリアル化
        public void Serialize() {
            try {
                using (var writer = XmlWriter.Create("config.xml")) {
                    var serializer = new XmlSerializer(instance.GetType());
                    serializer.Serialize(writer,instance);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //逆シリアル化
        public void DeSerialize() {
            
            //try {
                using (var reader = XmlReader.Create("config.xml")) {
                    var serializer = new XmlSerializer(typeof(Config));
                    instance = serializer.Deserialize(reader) as Config;  
                }
            //} catch (IOException) {

            //} catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}
        }

    }
}
