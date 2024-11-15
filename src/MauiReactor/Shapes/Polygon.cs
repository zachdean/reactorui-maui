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
public partial interface IPolygon : Shapes.IShape
{
    object? Points { get; set; }

    object? FillRule { get; set; }
}

public sealed partial class Polygon : Shapes.Shape<Microsoft.Maui.Controls.Shapes.Polygon>, IPolygon
{
    public Polygon()
    {
        PolygonStyles.Default?.Invoke(this);
    }

    public Polygon(Action<Microsoft.Maui.Controls.Shapes.Polygon?> componentRefAction) : base(componentRefAction)
    {
        PolygonStyles.Default?.Invoke(this);
    }

    object? IPolygon.Points { get; set; }

    object? IPolygon.FillRule { get; set; }

    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIPolygon = (IPolygon)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Polygon.PointsProperty, thisAsIPolygon.Points);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Polygon.FillRuleProperty, thisAsIPolygon.FillRule);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && PolygonStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public static partial class PolygonExtensions
{
    public static T Points<T>(this T polygon, Microsoft.Maui.Controls.PointCollection points)
        where T : IPolygon
    {
        polygon.Points = points;
        return polygon;
    }

    public static T Points<T>(this T polygon, Func<Microsoft.Maui.Controls.PointCollection> pointsFunc)
        where T : IPolygon
    {
        polygon.Points = new PropertyValue<Microsoft.Maui.Controls.PointCollection>(pointsFunc);
        return polygon;
    }

    public static T FillRule<T>(this T polygon, Microsoft.Maui.Controls.Shapes.FillRule fillRule)
        where T : IPolygon
    {
        polygon.FillRule = fillRule;
        return polygon;
    }

    public static T FillRule<T>(this T polygon, Func<Microsoft.Maui.Controls.Shapes.FillRule> fillRuleFunc)
        where T : IPolygon
    {
        polygon.FillRule = new PropertyValue<Microsoft.Maui.Controls.Shapes.FillRule>(fillRuleFunc);
        return polygon;
    }
}

public static partial class PolygonStyles
{
    public static Action<IPolygon>? Default { get; set; }
    public static Dictionary<string, Action<IPolygon>> Themes { get; } = [];
}