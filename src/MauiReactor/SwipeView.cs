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
public partial interface ISwipeView : IContentView
{
    object? Threshold { get; set; }

    Action? SwipeStartedAction { get; set; }

    Action<object?, SwipeStartedEventArgs>? SwipeStartedActionWithArgs { get; set; }

    Action? SwipeChangingAction { get; set; }

    Action<object?, SwipeChangingEventArgs>? SwipeChangingActionWithArgs { get; set; }

    Action? SwipeEndedAction { get; set; }

    Action<object?, SwipeEndedEventArgs>? SwipeEndedActionWithArgs { get; set; }
}

public partial class SwipeView<T> : ContentView<T>, ISwipeView where T : Microsoft.Maui.Controls.SwipeView, new()
{
    public SwipeView()
    {
    }

    public SwipeView(Action<T?> componentRefAction) : base(componentRefAction)
    {
    }

    object? ISwipeView.Threshold { get; set; }

    Action? ISwipeView.SwipeStartedAction { get; set; }

    Action<object?, SwipeStartedEventArgs>? ISwipeView.SwipeStartedActionWithArgs { get; set; }

    Action? ISwipeView.SwipeChangingAction { get; set; }

    Action<object?, SwipeChangingEventArgs>? ISwipeView.SwipeChangingActionWithArgs { get; set; }

    Action? ISwipeView.SwipeEndedAction { get; set; }

    Action<object?, SwipeEndedEventArgs>? ISwipeView.SwipeEndedActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsISwipeView = (ISwipeView)this;
        thisAsISwipeView.Threshold = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsISwipeView = (ISwipeView)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SwipeView.ThresholdProperty, thisAsISwipeView.Threshold);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsISwipeView = (ISwipeView)this;
        AnimateProperty(Microsoft.Maui.Controls.SwipeView.ThresholdProperty, thisAsISwipeView.Threshold);
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
        var thisAsISwipeView = (ISwipeView)this;
        if (thisAsISwipeView.SwipeStartedAction != null || thisAsISwipeView.SwipeStartedActionWithArgs != null)
        {
            NativeControl.SwipeStarted += NativeControl_SwipeStarted;
        }

        if (thisAsISwipeView.SwipeChangingAction != null || thisAsISwipeView.SwipeChangingActionWithArgs != null)
        {
            NativeControl.SwipeChanging += NativeControl_SwipeChanging;
        }

        if (thisAsISwipeView.SwipeEndedAction != null || thisAsISwipeView.SwipeEndedActionWithArgs != null)
        {
            NativeControl.SwipeEnded += NativeControl_SwipeEnded;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_SwipeStarted(object? sender, SwipeStartedEventArgs e)
    {
        var thisAsISwipeView = (ISwipeView)this;
        thisAsISwipeView.SwipeStartedAction?.Invoke();
        thisAsISwipeView.SwipeStartedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_SwipeChanging(object? sender, SwipeChangingEventArgs e)
    {
        var thisAsISwipeView = (ISwipeView)this;
        thisAsISwipeView.SwipeChangingAction?.Invoke();
        thisAsISwipeView.SwipeChangingActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_SwipeEnded(object? sender, SwipeEndedEventArgs e)
    {
        var thisAsISwipeView = (ISwipeView)this;
        thisAsISwipeView.SwipeEndedAction?.Invoke();
        thisAsISwipeView.SwipeEndedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.SwipeStarted -= NativeControl_SwipeStarted;
            NativeControl.SwipeChanging -= NativeControl_SwipeChanging;
            NativeControl.SwipeEnded -= NativeControl_SwipeEnded;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class SwipeView : SwipeView<Microsoft.Maui.Controls.SwipeView>
{
    public SwipeView()
    {
    }

    public SwipeView(Action<Microsoft.Maui.Controls.SwipeView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class SwipeViewExtensions
{
    public static T Threshold<T>(this T swipeView, double threshold, RxDoubleAnimation? customAnimation = null)
        where T : ISwipeView
    {
        swipeView.Threshold = threshold;
        swipeView.AppendAnimatable(Microsoft.Maui.Controls.SwipeView.ThresholdProperty, customAnimation ?? new RxDoubleAnimation(threshold), v => swipeView.Threshold = new PropertyValue<double>(v.CurrentValue()));
        return swipeView;
    }

    public static T Threshold<T>(this T swipeView, Func<double> thresholdFunc)
        where T : ISwipeView
    {
        swipeView.Threshold = new PropertyValue<double>(thresholdFunc);
        return swipeView;
    }

    public static T OnSwipeStarted<T>(this T swipeView, Action? swipeStartedAction)
        where T : ISwipeView
    {
        swipeView.SwipeStartedAction = swipeStartedAction;
        return swipeView;
    }

    public static T OnSwipeStarted<T>(this T swipeView, Action<object?, SwipeStartedEventArgs>? swipeStartedActionWithArgs)
        where T : ISwipeView
    {
        swipeView.SwipeStartedActionWithArgs = swipeStartedActionWithArgs;
        return swipeView;
    }

    public static T OnSwipeChanging<T>(this T swipeView, Action? swipeChangingAction)
        where T : ISwipeView
    {
        swipeView.SwipeChangingAction = swipeChangingAction;
        return swipeView;
    }

    public static T OnSwipeChanging<T>(this T swipeView, Action<object?, SwipeChangingEventArgs>? swipeChangingActionWithArgs)
        where T : ISwipeView
    {
        swipeView.SwipeChangingActionWithArgs = swipeChangingActionWithArgs;
        return swipeView;
    }

    public static T OnSwipeEnded<T>(this T swipeView, Action? swipeEndedAction)
        where T : ISwipeView
    {
        swipeView.SwipeEndedAction = swipeEndedAction;
        return swipeView;
    }

    public static T OnSwipeEnded<T>(this T swipeView, Action<object?, SwipeEndedEventArgs>? swipeEndedActionWithArgs)
        where T : ISwipeView
    {
        swipeView.SwipeEndedActionWithArgs = swipeEndedActionWithArgs;
        return swipeView;
    }
}