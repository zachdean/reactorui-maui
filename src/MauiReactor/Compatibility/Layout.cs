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
namespace MauiReactor.Compatibility;
public partial interface ILayout : IView
{
    object? IsClippedToBounds { get; set; }

    object? CascadeInputTransparent { get; set; }

    object? Padding { get; set; }

    Action? LayoutChangedAction { get; set; }

    Action<object?, EventArgs>? LayoutChangedActionWithArgs { get; set; }
}

public abstract partial class Layout<T> : View<T>, ILayout where T : Microsoft.Maui.Controls.Compatibility.Layout, new()
{
    protected Layout()
    {
        LayoutStyles.Default?.Invoke(this);
    }

    protected Layout(Action<T?> componentRefAction) : base(componentRefAction)
    {
        LayoutStyles.Default?.Invoke(this);
    }

    object? ILayout.IsClippedToBounds { get; set; }

    object? ILayout.CascadeInputTransparent { get; set; }

    object? ILayout.Padding { get; set; }

    Action? ILayout.LayoutChangedAction { get; set; }

    Action<object?, EventArgs>? ILayout.LayoutChangedActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsILayout = (ILayout)this;
        thisAsILayout.IsClippedToBounds = null;
        thisAsILayout.CascadeInputTransparent = null;
        thisAsILayout.Padding = null;
        thisAsILayout.LayoutChangedAction = null;
        thisAsILayout.LayoutChangedActionWithArgs = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsILayout = (ILayout)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, thisAsILayout.IsClippedToBounds);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, thisAsILayout.CascadeInputTransparent);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, thisAsILayout.Padding);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsILayout = (ILayout)this;
        AnimateProperty(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, thisAsILayout.Padding);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && LayoutStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
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
        var thisAsILayout = (ILayout)this;
        if (thisAsILayout.LayoutChangedAction != null || thisAsILayout.LayoutChangedActionWithArgs != null)
        {
            NativeControl.LayoutChanged += NativeControl_LayoutChanged;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_LayoutChanged(object? sender, EventArgs e)
    {
        var thisAsILayout = (ILayout)this;
        thisAsILayout.LayoutChangedAction?.Invoke();
        thisAsILayout.LayoutChangedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.LayoutChanged -= NativeControl_LayoutChanged;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public static partial class LayoutExtensions
{
    static void SetPadding(object layout, RxAnimation animation) => ((ILayout)layout).Padding = ((RxThicknessAnimation)animation).CurrentValue();
    public static T IsClippedToBounds<T>(this T layout, bool isClippedToBounds)
        where T : ILayout
    {
        layout.IsClippedToBounds = isClippedToBounds;
        return layout;
    }

    public static T IsClippedToBounds<T>(this T layout, Func<bool> isClippedToBoundsFunc)
        where T : ILayout
    {
        layout.IsClippedToBounds = new PropertyValue<bool>(isClippedToBoundsFunc);
        return layout;
    }

    public static T CascadeInputTransparent<T>(this T layout, bool cascadeInputTransparent)
        where T : ILayout
    {
        layout.CascadeInputTransparent = cascadeInputTransparent;
        return layout;
    }

    public static T CascadeInputTransparent<T>(this T layout, Func<bool> cascadeInputTransparentFunc)
        where T : ILayout
    {
        layout.CascadeInputTransparent = new PropertyValue<bool>(cascadeInputTransparentFunc);
        return layout;
    }

    public static T Padding<T>(this T layout, Microsoft.Maui.Thickness padding, RxThicknessAnimation? customAnimation = null)
        where T : ILayout
    {
        layout.Padding = padding;
        layout.AppendAnimatable(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(padding), SetPadding);
        return layout;
    }

    public static T Padding<T>(this T layout, Func<Microsoft.Maui.Thickness> paddingFunc)
        where T : ILayout
    {
        layout.Padding = new PropertyValue<Microsoft.Maui.Thickness>(paddingFunc);
        return layout;
    }

    public static T Padding<T>(this T layout, double leftRight, double topBottom, RxThicknessAnimation? customAnimation = null)
        where T : ILayout
    {
        layout.Padding = new Thickness(leftRight, topBottom);
        layout.AppendAnimatable(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(leftRight, topBottom)), SetPadding);
        return layout;
    }

    public static T Padding<T>(this T layout, double uniformSize, RxThicknessAnimation? customAnimation = null)
        where T : ILayout
    {
        layout.Padding = new Thickness(uniformSize);
        layout.AppendAnimatable(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(uniformSize)), SetPadding);
        return layout;
    }

    public static T Padding<T>(this T layout, double left, double top, double right, double bottom, RxThicknessAnimation? customAnimation = null)
        where T : ILayout
    {
        layout.Padding = new Thickness(left, top, right, bottom);
        layout.AppendAnimatable(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(left, top, right, bottom)), SetPadding);
        return layout;
    }

    public static T OnLayoutChanged<T>(this T layout, Action? layoutChangedAction)
        where T : ILayout
    {
        layout.LayoutChangedAction = layoutChangedAction;
        return layout;
    }

    public static T OnLayoutChanged<T>(this T layout, Action<object?, EventArgs>? layoutChangedActionWithArgs)
        where T : ILayout
    {
        layout.LayoutChangedActionWithArgs = layoutChangedActionWithArgs;
        return layout;
    }
}

public static partial class LayoutStyles
{
    public static Action<ILayout>? Default { get; set; }
    public static Dictionary<string, Action<ILayout>> Themes { get; } = [];
}