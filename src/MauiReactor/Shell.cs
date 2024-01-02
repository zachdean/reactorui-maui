// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor;
public partial interface IShell : IPage
{
    object? FlyoutBehavior { get; set; }

    object? FlyoutBackdrop { get; set; }

    object? FlyoutWidth { get; set; }

    object? FlyoutHeight { get; set; }

    object? FlyoutBackgroundImage { get; set; }

    object? FlyoutBackgroundImageAspect { get; set; }

    object? FlyoutBackgroundColor { get; set; }

    object? FlyoutBackground { get; set; }

    object? FlyoutHeaderBehavior { get; set; }

    object? FlyoutIsPresented { get; set; }

    object? FlyoutIcon { get; set; }

    object? FlyoutVerticalScrollMode { get; set; }

    Action? NavigatedAction { get; set; }

    Action<object?, ShellNavigatedEventArgs>? NavigatedActionWithArgs { get; set; }

    Action? NavigatingAction { get; set; }

    Action<object?, ShellNavigatingEventArgs>? NavigatingActionWithArgs { get; set; }
}

public partial class Shell<T> : Page<T>, IShell where T : Microsoft.Maui.Controls.Shell, new()
{
    public Shell()
    {
    }

    public Shell(Action<T?> componentRefAction) : base(componentRefAction)
    {
    }

    object? IShell.FlyoutBehavior { get; set; }

    object? IShell.FlyoutBackdrop { get; set; }

    object? IShell.FlyoutWidth { get; set; }

    object? IShell.FlyoutHeight { get; set; }

    object? IShell.FlyoutBackgroundImage { get; set; }

    object? IShell.FlyoutBackgroundImageAspect { get; set; }

    object? IShell.FlyoutBackgroundColor { get; set; }

    object? IShell.FlyoutBackground { get; set; }

    object? IShell.FlyoutHeaderBehavior { get; set; }

    object? IShell.FlyoutIsPresented { get; set; }

    object? IShell.FlyoutIcon { get; set; }

    object? IShell.FlyoutVerticalScrollMode { get; set; }

    Action? IShell.NavigatedAction { get; set; }

    Action<object?, ShellNavigatedEventArgs>? IShell.NavigatedActionWithArgs { get; set; }

    Action? IShell.NavigatingAction { get; set; }

