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
public partial interface IStackLayout : IStackBase
{
    object? Orientation { get; set; }
}

public partial class StackLayout<T> : StackBase<T>, IStackLayout where T : Microsoft.Maui.Controls.StackLayout, new()
{
    public StackLayout()
    {
        StackLayoutStyles.Default?.Invoke(this);
    }

    public StackLayout(Action<T?> componentRefAction) : base(componentRefAction)
    {
        StackLayoutStyles.Default?.Invoke(this);
    }

    object? IStackLayout.Orientation { get; set; }

    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIStackLayout = (IStackLayout)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.StackLayout.OrientationProperty, thisAsIStackLayout.Orientation);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && StackLayoutStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class StackLayout : StackLayout<Microsoft.Maui.Controls.StackLayout>
{
    public StackLayout()
    {
    }

    public StackLayout(Action<Microsoft.Maui.Controls.StackLayout?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class StackLayoutExtensions
{
    public static T Orientation<T>(this T stackLayout, Microsoft.Maui.Controls.StackOrientation orientation)
        where T : IStackLayout
    {
        stackLayout.Orientation = orientation;
        return stackLayout;
    }

    public static T Orientation<T>(this T stackLayout, Func<Microsoft.Maui.Controls.StackOrientation> orientationFunc)
        where T : IStackLayout
    {
        stackLayout.Orientation = new PropertyValue<Microsoft.Maui.Controls.StackOrientation>(orientationFunc);
        return stackLayout;
    }
}

public static partial class StackLayoutStyles
{
    public static Action<IStackLayout>? Default { get; set; }
    public static Dictionary<string, Action<IStackLayout>> Themes { get; } = [];
}