using System;


namespace CloudFireEng.Business
{
  public  class Firebase_Settings
    {
      public  class Firebase
        {
//cloudfile.json location
            public string File_Location = AppDomain.CurrentDomain.BaseDirectory + @"cloudfire.json";
            public string Firebase_Name = "x-xx-x";
            //Default
            public string EnviromentValue = "GOOGLE_APPLICATION_CREDENTIALS";
        }

   //realtime
    
      public class Realtime 
        {
            public string BasePath = "https://**-*west1.firebasedatabase.app/";
            public string AuthSecret = "xxxx";

            public string ApiKey = "xx";
            public string Bucket = "x-xxx-x-*west1.firebasedatabase.app";
            public string Auth_Mail = "xx@xxxxx.com";
            public string Auth_Pass = "xxxxx";
        }
        public class Storage
        {
            public string ApiKey = "x";
            public string Bucket = "*-x-x.xx.com";
            public string Auth_Mail = "xx@xx.com";
            public string Auth_Pass = "**"
            public string File_Child = "files";
        }
        //storge
     
    
    }
}
