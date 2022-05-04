using System;


namespace CloudFireEng.Business
{
  public  class Firebase_Settings
    {
      public  class Firebase
        {
           //cloud dosyasının konumu
            public string File_Location = AppDomain.CurrentDomain.BaseDirectory + @"cloudfire.json";
            public string Firebase_Name = "Firebase Name >>x-app-01 ";
            //Default
            public string EnviromentValue = "GOOGLE_APPLICATION_CREDENTIALS";
        }

   //realtime
    
      public class Realtime 
        {
            //realtime bilgileri
            public string BasePath = "https://xx-app-01-default-rtdb.europe-west1.firebasedatabase.app/";
            public string AuthSecret = "secret token";

            public string ApiKey = "Api key";
            public string Bucket = "xx-app-01-default-rtdb.europe-west1.firebasedatabase.app";
            public string Auth_Mail = "mail";
            public string Auth_Pass = "parola";
        }
        public class Storage
        {
            public string ApiKey = "api";
            public string Bucket = "xx-app-01.appspot.com";
            public string Auth_Mail = "mail";
            public string Auth_Pass = "parola";
            //kök dizini /root 
            public string File_Child = "files";
        }
        //storge
     
    
    }
}
