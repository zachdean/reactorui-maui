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
public partial interface ILinearItemsLayout : IItemsLayout
{
    object? ItemSpacing { get; set; }
}

public abstract partial class LinearItemsLayout<T> : ItemsLayout<T>, ILinearItemsLayout where T : Microsoft.Maui.Controls.LinearItemsLayout, new()
{
    protected LinearItemsLayout()
    {
        LinearItemsLayoutStyles.Default?.Invoke(this);
    }

    protected LinearItemsLayout(Action<T?> componentRefAction) : base(componentRefAction)
    {
        LinearItemsLayoutStyles.Default?.Invoke(this);
    }

    object? ILinearItemsLayout.ItemSpacing { get; set; }

    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsILinearItemsLayout = (ILinearItemsLayout)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty, thisAsILinearItemsLayout.ItemSpacing);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && LinearItemsLayoutStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public static partial class LinearItemsLayoutExtensions
{
    static object? SetItemSpacing(object linearItemsLayout, RxAnimation animation) => ((ILinearItemsLayout)linearItemsLayout).ItemSpacing = ((RxDoubleAnimation)animation).CurrentValue();
    public static T ItemSpacing<T>(this T linearItemsLayout, double itemSpacing, RxDoubleAnimation? customAnimation = null)
        where T : ILinearItemsLayout
    {
        linearItemsLayout.ItemSpacing = itemSpacing;
        linearItemsLayout.AppendAnimatable(Microsoft.Maui.Controls.LinearItemsLayout.ItemSpacingProperty, customAnimation ?? new RxDoubleAnimation(itemSpacing), SetItemSpacing);
        return linearItemsLayout;
    }

    public static T ItemSpacing<T>(this T linearItemsLayout, Func<double> itemSpacingFunc)
        where T : ILinearItemsLayout
    {
        linearItemsLayout.ItemSpacing = new PropertyValue<double>(itemSpacingFunc);
        return linearItemsLayout;
    }
}

public static partial class LinearItemsLayoutStyles
{
    public static Action<ILinearItemsLayout>? Default { get; set; }
    public static Dictionary<string, Action<ILinearItemsLayout>> Themes { get; } = [];
}