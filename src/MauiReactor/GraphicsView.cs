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
public partial interface IGraphicsView : IView
{
    object? Drawable { get; set; }

    Action? StartHoverInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? StartHoverInteractionActionWithArgs { get; set; }

    Action? MoveHoverInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? MoveHoverInteractionActionWithArgs { get; set; }

    Action? EndHoverInteractionAction { get; set; }

    Action<object?, EventArgs>? EndHoverInteractionActionWithArgs { get; set; }

    Action? StartInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? StartInteractionActionWithArgs { get; set; }

    Action? DragInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? DragInteractionActionWithArgs { get; set; }

    Action? EndInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? EndInteractionActionWithArgs { get; set; }

    Action? CancelInteractionAction { get; set; }

    Action<object?, EventArgs>? CancelInteractionActionWithArgs { get; set; }
}

public partial class GraphicsView<T> : View<T>, IGraphicsView where T : Microsoft.Maui.Controls.GraphicsView, new()
{
    public GraphicsView()
    {
        GraphicsViewStyles.Default?.Invoke(this);
    }

    public GraphicsView(Action<T?> componentRefAction) : base(componentRefAction)
    {
        GraphicsViewStyles.Default?.Invoke(this);
    }

    object? IGraphicsView.Drawable { get; set; }

    Action? IGraphicsView.StartHoverInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? IGraphicsView.StartHoverInteractionActionWithArgs { get; set; }

    Action? IGraphicsView.MoveHoverInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? IGraphicsView.MoveHoverInteractionActionWithArgs { get; set; }

    Action? IGraphicsView.EndHoverInteractionAction { get; set; }

    Action<object?, EventArgs>? IGraphicsView.EndHoverInteractionActionWithArgs { get; set; }

    Action? IGraphicsView.StartInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? IGraphicsView.StartInteractionActionWithArgs { get; set; }

    Action? IGraphicsView.DragInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? IGraphicsView.DragInteractionActionWithArgs { get; set; }

    Action? IGraphicsView.EndInteractionAction { get; set; }

    Action<object?, TouchEventArgs>? IGraphicsView.EndInteractionActionWithArgs { get; set; }

    Action? IGraphicsView.CancelInteractionAction { get; set; }

