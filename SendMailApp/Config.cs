using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
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
            var obj = new Config() {
                Smtp = this.Smtp,
                MailAddress = this.MailAddress,
                PassWord = this.PassWord,
                Port = this.Port,
                Ssl = this.Ssl,
            };
            using (var writer = XmlWriter.Create("config.xml")) {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(writer,obj);
            }
        }
        //逆シリアル化
        public void DeSerialize() {
            using (var reader = XmlReader.Create("config.xml")) {
                var serializer = new XmlSerializer(typeof(Config));
                var obj = serializer.Deserialize(reader) as Config;

                this.Smtp = obj.Smtp;
                this.MailAddress = obj.MailAddress;
                this.PassWord = obj.PassWord;
                this.Port = obj.Port;
                this.Ssl = obj.Ssl;


            }
        }

    }
}
