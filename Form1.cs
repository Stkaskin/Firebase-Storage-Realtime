using CloudFireEng.Business;
using CloudFireEng.Business.Firebase;
using CloudFireEng.Business.Operation;
using CloudFireEng.My_Data;
using System;
using System.Windows.Forms;

namespace Fire_Storage_Realtime_Firebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fire_Base bases = new Fire_Base();
            Class1 cc = new Class1();

            cc.call_number = textBox1.Text;
            Firebase_Save save = new Firebase_Save();
            cc.ID = "key";

            //save.Remove(cc);
            save.Add(cc);
            //save.Update(cc);
            //  save.Update(cc,"değiştirilecek id");
            //cc classı adı altındaki tüm verileri getirir
            //save.Selection(cc);

            // var veriler = save.Selection(cc, "", "");
            Fire_Real_Time save_real = new Fire_Real_Time();
           // save_real.Add_RealTime("knm",veri);
          //  save_real.Remove_RealTime(id,nesne);
           // save_real.Update_RealTime(key,nesne);
          //  save_real.Search_RealTimeAsync(searchid,yer);

            Fire_Store save_store = new Fire_Store();
         //   save_store.Firestorage_Add("send_dosyası_konum","adı ne");
           // save_store.Firestorage_Change_FileName("root","yeni dosya adı");
           // save_store.Firestorage_Delete("root");
          //  save_store.Firestorage_Get("root");
          //  save_store.Firestorage_Update("root","yeni dosya rootu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("EĞER İLK GİRİŞ İSE BUSİNESS TEN FİREBASE_SETTİGNS DE KULLANMAK İSTEDİĞİNİZ \n " +
                "VERİTABANININ BİLGİLERİNİ DEĞİŞTİRİN");
         
            
        }
    }
}
