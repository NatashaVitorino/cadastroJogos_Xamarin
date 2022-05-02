using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CadastroJogos
{
    [Activity(Label = "page2")]
    public class page2 : Activity
    {
        TextView lblLogin, lblEmail, lblDataNasc;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.page2);

            lblLogin = FindViewById<TextView>(Resource.Id.lblLogin);
            lblEmail = FindViewById<TextView>(Resource.Id.lblEmail);
            lblDataNasc = FindViewById<TextView>(Resource.Id.lblDataNasc);
           

            if (Intent.GetStringExtra("") != null)
                lblLogin.Text = Intent.GetStringExtra("").ToString();
            if (Intent.GetStringExtra("") != null)
                lblEmail.Text = Intent.GetStringExtra("").ToString();
            if (Intent.GetStringExtra("") != null)
                lblDataNasc.Text = Intent.GetStringExtra("").ToString();
        }
    }
}