    Action<object?, EventArgs>? IGraphicsView.CancelInteractionActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.Drawable = null;
        thisAsIGraphicsView.StartHoverInteractionAction = null;
        thisAsIGraphicsView.StartHoverInteractionActionWithArgs = null;
        thisAsIGraphicsView.MoveHoverInteractionAction = null;
        thisAsIGraphicsView.MoveHoverInteractionActionWithArgs = null;
        thisAsIGraphicsView.EndHoverInteractionAction = null;
        thisAsIGraphicsView.EndHoverInteractionActionWithArgs = null;
        thisAsIGraphicsView.StartInteractionAction = null;
        thisAsIGraphicsView.StartInteractionActionWithArgs = null;
        thisAsIGraphicsView.DragInteractionAction = null;
        thisAsIGraphicsView.DragInteractionActionWithArgs = null;
        thisAsIGraphicsView.EndInteractionAction = null;
        thisAsIGraphicsView.EndInteractionActionWithArgs = null;
        thisAsIGraphicsView.CancelInteractionAction = null;
        thisAsIGraphicsView.CancelInteractionActionWithArgs = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIGraphicsView = (IGraphicsView)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.GraphicsView.DrawableProperty, thisAsIGraphicsView.Drawable);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && GraphicsViewStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
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
        var thisAsIGraphicsView = (IGraphicsView)this;
        if (thisAsIGraphicsView.StartHoverInteractionAction != null || thisAsIGraphicsView.StartHoverInteractionActionWithArgs != null)
        {
            NativeControl.StartHoverInteraction += NativeControl_StartHoverInteraction;
        }

        if (thisAsIGraphicsView.MoveHoverInteractionAction != null || thisAsIGraphicsView.MoveHoverInteractionActionWithArgs != null)
        {
            NativeControl.MoveHoverInteraction += NativeControl_MoveHoverInteraction;
        }

        if (thisAsIGraphicsView.EndHoverInteractionAction != null || thisAsIGraphicsView.EndHoverInteractionActionWithArgs != null)
        {
            NativeControl.EndHoverInteraction += NativeControl_EndHoverInteraction;
        }

        if (thisAsIGraphicsView.StartInteractionAction != null || thisAsIGraphicsView.StartInteractionActionWithArgs != null)
        {
            NativeControl.StartInteraction += NativeControl_StartInteraction;
        }

        if (thisAsIGraphicsView.DragInteractionAction != null || thisAsIGraphicsView.DragInteractionActionWithArgs != null)
        {
            NativeControl.DragInteraction += NativeControl_DragInteraction;
        }

        if (thisAsIGraphicsView.EndInteractionAction != null || thisAsIGraphicsView.EndInteractionActionWithArgs != null)
        {
            NativeControl.EndInteraction += NativeControl_EndInteraction;
        }

        if (thisAsIGraphicsView.CancelInteractionAction != null || thisAsIGraphicsView.CancelInteractionActionWithArgs != null)
        {
            NativeControl.CancelInteraction += NativeControl_CancelInteraction;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_StartHoverInteraction(object? sender, TouchEventArgs e)
    {
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.StartHoverInteractionAction?.Invoke();
        thisAsIGraphicsView.StartHoverInteractionActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_MoveHoverInteraction(object? sender, TouchEventArgs e)
    {
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.MoveHoverInteractionAction?.Invoke();
        thisAsIGraphicsView.MoveHoverInteractionActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_EndHoverInteraction(object? sender, EventArgs e)
    {
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.EndHoverInteractionAction?.Invoke();
        thisAsIGraphicsView.EndHoverInteractionActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_StartInteraction(object? sender, TouchEventArgs e)
    {
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.StartInteractionAction?.Invoke();
        thisAsIGraphicsView.StartInteractionActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_DragInteraction(object? sender, TouchEventArgs e)
    {
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.DragInteractionAction?.Invoke();
        thisAsIGraphicsView.DragInteractionActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_EndInteraction(object? sender, TouchEventArgs e)
    {
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.EndInteractionAction?.Invoke();
        thisAsIGraphicsView.EndInteractionActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_CancelInteraction(object? sender, EventArgs e)
    {
        var thisAsIGraphicsView = (IGraphicsView)this;
        thisAsIGraphicsView.CancelInteractionAction?.Invoke();
        thisAsIGraphicsView.CancelInteractionActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.StartHoverInteraction -= NativeControl_StartHoverInteraction;
            NativeControl.MoveHoverInteraction -= NativeControl_MoveHoverInteraction;
            NativeControl.EndHoverInteraction -= NativeControl_EndHoverInteraction;
            NativeControl.StartInteraction -= NativeControl_StartInteraction;
            NativeControl.DragInteraction -= NativeControl_DragInteraction;
            NativeControl.EndInteraction -= NativeControl_EndInteraction;
            NativeControl.CancelInteraction -= NativeControl_CancelInteraction;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class GraphicsView : GraphicsView<Microsoft.Maui.Controls.GraphicsView>
{
    public GraphicsView()
    {
    }

    public GraphicsView(Action<Microsoft.Maui.Controls.GraphicsView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class GraphicsViewExtensions
{
    public static T Drawable<T>(this T graphicsView, Microsoft.Maui.Graphics.IDrawable drawable)
        where T : IGraphicsView
    {
        graphicsView.Drawable = drawable;
        return graphicsView;
    }

    public static T Drawable<T>(this T graphicsView, Func<Microsoft.Maui.Graphics.IDrawable> drawableFunc)
        where T : IGraphicsView
    {
        graphicsView.Drawable = new PropertyValue<Microsoft.Maui.Graphics.IDrawable>(drawableFunc);
        return graphicsView;
    }

    public static T OnStartHoverInteraction<T>(this T graphicsView, Action? startHoverInteractionAction)
        where T : IGraphicsView
    {
        graphicsView.StartHoverInteractionAction = startHoverInteractionAction;
        return graphicsView;
    }

    public static T OnStartHoverInteraction<T>(this T graphicsView, Action<object?, TouchEventArgs>? startHoverInteractionActionWithArgs)
        where T : IGraphicsView
    {
        graphicsView.StartHoverInteractionActionWithArgs = startHoverInteractionActionWithArgs;
        return graphicsView;
    }

    public static T OnMoveHoverInteraction<T>(this T graphicsView, Action? moveHoverInteractionAction)
        where T : IGraphicsView
    {
        graphicsView.MoveHoverInteractionAction = moveHoverInteractionAction;
        return graphicsView;
    }

    public static T OnMoveHoverInteraction<T>(this T graphicsView, Action<object?, TouchEventArgs>? moveHoverInteractionActionWithArgs)
        where T : IGraphicsView
    {
        graphicsView.MoveHoverInteractionActionWithArgs = moveHoverInteractionActionWithArgs;
        return graphicsView;
    }

    public static T OnEndHoverInteraction<T>(this T graphicsView, Action? endHoverInteractionAction)
        where T : IGraphicsView
    {
        graphicsView.EndHoverInteractionAction = endHoverInteractionAction;
        return graphicsView;
    }

    public static T OnEndHoverInteraction<T>(this T graphicsView, Action<object?, EventArgs>? endHoverInteractionActionWithArgs)
        where T : IGraphicsView
    {
        graphicsView.EndHoverInteractionActionWithArgs = endHoverInteractionActionWithArgs;
        return graphicsView;
    }

    public static T OnStartInteraction<T>(this T graphicsView, Action? startInteractionAction)
        where T : IGraphicsView
    {
        graphicsView.StartInteractionAction = startInteractionAction;
        return graphicsView;
    }

    public static T OnStartInteraction<T>(this T graphicsView, Action<object?, TouchEventArgs>? startInteractionActionWithArgs)
        where T : IGraphicsView
    {
        graphicsView.StartInteractionActionWithArgs = startInteractionActionWithArgs;
        return graphicsView;
    }

    public static T OnDragInteraction<T>(this T graphicsView, Action? dragInteractionAction)
        where T : IGraphicsView
    {
        graphicsView.DragInteractionAction = dragInteractionAction;
        return graphicsView;
    }

    public static T OnDragInteraction<T>(this T graphicsView, Action<object?, TouchEventArgs>? dragInteractionActionWithArgs)
        where T : IGraphicsView
    {
        graphicsView.DragInteractionActionWithArgs = dragInteractionActionWithArgs;
        return graphicsView;
    }

    public static T OnEndInteraction<T>(this T graphicsView, Action? endInteractionAction)
        where T : IGraphicsView
    {
        graphicsView.EndInteractionAction = endInteractionAction;
        return graphicsView;
    }

    public static T OnEndInteraction<T>(this T graphicsView, Action<object?, TouchEventArgs>? endInteractionActionWithArgs)
        where T : IGraphicsView
    {
        graphicsView.EndInteractionActionWithArgs = endInteractionActionWithArgs;
        return graphicsView;
    }

    public static T OnCancelInteraction<T>(this T graphicsView, Action? cancelInteractionAction)
        where T : IGraphicsView
    {
        graphicsView.CancelInteractionAction = cancelInteractionAction;
        return graphicsView;
    }

    public static T OnCancelInteraction<T>(this T graphicsView, Action<object?, EventArgs>? cancelInteractionActionWithArgs)
        where T : IGraphicsView
    {
        graphicsView.CancelInteractionActionWithArgs = cancelInteractionActionWithArgs;
        return graphicsView;
    }
}

public static partial class GraphicsViewStyles
{
    public static Action<IGraphicsView>? Default { get; set; }
    public static Dictionary<string, Action<IGraphicsView>> Themes { get; } = [];
}