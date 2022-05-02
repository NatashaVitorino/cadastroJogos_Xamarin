using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace CadastroJogos
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText lblLogin, lblEmail, lblSenha1, lblSenha1Confirm, lblDataNasc;
        RadioButton rdbMasc, rdbFem, rdbOutro;
        Button btnCadastro;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            lblLogin = FindViewById<EditText>(Resource.Id.lblLogin);
            lblEmail = FindViewById<EditText>(Resource.Id.lblEmail);           
            lblDataNasc = FindViewById<EditText>(Resource.Id.lblDataNasc);           

            rdbMasc = FindViewById<RadioButton>(Resource.Id.rdbMasc);
            rdbFem = FindViewById<RadioButton>(Resource.Id.rdbFem);
            rdbOutro = FindViewById<RadioButton>(Resource.Id.rdbOutro);

            btnCadastro = FindViewById<Button>(Resource.Id.btnCadastro);

            btnCadastro.Click += BtnCadastro_Click;
        }

        private void BtnCadastro_Click(object sender, System.EventArgs e)
        {
            Intent page2 = new Intent(this, typeof(page2));

            page2.PutExtra("", lblLogin.Text);
            page2.PutExtra("", lblEmail.Text);
            page2.PutExtra("", lblDataNasc.Text);

            if (rdbMasc.Checked = true)
            {
                page2.PutExtra("", lblGenero.Text);
            }
            else if (rdbFem.Checked = true)
            {
                page2.PutExtra("", lblGenero.Text);
            }
            else
            {
                page2.PutExtra("", lblGenero.Text);
            }
            StartActivity(page2);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}