    Action<object?, ShellNavigatingEventArgs>? IShell.NavigatingActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIShell = (IShell)this;
        thisAsIShell.FlyoutBehavior = null;
        thisAsIShell.FlyoutBackdrop = null;
        thisAsIShell.FlyoutWidth = null;
        thisAsIShell.FlyoutHeight = null;
        thisAsIShell.FlyoutBackgroundImage = null;
        thisAsIShell.FlyoutBackgroundImageAspect = null;
        thisAsIShell.FlyoutBackgroundColor = null;
        thisAsIShell.FlyoutBackground = null;
        thisAsIShell.FlyoutHeaderBehavior = null;
        thisAsIShell.FlyoutIsPresented = null;
        thisAsIShell.FlyoutIcon = null;
        thisAsIShell.FlyoutVerticalScrollMode = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIShell = (IShell)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutBehaviorProperty, thisAsIShell.FlyoutBehavior);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutBackdropProperty, thisAsIShell.FlyoutBackdrop);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutWidthProperty, thisAsIShell.FlyoutWidth);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutHeightProperty, thisAsIShell.FlyoutHeight);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutBackgroundImageProperty, thisAsIShell.FlyoutBackgroundImage);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutBackgroundImageAspectProperty, thisAsIShell.FlyoutBackgroundImageAspect);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutBackgroundColorProperty, thisAsIShell.FlyoutBackgroundColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutBackgroundProperty, thisAsIShell.FlyoutBackground);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutHeaderBehaviorProperty, thisAsIShell.FlyoutHeaderBehavior);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutIsPresentedProperty, thisAsIShell.FlyoutIsPresented);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutIconProperty, thisAsIShell.FlyoutIcon);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shell.FlyoutVerticalScrollModeProperty, thisAsIShell.FlyoutVerticalScrollMode);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIShell = (IShell)this;
        AnimateProperty(Microsoft.Maui.Controls.Shell.FlyoutWidthProperty, thisAsIShell.FlyoutWidth);
        AnimateProperty(Microsoft.Maui.Controls.Shell.FlyoutHeightProperty, thisAsIShell.FlyoutHeight);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsIShell = (IShell)this;
        if (thisAsIShell.NavigatedAction != null || thisAsIShell.NavigatedActionWithArgs != null)
        {
            NativeControl.Navigated += NativeControl_Navigated;
        }

        if (thisAsIShell.NavigatingAction != null || thisAsIShell.NavigatingActionWithArgs != null)
        {
            NativeControl.Navigating += NativeControl_Navigating;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_Navigated(object? sender, ShellNavigatedEventArgs e)
    {
        var thisAsIShell = (IShell)this;
        thisAsIShell.NavigatedAction?.Invoke();
        thisAsIShell.NavigatedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_Navigating(object? sender, ShellNavigatingEventArgs e)
    {
        var thisAsIShell = (IShell)this;
        thisAsIShell.NavigatingAction?.Invoke();
        thisAsIShell.NavigatingActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.Navigated -= NativeControl_Navigated;
            NativeControl.Navigating -= NativeControl_Navigating;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class Shell : Shell<Microsoft.Maui.Controls.Shell>
{
    public Shell()
    {
    }

    public Shell(Action<Microsoft.Maui.Controls.Shell?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class ShellExtensions
{
    public static T FlyoutBehavior<T>(this T shell, Microsoft.Maui.FlyoutBehavior flyoutBehavior)
        where T : IShell
    {
        shell.FlyoutBehavior = flyoutBehavior;
        return shell;
    }

    public static T FlyoutBehavior<T>(this T shell, Func<Microsoft.Maui.FlyoutBehavior> flyoutBehaviorFunc)
        where T : IShell
    {
        shell.FlyoutBehavior = new PropertyValue<Microsoft.Maui.FlyoutBehavior>(flyoutBehaviorFunc);
        return shell;
    }

    public static T FlyoutBackdrop<T>(this T shell, Microsoft.Maui.Controls.Brush flyoutBackdrop)
        where T : IShell
    {
        shell.FlyoutBackdrop = flyoutBackdrop;
        return shell;
    }

    public static T FlyoutBackdrop<T>(this T shell, Func<Microsoft.Maui.Controls.Brush> flyoutBackdropFunc)
        where T : IShell
    {
        shell.FlyoutBackdrop = new PropertyValue<Microsoft.Maui.Controls.Brush>(flyoutBackdropFunc);
        return shell;
    }

    public static T FlyoutWidth<T>(this T shell, double flyoutWidth, RxDoubleAnimation? customAnimation = null)
        where T : IShell
    {
        shell.FlyoutWidth = flyoutWidth;
        shell.AppendAnimatable(Microsoft.Maui.Controls.Shell.FlyoutWidthProperty, customAnimation ?? new RxDoubleAnimation(flyoutWidth), v => shell.FlyoutWidth = new PropertyValue<double>(v.CurrentValue()));
        return shell;
    }

    public static T FlyoutWidth<T>(this T shell, Func<double> flyoutWidthFunc)
        where T : IShell
    {
        shell.FlyoutWidth = new PropertyValue<double>(flyoutWidthFunc);
        return shell;
    }

    public static T FlyoutHeight<T>(this T shell, double flyoutHeight, RxDoubleAnimation? customAnimation = null)
        where T : IShell
    {
        shell.FlyoutHeight = flyoutHeight;
        shell.AppendAnimatable(Microsoft.Maui.Controls.Shell.FlyoutHeightProperty, customAnimation ?? new RxDoubleAnimation(flyoutHeight), v => shell.FlyoutHeight = new PropertyValue<double>(v.CurrentValue()));
        return shell;
    }

    public static T FlyoutHeight<T>(this T shell, Func<double> flyoutHeightFunc)
        where T : IShell
    {
        shell.FlyoutHeight = new PropertyValue<double>(flyoutHeightFunc);
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, Microsoft.Maui.Controls.ImageSource flyoutBackgroundImage)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = flyoutBackgroundImage;
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, Func<Microsoft.Maui.Controls.ImageSource> flyoutBackgroundImageFunc)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(flyoutBackgroundImageFunc);
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, string file)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = Microsoft.Maui.Controls.ImageSource.FromFile(file);
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, Func<string> action)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(() => Microsoft.Maui.Controls.ImageSource.FromFile(action()));
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, string resourceName, Assembly sourceAssembly)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly);
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, Uri imageUri)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = Microsoft.Maui.Controls.ImageSource.FromUri(imageUri);
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = new UriImageSource
        {
            Uri = imageUri,
            CachingEnabled = cachingEnabled,
            CacheValidity = cacheValidity
        };
        return shell;
    }

    public static T FlyoutBackgroundImage<T>(this T shell, Func<Stream> imageStream)
        where T : IShell
    {
        shell.FlyoutBackgroundImage = Microsoft.Maui.Controls.ImageSource.FromStream(imageStream);
        return shell;
    }

    public static T FlyoutBackgroundImageAspect<T>(this T shell, Microsoft.Maui.Aspect flyoutBackgroundImageAspect)
        where T : IShell
    {
        shell.FlyoutBackgroundImageAspect = flyoutBackgroundImageAspect;
        return shell;
    }

    public static T FlyoutBackgroundImageAspect<T>(this T shell, Func<Microsoft.Maui.Aspect> flyoutBackgroundImageAspectFunc)
        where T : IShell
    {
        shell.FlyoutBackgroundImageAspect = new PropertyValue<Microsoft.Maui.Aspect>(flyoutBackgroundImageAspectFunc);
        return shell;
    }

    public static T FlyoutBackgroundColor<T>(this T shell, Microsoft.Maui.Graphics.Color flyoutBackgroundColor)
        where T : IShell
    {
        shell.FlyoutBackgroundColor = flyoutBackgroundColor;
        return shell;
    }

    public static T FlyoutBackgroundColor<T>(this T shell, Func<Microsoft.Maui.Graphics.Color> flyoutBackgroundColorFunc)
        where T : IShell
    {
        shell.FlyoutBackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(flyoutBackgroundColorFunc);
        return shell;
    }

    public static T FlyoutBackground<T>(this T shell, Microsoft.Maui.Controls.Brush flyoutBackground)
        where T : IShell
    {
        shell.FlyoutBackground = flyoutBackground;
        return shell;
    }

    public static T FlyoutBackground<T>(this T shell, Func<Microsoft.Maui.Controls.Brush> flyoutBackgroundFunc)
        where T : IShell
    {
        shell.FlyoutBackground = new PropertyValue<Microsoft.Maui.Controls.Brush>(flyoutBackgroundFunc);
        return shell;
    }

    public static T FlyoutHeaderBehavior<T>(this T shell, Microsoft.Maui.Controls.FlyoutHeaderBehavior flyoutHeaderBehavior)
        where T : IShell
    {
        shell.FlyoutHeaderBehavior = flyoutHeaderBehavior;
        return shell;
    }

    public static T FlyoutHeaderBehavior<T>(this T shell, Func<Microsoft.Maui.Controls.FlyoutHeaderBehavior> flyoutHeaderBehaviorFunc)
        where T : IShell
    {
        shell.FlyoutHeaderBehavior = new PropertyValue<Microsoft.Maui.Controls.FlyoutHeaderBehavior>(flyoutHeaderBehaviorFunc);
        return shell;
    }

    public static T FlyoutIsPresented<T>(this T shell, bool flyoutIsPresented)
        where T : IShell
    {
        shell.FlyoutIsPresented = flyoutIsPresented;
        return shell;
    }

    public static T FlyoutIsPresented<T>(this T shell, Func<bool> flyoutIsPresentedFunc)
        where T : IShell
    {
        shell.FlyoutIsPresented = new PropertyValue<bool>(flyoutIsPresentedFunc);
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, Microsoft.Maui.Controls.ImageSource flyoutIcon)
        where T : IShell
    {
        shell.FlyoutIcon = flyoutIcon;
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, Func<Microsoft.Maui.Controls.ImageSource> flyoutIconFunc)
        where T : IShell
    {
        shell.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(flyoutIconFunc);
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, string file)
        where T : IShell
    {
        shell.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromFile(file);
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, Func<string> action)
        where T : IShell
    {
        shell.FlyoutIcon = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(() => Microsoft.Maui.Controls.ImageSource.FromFile(action()));
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, string resourceName, Assembly sourceAssembly)
        where T : IShell
    {
        shell.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly);
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, Uri imageUri)
        where T : IShell
    {
        shell.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromUri(imageUri);
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity)
        where T : IShell
    {
        shell.FlyoutIcon = new UriImageSource
        {
            Uri = imageUri,
            CachingEnabled = cachingEnabled,
            CacheValidity = cacheValidity
        };
        return shell;
    }

    public static T FlyoutIcon<T>(this T shell, Func<Stream> imageStream)
        where T : IShell
    {
        shell.FlyoutIcon = Microsoft.Maui.Controls.ImageSource.FromStream(imageStream);
        return shell;
    }

    public static T FlyoutVerticalScrollMode<T>(this T shell, Microsoft.Maui.Controls.ScrollMode flyoutVerticalScrollMode)
        where T : IShell
    {
        shell.FlyoutVerticalScrollMode = flyoutVerticalScrollMode;
        return shell;
    }

    public static T FlyoutVerticalScrollMode<T>(this T shell, Func<Microsoft.Maui.Controls.ScrollMode> flyoutVerticalScrollModeFunc)
        where T : IShell
    {
        shell.FlyoutVerticalScrollMode = new PropertyValue<Microsoft.Maui.Controls.ScrollMode>(flyoutVerticalScrollModeFunc);
        return shell;
    }

    public static T OnNavigated<T>(this T shell, Action? navigatedAction)
        where T : IShell
    {
        shell.NavigatedAction = navigatedAction;
        return shell;
    }

    public static T OnNavigated<T>(this T shell, Action<object?, ShellNavigatedEventArgs>? navigatedActionWithArgs)
        where T : IShell
    {
        shell.NavigatedActionWithArgs = navigatedActionWithArgs;
        return shell;
    }

    public static T OnNavigating<T>(this T shell, Action? navigatingAction)
        where T : IShell
    {
        shell.NavigatingAction = navigatingAction;
        return shell;
    }

    public static T OnNavigating<T>(this T shell, Action<object?, ShellNavigatingEventArgs>? navigatingActionWithArgs)
        where T : IShell
    {
        shell.NavigatingActionWithArgs = navigatingActionWithArgs;
        return shell;
    }
}