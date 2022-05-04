using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;


namespace CloudFireEng.Business.Operation
{
    public class Data_Converter
    {
        public object FRealTime_Converter<T>(string a)
        {

            var data = JsonConvert.DeserializeObject<Dictionary<string, T>>(value: a.ToString()).Values.ToList();
            return data;
        }
        public object Firebase_Converter<T>(object datas)
        {
            return ((List<DocumentSnapshot>)datas).ConvertAll(x => x.ConvertTo<T>());
        }
    }
}
