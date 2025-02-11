﻿using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Plugin.MaterialDesignControls.Animations;
using Plugin.MaterialDesignControls.Implementations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Plugin.MaterialDesignControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterialFloatingButton : CustomFrame, ITouchAndPressEffectConsumer
    {

        #region Attributes

        private bool initilized = false;

        public event EventHandler Clicked;

        #endregion Attributes

        #region Properties

        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(nameof(Icon), typeof(string), typeof(MaterialFloatingButton), defaultValue: null);

        public string Icon
        {
            get { return (string)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly BindableProperty DisabledIconProperty =
            BindableProperty.Create(nameof(DisabledIcon), typeof(string), typeof(MaterialFloatingButton), defaultValue: null);

        public string DisabledIcon
        {
            get { return (string)GetValue(DisabledIconProperty); }
            set { SetValue(DisabledIconProperty, value); }
        }

        public static readonly BindableProperty CustomIconProperty =
            BindableProperty.Create(nameof(CustomIcon), typeof(View), typeof(MaterialFloatingButton), defaultValue: null);

        public View CustomIcon
        {
            get { return (View)GetValue(CustomIconProperty); }
            set { SetValue(CustomIconProperty, value); }
        }

        public static readonly BindableProperty CustomDisabledIconProperty =
            BindableProperty.Create(nameof(CustomDisabledIcon), typeof(View), typeof(MaterialFloatingButton), defaultValue: null);

        public View CustomDisabledIcon
        {
            get { return (View)GetValue(CustomDisabledIconProperty); }
            set { SetValue(CustomDisabledIconProperty, value); }
        }

        public static readonly BindableProperty IconHeightRequestProperty =
            BindableProperty.Create(nameof(IconHeightRequest), typeof(double), typeof(MaterialFloatingButton), defaultValue: 24.0);

        public double IconHeightRequest
        {
            get { return (double)GetValue(IconHeightRequestProperty); }
            set { SetValue(IconHeightRequestProperty, value); }
        }

        public static readonly BindableProperty IconWidthRequestProperty =
            BindableProperty.Create(nameof(IconWidthRequest), typeof(double), typeof(MaterialFloatingButton), defaultValue: 24.0);

        public double IconWidthRequest
        {
            get { return (double)GetValue(IconWidthRequestProperty ); }
            set { SetValue(IconWidthRequestProperty , value); }
        }

        public static new readonly BindableProperty HasShadowProperty =
            BindableProperty.Create(nameof(HasShadow), typeof(bool), typeof(MaterialFloatingButton), defaultValue: true);

        public new bool HasShadow
        {
            get { return (bool)GetValue(HasShadowProperty); }
            set { SetValue(HasShadowProperty, value); }
        }

        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(MaterialFloatingButton), defaultValue: null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty =
            BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(MaterialFloatingButton), defaultValue: null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(MaterialFloatingButton), defaultValue: string.Empty);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.Create(nameof(FontSize), typeof(double), typeof(MaterialFloatingButton), defaultValue: Font.Default.FontSize);

        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }

        public static readonly BindableProperty FontFamilyProperty =
            BindableProperty.Create(nameof(FontFamily), typeof(string), typeof(MaterialFloatingButton), defaultValue: null);

        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(MaterialFloatingButton), defaultValue: Color.Gray);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly BindableProperty FontAttributesProperty =
            BindableProperty.Create(nameof(FontAttributes), typeof(FontAttributes), typeof(MaterialFloatingButton), defaultValue: FontAttributes.None);

        public FontAttributes FontAttributes
        {
            get { return (FontAttributes )GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }

        public static readonly BindableProperty DisabledTextColorProperty =
            BindableProperty.Create(nameof(DisabledTextColor), typeof(Color), typeof(MaterialFloatingButton), defaultValue: Color.White);

        public Color DisabledTextColor
        {
            get { return (Color)GetValue(DisabledTextColorProperty ); }
            set { SetValue(DisabledTextColorProperty, value); }
        }

        public static readonly BindableProperty ToUpperProperty =
            BindableProperty.Create(nameof(ToUpper), typeof(bool), typeof(MaterialFloatingButton), defaultValue: false);

        public bool ToUpper
        {
            get { return (bool)GetValue(ToUpperProperty); }
            set { SetValue(ToUpperProperty, value); }
        }

        public static new readonly BindableProperty HeightRequestProperty =
            BindableProperty.Create(nameof(HeightRequest), typeof(double), typeof(MaterialFloatingButton), defaultValue: 56.0);

        public new double HeightRequest
        {
            get { return (double)GetValue(HeightRequestProperty); }
            set { SetValue(HeightRequestProperty, value); }
        }

        public static new readonly BindableProperty WidthRequestProperty =
            BindableProperty.Create(nameof(WidthRequest), typeof(double), typeof(MaterialFloatingButton), defaultValue: 56.0);

        public new double WidthRequest
        {
            get { return (double)GetValue(WidthRequestProperty); }
            set { SetValue(WidthRequestProperty, value); }
        }

        public static new readonly BindableProperty PaddingProperty =
            BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(MaterialFloatingButton), defaultValue: new Thickness(0));

        public new Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
	    }

        public static readonly BindableProperty ButtonSizeProperty =
            BindableProperty.Create(nameof(ButtonSize), typeof(FloatingButtonSize), typeof(MaterialFloatingButton), defaultValue: FloatingButtonSize.Regular);

        public FloatingButtonSize ButtonSize
        {
            get { return (FloatingButtonSize)GetValue(ButtonSizeProperty ); }
            set { SetValue(ButtonSizeProperty , value); }
        }

        public static new readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadius), typeof(float), typeof(MaterialFloatingButton), defaultValue: 28.0F);

        public new float CornerRadius
        {
            get { return (float)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly BindableProperty IconSideProperty =
            BindableProperty.Create(nameof(IconSide), typeof(IconSide), typeof(MaterialFloatingButton), defaultValue: IconSide.Left);

        public IconSide IconSide
        {
            get { return (IconSide)GetValue(IconSideProperty); }
            set { SetValue(IconSideProperty, value); }
        }

        public static readonly BindableProperty AnimationProperty =
            BindableProperty.Create(nameof(Animation), typeof(AnimationTypes), typeof(MaterialFloatingButton), defaultValue: AnimationTypes.None);

        public AnimationTypes Animation
        {
            get { return (AnimationTypes)GetValue(AnimationProperty); }
            set { SetValue(AnimationProperty, value); }
        }

        public static readonly BindableProperty AnimationParameterProperty =
            BindableProperty.Create(nameof(AnimationParameter), typeof(double?), typeof(MaterialFloatingButton), defaultValue: null);

        public double? AnimationParameter
        {
            get { return (double?)GetValue(AnimationParameterProperty); }
            set { SetValue(AnimationParameterProperty, value); }
        }

        public static readonly BindableProperty CustomAnimationProperty =
            BindableProperty.Create(nameof(CustomAnimation), typeof(ICustomAnimation), typeof(MaterialFloatingButton), defaultValue: null);

        public ICustomAnimation CustomAnimation
        {
            get { return (ICustomAnimation)GetValue(CustomAnimationProperty); }
            set { SetValue(CustomAnimationProperty, value); }
        }

        public static new readonly BindableProperty BackgroundColorProperty =
            BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(MaterialFloatingButton), defaultValue: Color.FromHex("#2e85cc"));


        public new Color BackgroundColor
        {
            get { return (Color)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        public static readonly BindableProperty DisabledBackgroundColorProperty =
            BindableProperty.Create(nameof(DisabledBackgroundColor), typeof(Color), typeof(MaterialFloatingButton), defaultValue: Color.LightGray);

        public Color DisabledBackgroundColor
        {
            get { return (Color)GetValue(DisabledBackgroundColorProperty); }
            set { SetValue(DisabledBackgroundColorProperty, value); }
        }

        public static readonly new BindableProperty IsEnabledProperty =
            BindableProperty.Create(nameof(IsEnabled), typeof(bool), typeof(MaterialFloatingButton), defaultValue: true, BindingMode.TwoWay);

        public new bool IsEnabled
        {
            get { return (bool)GetValue(IsEnabledProperty); }
            set { SetValue(IsEnabledProperty, value); }
        }

        #endregion Properties

        #region Constructors

        public MaterialFloatingButton()
        {

            if (!this.initilized)
            {
                initilized = true;
                InitializeComponent();
                Initialize();
            }
        }

        #endregion Constructors

        #region Methods

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (!this.initilized)
            {
                initilized = true;
                InitializeComponent();
                Initialize();
            }

            switch (propertyName)
            {
                case nameof(Opacity):
                case nameof(Scale):
                    base.OnPropertyChanged(propertyName);
                    break;
                case nameof(Text):
                case nameof(ToUpper):
                    this.lblText.Text = this.ToUpper ? this.Text?.ToUpper() : this.Text;
                    break;
                case nameof(HasShadow):
                    base.HasShadow = HasShadow;
                    break;
                case nameof(Padding):
                    container.Padding = Padding;
                    break;
                case nameof(HeightRequest):
                    base.HeightRequest = HeightRequest;
                    break;
                case nameof(WidthRequest):
                    base.WidthRequest = WidthRequest;
                    break;
                case nameof(FontSize):
                    lblText.FontSize = FontSize;
                    break;
                case nameof(FontFamily):
                    lblText.FontFamily = FontFamily;
                    break;
                case nameof(FontAttributes):
                    lblText.FontAttributes = FontAttributes;
                    break;
                case nameof(TextColor):
                case nameof(DisabledTextColor):
                    lblText.TextColor = IsEnabled ? TextColor : DisabledTextColor;
                    break;
                case nameof(ButtonSize):
                    SetButtonSize();
                    break;
                case nameof(Icon):
                case nameof(DisabledIcon):
                case nameof(CustomIcon):
                case nameof(CustomDisabledIcon):
                case nameof(IconSide):
                    SetIconSide();
                    SetIcon();
                    break;
                case nameof(CornerRadius):
                    base.CornerRadius = CornerRadius;
                    break;
                case nameof(IconHeightRequest):
                    imgLeft.HeightRequest = IconHeightRequest;
                    imgRight.HeightRequest = IconHeightRequest;
                    break;
                case nameof(IconWidthRequest):
                    imgLeft.WidthRequest = IconWidthRequest;
                    imgRight.WidthRequest = IconWidthRequest;
                    break;
                case nameof(BackgroundColor):
                case nameof(DisabledBackgroundColor):
                case nameof(IsEnabled):
                    container.BackgroundColor= IsEnabled ? BackgroundColor : DisabledBackgroundColor;
                    lblText.TextColor = IsEnabled ? TextColor : DisabledTextColor;
                    SetIcon();
                    break;
            }
        }

        private void SetIconSide()
        {
            if (IconSide == IconSide.Left)
                imgLeft.IsVisible = true;
            else
            {
                imgLeft.IsVisible = false;
                imgRight.IsVisible = true;
                lblText.Margin = new Thickness(0, 0, 6, 0);
                Padding = new Thickness(16, 0, 16, 0);
            }
        }

        private void SetIcon()
        {
            if (IsEnabled)
            {
                if (CustomIcon != null)
                {
                    if (IconSide == IconSide.Left)
                        imgLeft.SetCustomImage(CustomIcon);
                    else
                        imgRight.SetCustomImage(CustomIcon);
                }
                else
                {
                    if (IconSide == IconSide.Left)
                        imgLeft.SetImage(Icon);
                    else
                        imgRight.SetImage(Icon);
                }
            }
            else
            {
                if (CustomDisabledIcon != null)
                {
                    if (IconSide == IconSide.Left)
                        imgLeft.SetCustomImage(CustomDisabledIcon);
                    else
                        imgRight.SetCustomImage(CustomDisabledIcon);
                }
                else if (CustomIcon != null)
                {
                    if (IconSide == IconSide.Left)
                        imgLeft.SetCustomImage(CustomIcon);
                    else
                        imgRight.SetCustomImage(CustomIcon);
                }
                else if (DisabledIcon != null)
                {
                    if (IconSide == IconSide.Left)
                        imgLeft.SetImage(DisabledIcon);
                    else
                        imgRight.SetImage(DisabledIcon);
                }
                else
                {
                    if (IconSide == IconSide.Left)
                        imgLeft.SetImage(Icon);
                    else
                        imgRight.SetImage(Icon);
                }
            }
        }

        private void SetButtonSize()
        {
            imgLeft.HeightRequest = IconHeightRequest;
            imgLeft.WidthRequest = IconWidthRequest;
            imgRight.HeightRequest = IconHeightRequest;
            imgRight.WidthRequest = IconWidthRequest;

            if (ButtonSize == FloatingButtonSize.Mini)
            {
                HeightRequest = 40;
                WidthRequest = 40;
                CornerRadius = 20;
	        }
            else if (ButtonSize == FloatingButtonSize.Extended)
            {
                if (!string.IsNullOrEmpty(Text))
                    lblText.IsVisible = true;
                if (string.IsNullOrEmpty(Icon) && CustomIcon == null)
                { 
                    imgLeft.IsVisible = false;
                    imgRight.IsVisible = false;
                }

                HeightRequest = 48;
                WidthRequest = -1;
                CornerRadius = 24;
                lblText.HorizontalTextAlignment = TextAlignment.Center;
                lblText.Margin = new Thickness(6, 0, 0, 0);
                Padding = new Thickness(12, 0, 20, 0);
            }
        }

        private void Initialize()
        {
            imgLeft.Padding = 0;
            imgRight.Padding = 0;
            base.HasShadow = HasShadow;
            container.Padding = Padding;
            base.Padding = 0;
            base.HeightRequest = HeightRequest;
            base.WidthRequest = WidthRequest;
            base.CornerRadius = CornerRadius;
            container.BackgroundColor = BackgroundColor;
            imgLeft.HeightRequest = IconHeightRequest;
            imgLeft.WidthRequest = IconWidthRequest;
            imgRight.HeightRequest = IconHeightRequest;
            imgRight.WidthRequest = IconWidthRequest;
            imgLeft.IsVisible = true;
            Effects.Add(new TouchAndPressEffect());
	    }

        public void ConsumeEvent(EventType gestureType)
        {
            TouchAndPressAnimation.Animate(this, gestureType);
        }

        public void ExecuteAction()
        {
            if (IsEnabled && Command != null && Command.CanExecute(CommandParameter))
                Command.Execute(CommandParameter);

            if (IsEnabled && Clicked != null)
                Clicked.Invoke(this, null);
        }

        #endregion Methods
    }
}