using CloudFireEng.Business.Interface;
using Google.Cloud.Firestore;

namespace CloudFireEng.My_Data
{

          [FirestoreData]
    public class Class1 : IFirebase
    {
        string IFirebase.table_name => "TABLE_NAME";

        [FirestoreDocumentId]
        public string ID { get; set; }
        [FirestoreProperty]
        public string call_number { get; set; }
        [FirestoreProperty]
        public string ff { get; set; }

    }
}
