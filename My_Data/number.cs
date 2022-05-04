using CloudFireEng.Business.Interface;
using Google.Cloud.Firestore;
namespace CloudFireEng.My_Data
{
    [FirestoreData]
    public class number :IFirebase
    {

        string IFirebase.table_names => "number_call5";
        string IFirebase.table_Id { get => this.Id; set { this.Id = value; } }
        [FirestoreDocumentId]
        public string Id { get; set; }
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
