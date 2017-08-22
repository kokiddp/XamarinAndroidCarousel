using System;
using Android.Content;
using Android.Views;
using Android.Widget;
using Android.Support.V4.View;

namespace XamarinAndroidCarousel
{
    public class ImageAdapter : PagerAdapter
    {
        private Context context;
        private int[] imageList;

        public ImageAdapter(Context context) {
            this.context = context;
        }

        public ImageAdapter(Context context, int[] imageList)
        {
            this.context = context;
            this.imageList = imageList;
        }

        public override int Count
        {
            get
            {
                return imageList.Length;
            }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object objectValue)
        {
            return view == (ImageView)objectValue;
        }

        [Obsolete]
        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            ImageView imageView = new ImageView(context);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetImageResource(imageList[position]);
            ((ViewPager)container).AddView(imageView, 0);
            return imageView;
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            ImageView imageView = new ImageView(context);
            imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
            imageView.SetImageResource(imageList[position]);
            container.AddView(imageView, 0);
            return imageView;
        }

        [Obsolete]
        public override void DestroyItem(View container, int position, Java.Lang.Object objectValue)
        {
            ((ViewPager)container).RemoveView((ImageView)objectValue);
        }

        public override void DestroyItem(ViewGroup container, int position, Java.Lang.Object objectValue)
        {
            container.RemoveView((ImageView)objectValue);
        }

        public override void FinishUpdate(ViewGroup container)
        {
            base.FinishUpdate(container);
        }

        public override void StartUpdate(ViewGroup container)
        {
            base.StartUpdate(container);
        }

        [Obsolete]
        public override void StartUpdate(View container)
        {
            base.StartUpdate(container);
        }
    }
}