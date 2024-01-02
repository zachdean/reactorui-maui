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
namespace MauiReactor.Shapes;
public partial interface IRoundRectangle : Shapes.IShape
{
    object? CornerRadius { get; set; }
}

public sealed partial class RoundRectangle : Shapes.Shape<Microsoft.Maui.Controls.Shapes.RoundRectangle>, IRoundRectangle
{
    public RoundRectangle()
    {
    }

    public RoundRectangle(Action<Microsoft.Maui.Controls.Shapes.RoundRectangle?> componentRefAction) : base(componentRefAction)
    {
    }

    object? IRoundRectangle.CornerRadius { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIRoundRectangle = (IRoundRectangle)this;
        thisAsIRoundRectangle.CornerRadius = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIRoundRectangle = (IRoundRectangle)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, thisAsIRoundRectangle.CornerRadius);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIRoundRectangle = (IRoundRectangle)this;
        AnimateProperty(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, thisAsIRoundRectangle.CornerRadius);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
}

public static partial class RoundRectangleExtensions
{
    public static T CornerRadius<T>(this T roundRectangle, Microsoft.Maui.CornerRadius cornerRadius, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = cornerRadius;
        roundRectangle.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(cornerRadius), v => roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(v.CurrentValue()));
        return roundRectangle;
    }

    public static T CornerRadius<T>(this T roundRectangle, Func<Microsoft.Maui.CornerRadius> cornerRadiusFunc)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(cornerRadiusFunc);
        return roundRectangle;
    }

    public static T CornerRadius<T>(this T roundRectangle, double uniformRadius, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = new CornerRadius(uniformRadius);
        roundRectangle.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(new CornerRadius(uniformRadius)), v => roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(v.CurrentValue()));
        return roundRectangle;
    }

    public static T CornerRadius<T>(this T roundRectangle, double topLeft, double topRight, double bottomLeft, double bottomRight, RxCornerRadiusAnimation? customAnimation = null)
        where T : IRoundRectangle
    {
        roundRectangle.CornerRadius = new CornerRadius(topLeft, topRight, bottomLeft, bottomRight);
        roundRectangle.AppendAnimatable(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, customAnimation ?? new RxSimpleCornerRadiusAnimation(new CornerRadius(topLeft, topRight, bottomLeft, bottomRight)), v => roundRectangle.CornerRadius = new PropertyValue<Microsoft.Maui.CornerRadius>(v.CurrentValue()));
        return roundRectangle;
    }
}