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
public partial interface ISwipeItemView : IContentView
{
    Action? InvokedAction { get; set; }

    Action<object?, EventArgs>? InvokedActionWithArgs { get; set; }
}

public partial class SwipeItemView<T> : ContentView<T>, ISwipeItemView where T : Microsoft.Maui.Controls.SwipeItemView, new()
{
    public SwipeItemView()
    {
        SwipeItemViewStyles.Default?.Invoke(this);
    }

    public SwipeItemView(Action<T?> componentRefAction) : base(componentRefAction)
    {
        SwipeItemViewStyles.Default?.Invoke(this);
    }

    Action? ISwipeItemView.InvokedAction { get; set; }

    Action<object?, EventArgs>? ISwipeItemView.InvokedActionWithArgs { get; set; }

    protected override void OnUpdate()
    {
        OnBeginUpdate();
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && SwipeItemViewStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsISwipeItemView = (ISwipeItemView)this;
        if (thisAsISwipeItemView.InvokedAction != null || thisAsISwipeItemView.InvokedActionWithArgs != null)
        {
            NativeControl.Invoked += NativeControl_Invoked;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_Invoked(object? sender, EventArgs e)
    {
        var thisAsISwipeItemView = (ISwipeItemView)this;
        thisAsISwipeItemView.InvokedAction?.Invoke();
        thisAsISwipeItemView.InvokedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.Invoked -= NativeControl_Invoked;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class SwipeItemView : SwipeItemView<Microsoft.Maui.Controls.SwipeItemView>
{
    public SwipeItemView()
    {
    }

    public SwipeItemView(Action<Microsoft.Maui.Controls.SwipeItemView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class SwipeItemViewExtensions
{
    public static T OnInvoked<T>(this T swipeItemView, Action? invokedAction)
        where T : ISwipeItemView
    {
        swipeItemView.InvokedAction = invokedAction;
        return swipeItemView;
    }

    public static T OnInvoked<T>(this T swipeItemView, Action<object?, EventArgs>? invokedActionWithArgs)
        where T : ISwipeItemView
    {
        swipeItemView.InvokedActionWithArgs = invokedActionWithArgs;
        return swipeItemView;
    }
}

public static partial class SwipeItemViewStyles
{
    public static Action<ISwipeItemView>? Default { get; set; }
    public static Dictionary<string, Action<ISwipeItemView>> Themes { get; } = [];
}