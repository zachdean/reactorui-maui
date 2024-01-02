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
public partial interface IIndicatorView : ITemplatedView
{
    object? IndicatorsShape { get; set; }

    object? Position { get; set; }

    object? Count { get; set; }

    object? MaximumVisible { get; set; }

    object? HideSingle { get; set; }

    object? IndicatorColor { get; set; }

    object? SelectedIndicatorColor { get; set; }

    object? IndicatorSize { get; set; }
}

public partial class IndicatorView<T> : TemplatedView<T>, IIndicatorView where T : Microsoft.Maui.Controls.IndicatorView, new()
{
    public IndicatorView()
    {
    }

    public IndicatorView(Action<T?> componentRefAction) : base(componentRefAction)
    {
    }

    object? IIndicatorView.IndicatorsShape { get; set; }

    object? IIndicatorView.Position { get; set; }

    object? IIndicatorView.Count { get; set; }

    object? IIndicatorView.MaximumVisible { get; set; }

    object? IIndicatorView.HideSingle { get; set; }

    object? IIndicatorView.IndicatorColor { get; set; }

    object? IIndicatorView.SelectedIndicatorColor { get; set; }

    object? IIndicatorView.IndicatorSize { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIIndicatorView = (IIndicatorView)this;
        thisAsIIndicatorView.IndicatorsShape = null;
        thisAsIIndicatorView.Position = null;
        thisAsIIndicatorView.Count = null;
        thisAsIIndicatorView.MaximumVisible = null;
        thisAsIIndicatorView.HideSingle = null;
        thisAsIIndicatorView.IndicatorColor = null;
        thisAsIIndicatorView.SelectedIndicatorColor = null;
        thisAsIIndicatorView.IndicatorSize = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIIndicatorView = (IIndicatorView)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.IndicatorsShapeProperty, thisAsIIndicatorView.IndicatorsShape);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.PositionProperty, thisAsIIndicatorView.Position);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.CountProperty, thisAsIIndicatorView.Count);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.MaximumVisibleProperty, thisAsIIndicatorView.MaximumVisible);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.HideSingleProperty, thisAsIIndicatorView.HideSingle);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.IndicatorColorProperty, thisAsIIndicatorView.IndicatorColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.SelectedIndicatorColorProperty, thisAsIIndicatorView.SelectedIndicatorColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, thisAsIIndicatorView.IndicatorSize);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIIndicatorView = (IIndicatorView)this;
        AnimateProperty(Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, thisAsIIndicatorView.IndicatorSize);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
}

public partial class IndicatorView : IndicatorView<Microsoft.Maui.Controls.IndicatorView>
{
    public IndicatorView()
    {
    }

    public IndicatorView(Action<Microsoft.Maui.Controls.IndicatorView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class IndicatorViewExtensions
{
    public static T IndicatorsShape<T>(this T indicatorView, Microsoft.Maui.Controls.IndicatorShape indicatorsShape)
        where T : IIndicatorView
    {
        indicatorView.IndicatorsShape = indicatorsShape;
        return indicatorView;
    }

    public static T IndicatorsShape<T>(this T indicatorView, Func<Microsoft.Maui.Controls.IndicatorShape> indicatorsShapeFunc)
        where T : IIndicatorView
    {
        indicatorView.IndicatorsShape = new PropertyValue<Microsoft.Maui.Controls.IndicatorShape>(indicatorsShapeFunc);
        return indicatorView;
    }

    public static T Position<T>(this T indicatorView, int position)
        where T : IIndicatorView
    {
        indicatorView.Position = position;
        return indicatorView;
    }

    public static T Position<T>(this T indicatorView, Func<int> positionFunc)
        where T : IIndicatorView
    {
        indicatorView.Position = new PropertyValue<int>(positionFunc);
        return indicatorView;
    }

    public static T Count<T>(this T indicatorView, int count)
        where T : IIndicatorView
    {
        indicatorView.Count = count;
        return indicatorView;
    }

    public static T Count<T>(this T indicatorView, Func<int> countFunc)
        where T : IIndicatorView
    {
        indicatorView.Count = new PropertyValue<int>(countFunc);
        return indicatorView;
    }

    public static T MaximumVisible<T>(this T indicatorView, int maximumVisible)
        where T : IIndicatorView
    {
        indicatorView.MaximumVisible = maximumVisible;
        return indicatorView;
    }

    public static T MaximumVisible<T>(this T indicatorView, Func<int> maximumVisibleFunc)
        where T : IIndicatorView
    {
        indicatorView.MaximumVisible = new PropertyValue<int>(maximumVisibleFunc);
        return indicatorView;
    }

    public static T HideSingle<T>(this T indicatorView, bool hideSingle)
        where T : IIndicatorView
    {
        indicatorView.HideSingle = hideSingle;
        return indicatorView;
    }

    public static T HideSingle<T>(this T indicatorView, Func<bool> hideSingleFunc)
        where T : IIndicatorView
    {
        indicatorView.HideSingle = new PropertyValue<bool>(hideSingleFunc);
        return indicatorView;
    }

    public static T IndicatorColor<T>(this T indicatorView, Microsoft.Maui.Graphics.Color indicatorColor)
        where T : IIndicatorView
    {
        indicatorView.IndicatorColor = indicatorColor;
        return indicatorView;
    }

    public static T IndicatorColor<T>(this T indicatorView, Func<Microsoft.Maui.Graphics.Color> indicatorColorFunc)
        where T : IIndicatorView
    {
        indicatorView.IndicatorColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(indicatorColorFunc);
        return indicatorView;
    }

    public static T SelectedIndicatorColor<T>(this T indicatorView, Microsoft.Maui.Graphics.Color selectedIndicatorColor)
        where T : IIndicatorView
    {
        indicatorView.SelectedIndicatorColor = selectedIndicatorColor;
        return indicatorView;
    }

    public static T SelectedIndicatorColor<T>(this T indicatorView, Func<Microsoft.Maui.Graphics.Color> selectedIndicatorColorFunc)
        where T : IIndicatorView
    {
        indicatorView.SelectedIndicatorColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(selectedIndicatorColorFunc);
        return indicatorView;
    }

    public static T IndicatorSize<T>(this T indicatorView, double indicatorSize, RxDoubleAnimation? customAnimation = null)
        where T : IIndicatorView
    {
        indicatorView.IndicatorSize = indicatorSize;
        indicatorView.AppendAnimatable(Microsoft.Maui.Controls.IndicatorView.IndicatorSizeProperty, customAnimation ?? new RxDoubleAnimation(indicatorSize), v => indicatorView.IndicatorSize = new PropertyValue<double>(v.CurrentValue()));
        return indicatorView;
    }

    public static T IndicatorSize<T>(this T indicatorView, Func<double> indicatorSizeFunc)
        where T : IIndicatorView
    {
        indicatorView.IndicatorSize = new PropertyValue<double>(indicatorSizeFunc);
        return indicatorView;
    }
}