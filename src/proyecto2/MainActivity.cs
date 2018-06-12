using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace proyecto2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        Button btnAuth;
        EditText Nombre;
        EditText Contra;
        EditText Token;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAuth = FindViewById<Button>(Resource.Id.btnAuth);

            Nombre = FindViewById<EditText>(Resource.Id.Nombre);
            Contra = FindViewById<EditText>(Resource.Id.Contra);
            Token = FindViewById<EditText>(Resource.Id.Token);

            btnAuth.Click += DoAuthentication;
        }
           
        private void DoAuthentication(object sender, EventArgs e)
        {
            //calcular valor del idtext
            if (Nombre.Text.Equals("bichito") && Contra.Text.Equals("123456") && Token.Text.Equals("987654"))
            {
                Toast.MakeText(this, "usuario valido", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "usuario invalido", ToastLength.Short).Show();
            }
           
        }
    }
}

