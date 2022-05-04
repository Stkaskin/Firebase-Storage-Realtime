using CloudFireEng.Business.Interface;
using Google.Cloud.Firestore;

namespace CloudFireEng.My_Data
{

          [FirestoreData]
    public class Class1 : IFirebase
    {
        private string table_name = "SSD";
        string IFirebase.table_names => table_name;
        string IFirebase.table_Id { get => this.Id; set { this.Id = value; } }


        [FirestoreDocumentId]
        public string Id { get; set; }
        [FirestoreProperty]
        public string call_number { get; set; }
        [FirestoreProperty]
        public string ff { get; set; }

    }
}
