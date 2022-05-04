using CloudFireEng.Business.Firebase;


namespace Fire_Storage_Realtime_Firebase.Business.Work
{
    public class Realtime_Work
    {
        public string FireRealTime_Add(string class_name, object new_data)
        {
            _=new Fire_Real_Time().Add_RealTime("colname",new_data);
            return "";
        }
        public int FireRealTime_Delete(string id, string class_name)
        {
            new Fire_Real_Time().Remove_RealTime(id,class_name);

            return 1;
        }
        public int FireRealTime_Update(object change_data, string id, string path)
        {
            new Fire_Real_Time().Update_RealTime(id, change_data);
            return 1;
        }
        public object FireRealTime_Search(string id, string path)
        {
            path = "Information";
            return new Fire_Real_Time().Search_RealTimeAsync(id, path);

        }
    }
}
