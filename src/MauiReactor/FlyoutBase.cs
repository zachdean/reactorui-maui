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
public partial interface IFlyoutBase : IElement
{
}

public abstract partial class FlyoutBase<T> : Element<T>, IFlyoutBase where T : Microsoft.Maui.Controls.FlyoutBase, new()
{
    protected FlyoutBase(Action<T?>? componentRefAction = null) : base(componentRefAction)
    {
        FlyoutBaseStyles.Default?.Invoke(this);
    }

    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && FlyoutBaseStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void Migrated(VisualNode newNode);
    protected override void OnMigrated(VisualNode newNode)
    {
        Migrated(newNode);
        base.OnMigrated(newNode);
    }
}

public static partial class FlyoutBaseExtensions
{
}

public static partial class FlyoutBaseStyles
{
    public static Action<IFlyoutBase>? Default { get; set; }
    public static Dictionary<string, Action<IFlyoutBase>> Themes { get; } = [];
}