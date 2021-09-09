using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace LOGIN
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText Username_Obj;
        EditText Password_Obj;
        Button btn_Login;
        Button btn_SignUp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Username_Obj = FindViewById<EditText>(Resource.Id.Username);
            Password_Obj = FindViewById<EditText>(Resource.Id.Password);
            btn_Login = FindViewById<Button>(Resource.Id.btnLogin);
            btn_SignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            btn_Login.Click += Login_Function;
        }

        public void Login_Function(object sender, EventArgs e)
        {
            if (Username_Obj.Text == "1234" && Password_Obj.Text == "123")
            {
                Toast.MakeText(this, "Login successfully done!", ToastLength.Long).Show();
                StartActivity(typeof(Dashboard));
            } else
            {
                Toast.MakeText(this, "Wrong credentials found!", ToastLength.Long).Show();
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}