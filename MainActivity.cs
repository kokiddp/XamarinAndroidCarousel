using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V7.App;

namespace XamarinAndroidCarousel
{
    [Activity(Label = "XamarinAndroidCarousel", MainLauncher = true, Icon = "@drawable/icon",Theme ="@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Xamarin Android Carousel";

            int[] imageList = {
            Resource.Drawable.topolino,
            Resource.Drawable.pippo,
            Resource.Drawable.paperino,
            };

            var viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            ImageAdapter adapter = new ImageAdapter(this, imageList);
            viewPager.Adapter = adapter;
        }
    }
}