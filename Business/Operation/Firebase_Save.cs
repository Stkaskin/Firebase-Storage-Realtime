using CloudFireEng.Business.Interface;
using CloudFireEng.Business.Work;

namespace CloudFireEng.Business.Operation
{
    public class Firebase_Save
    {
        IFirebase firebase;
        public string Add(object class_object)
        {
            IFirebase firebase = (IFirebase)class_object;
            return new Firebase_Work().Add(firebase.table_name, firebase);
        }

        public int Remove(object class_object)
        {
             firebase = (IFirebase)class_object;
        

            return new Firebase_Work().Delete(firebase.table_name, firebase.ID);
        }
        public int Update(object class_object)
        {
             firebase = (IFirebase)class_object;
            return new Firebase_Work().Update(firebase.table_name, firebase.ID, firebase);
        }
        public int Update(object class_object,string Change_Id)
        {
            //içeriye id ekliyor 
            firebase = (IFirebase)class_object;
            string old_id = firebase.ID;
            firebase.ID = Change_Id;
            return new Firebase_Work().Update(firebase.table_name, old_id, firebase);
        }
        public object Selection<T>(T obj)
        {
            firebase=(IFirebase) obj;
            return new Data_Converter().Firebase_Converter<T>(new Firebase_Work().Selection(firebase.table_name, "", ""));

        }

        public object Selection<T>(T class_object, string search_value, string search_col)
        {
            firebase = (IFirebase)class_object;
            return new Data_Converter().Firebase_Converter<T>(new Firebase_Work().Selection(firebase.table_name, search_col, search_value));
        }

    }
}
