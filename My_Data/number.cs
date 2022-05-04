using CloudFireEng.Business.Interface;
using Google.Cloud.Firestore;
namespace CloudFireEng.My_Data
{
    [FirestoreData]
    public class number :IFirebase
    {
        string IFirebase.table_name => "number";
     
        [FirestoreDocumentId]
        public string ID { get; set; }
        [FirestoreProperty]
        public string call_number { get; set; }
        [FirestoreProperty]
        public string phone_name { get; set; }
        [FirestoreProperty]
        public string file_path { get; set; }
        [FirestoreProperty]
        public string file_name { get; set; }
    }
}
