
using FireSharp.Interfaces;
using System.Linq;
using System.Threading.Tasks;


namespace CloudFireEng.Business.Firebase
{
  public  class Fire_Real_Time
    {
        Firebase_Settings.Realtime settings = new Firebase_Settings.Realtime();
     
       
        public object Search_RealTimeAsync(string searchid, string table)
        {
            if (searchid.Length > 0 && table.Last() != '/') table += "/";
            var res = Connection_RealTimeDatabase().GetAsync(table + searchid).Result;

            string body = res.Body;
            if (searchid.Length > 0)
            {
             
                body = "{\"-key\":" + res + "}";
            }
            return res.Body;
        }

        public int Update_RealTime(string key, object change_data)
        {
            IFirebaseClient client = Connection_RealTimeDatabase();
            var pushkey = client.UpdateAsync("Information" + key, change_data);
        
            return 1;
        }

        async public Task<int> Add_RealTime(string col,object new_data)
        {

            IFirebaseClient client = Connection_RealTimeDatabase();
            var pushkey = await client.PushAsync("Information", new_data);

            //   MessageBox.Show(pushkey.Result.Result.name);//
            // MessageBox.Show(pushkeypushkey);
            return pushkey != null ? 1 : 0;
        }
        public void Remove_RealTime(string id,object class_name)
        {
            var con = Connection_RealTimeDatabase();
            con.DeleteAsync("");
        }
        private IFirebaseClient Connection_RealTimeDatabase()
        {
       
            IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
            {
                BasePath = settings.BasePath,
                AuthSecret = settings.AuthSecret

            };
            IFirebaseClient firebaseClient = new FireSharp.FirebaseClient(config);

            if (firebaseClient != null)
            {
                //Error
            }

            return firebaseClient;


        }

    }
}
