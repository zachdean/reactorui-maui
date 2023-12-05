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
public partial interface IPanGestureRecognizer : IGestureRecognizer
{
    PropertyValue<int>? TouchPoints { get; set; }

    Action? PanUpdatedAction { get; set; }

    Action<object?, PanUpdatedEventArgs>? PanUpdatedActionWithArgs { get; set; }
}

public partial class PanGestureRecognizer<T> : GestureRecognizer<T>, IPanGestureRecognizer where T : Microsoft.Maui.Controls.PanGestureRecognizer, new()
{
    public PanGestureRecognizer()
    {
    }

    public PanGestureRecognizer(Action<T?> componentRefAction) : base(componentRefAction)
    {
    }

    PropertyValue<int>? IPanGestureRecognizer.TouchPoints { get; set; }

    Action? IPanGestureRecognizer.PanUpdatedAction { get; set; }

    Action<object?, PanUpdatedEventArgs>? IPanGestureRecognizer.PanUpdatedActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIPanGestureRecognizer = (IPanGestureRecognizer)this;
        thisAsIPanGestureRecognizer.TouchPoints = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIPanGestureRecognizer = (IPanGestureRecognizer)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.PanGestureRecognizer.TouchPointsProperty, thisAsIPanGestureRecognizer.TouchPoints);
        base.OnUpdate();
        OnEndUpdate();
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
        var thisAsIPanGestureRecognizer = (IPanGestureRecognizer)this;
        if (thisAsIPanGestureRecognizer.PanUpdatedAction != null || thisAsIPanGestureRecognizer.PanUpdatedActionWithArgs != null)
        {
            NativeControl.PanUpdated += NativeControl_PanUpdated;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_PanUpdated(object? sender, PanUpdatedEventArgs e)
    {
        var thisAsIPanGestureRecognizer = (IPanGestureRecognizer)this;
        thisAsIPanGestureRecognizer.PanUpdatedAction?.Invoke();
        thisAsIPanGestureRecognizer.PanUpdatedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.PanUpdated -= NativeControl_PanUpdated;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class PanGestureRecognizer : PanGestureRecognizer<Microsoft.Maui.Controls.PanGestureRecognizer>
{
    public PanGestureRecognizer()
    {
    }

    public PanGestureRecognizer(Action<Microsoft.Maui.Controls.PanGestureRecognizer?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class PanGestureRecognizerExtensions
{
    public static T TouchPoints<T>(this T panGestureRecognizer, int touchPoints)
        where T : IPanGestureRecognizer
    {
        panGestureRecognizer.TouchPoints = new PropertyValue<int>(touchPoints);
        return panGestureRecognizer;
    }

    public static T TouchPoints<T>(this T panGestureRecognizer, Func<int> touchPointsFunc)
        where T : IPanGestureRecognizer
    {
        panGestureRecognizer.TouchPoints = new PropertyValue<int>(touchPointsFunc);
        return panGestureRecognizer;
    }

    public static T OnPanUpdated<T>(this T panGestureRecognizer, Action? panUpdatedAction)
        where T : IPanGestureRecognizer
    {
        panGestureRecognizer.PanUpdatedAction = panUpdatedAction;
        return panGestureRecognizer;
    }

    public static T OnPanUpdated<T>(this T panGestureRecognizer, Action<object?, PanUpdatedEventArgs>? panUpdatedActionWithArgs)
        where T : IPanGestureRecognizer
    {
        panGestureRecognizer.PanUpdatedActionWithArgs = panUpdatedActionWithArgs;
        return panGestureRecognizer;
    }
}