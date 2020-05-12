using System;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Xamadroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            var coordinatorLayout = new CoordinatorLayout(this);
            coordinatorLayout.LayoutParameters = new RelativeLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);

            coordinatorLayout.AddView(CreateFab(this));

            SetContentView(coordinatorLayout);
        }

        private FloatingActionButton CreateFab(MainActivity mainActivity)
        {
            var fab = new FloatingActionButton(mainActivity);
            var layoutParameters = new FrameLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            layoutParameters.SetMargins(20, 20, 20, 20);
            fab.LayoutParameters = layoutParameters;
            fab.SetOutlineSpotShadowColor(Color.Black);
            fab.SetOutlineAmbientShadowColor(Color.Black);
            fab.Click += Fab_Click;
            return fab;

        }

        private void Fab_Click(object sender, EventArgs e)
        {

        }
    }
}

