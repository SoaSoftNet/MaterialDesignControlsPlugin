﻿using Android.Content;
using Android.Graphics.Drawables;
using AndroidGraphics = Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Views.InputMethods;

[assembly: ExportRenderer(typeof(Plugin.MaterialDesignControls.Material3.Implementations.CustomEntry), typeof(Plugin.MaterialDesignControls.Material3.Android.MaterialEntryRenderer))]

namespace Plugin.MaterialDesignControls.Material3.Android
{
    public class MaterialEntryRenderer : EntryRenderer
    {
        public static void Init() { }

        public MaterialEntryRenderer(Context context) : base(context)
        { }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = new ColorDrawable(AndroidGraphics.Color.Transparent);
                Control.SetPadding(0, 0, 0, 0);
                Control.Left = 0;

                if (Element.ReturnType == ReturnType.Default || Element.ReturnType == ReturnType.Next)
                    Control.ImeOptions = (ImeAction)ImeFlags.NoExtractUi;
            }
        }
    }
}