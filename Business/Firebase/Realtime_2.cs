using CloudFireEng.Business;
using Firebase.Auth;
using Firebase.Database;
using System.Threading.Tasks;
namespace Fire_Storage_Realtime_Firebase.Business.Firebase
{
   public class Realtime_2
    {
        // alternatif bağlantı mail ve e posta ile
        private async Task<FirebaseClient> Connection_User_LoginAsync()
        {
            var settigns = new Firebase_Settings.Realtime();
            var authpo = new FirebaseAuthProvider(new FirebaseConfig(settigns.ApiKey));
            var a = await authpo.SignInWithEmailAndPasswordAsync(email:  settigns.Auth_Mail, password:  settigns.Auth_Pass);

            FirebaseOptions options = new FirebaseOptions
            {
                AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                AsAccessToken = true
            };

            //  cancellation = new System.Threading.CancellationTokenSource();
            FirebaseClient storage = new FirebaseClient(settigns.Bucket, options);

            return storage;
        }
    }
}
