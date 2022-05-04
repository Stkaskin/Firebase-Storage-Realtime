using CloudFireEng.Business.Interface;
using Fire_Storage_Realtime_Firebase.Business.Work;

namespace CloudFireEng.Business.Operation
{
    public class FireRealtime_Save
    {
        Realtime_Work work = new Realtime_Work();
        IFirebase firebase;

        public string Add(object class_object)
        {
            
            IFirebase firebase = (IFirebase)class_object;
            return work.FireRealTime_Add(firebase.table_name, firebase);
        }

        public int Remove(object class_object)
        {
            firebase = (IFirebase)class_object;


            return work.FireRealTime_Delete(firebase.table_name, firebase.ID);
        }
        public int Update(object class_object)
        {
            firebase = (IFirebase)class_object;
            return 1;
            //   return work.FireRealTime_Update(firebase.table_name, firebase.ID, firebase);
        }
        public object Selection<T>(object class_object,T classb)
        {

            return new Data_Converter().FRealTime_Converter<T>(work.FireRealTime_Search("", "").ToString());
        }

        public object Selection<T>(object class_object, string search_value, string search_col)
        {
            var a = work.FireRealTime_Search(search_value, firebase.table_name);
            return new Data_Converter().FRealTime_Converter<T>(work.FireRealTime_Search(search_value, search_col).ToString());
        }

   
    }
}
