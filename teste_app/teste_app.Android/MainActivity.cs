using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.IO;
using Xamarin.Forms;
using SQLite;
using Android.Content;

namespace teste_app.Droid
{
    [Activity(Label = "teste_app", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public class DatabaseService_Android : Service
        {
            public SQLiteAsyncConnection GetConnection()
            {
                string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                var path = Path.Combine(docPath, "database.db");
                return new SQLiteAsyncConnection(path);
            }

            public override IBinder OnBind(Intent intent)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}