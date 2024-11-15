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
public partial interface IGroupableItemsView : ISelectableItemsView
{
    object? IsGrouped { get; set; }
}

public partial class GroupableItemsView<T> : SelectableItemsView<T>, IGroupableItemsView where T : Microsoft.Maui.Controls.GroupableItemsView, new()
{
    public GroupableItemsView()
    {
        GroupableItemsViewStyles.Default?.Invoke(this);
    }

    public GroupableItemsView(Action<T?> componentRefAction) : base(componentRefAction)
    {
        GroupableItemsViewStyles.Default?.Invoke(this);
    }

    object? IGroupableItemsView.IsGrouped { get; set; }

    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIGroupableItemsView = (IGroupableItemsView)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.GroupableItemsView.IsGroupedProperty, thisAsIGroupableItemsView.IsGrouped);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && GroupableItemsViewStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class GroupableItemsView : GroupableItemsView<Microsoft.Maui.Controls.GroupableItemsView>
{
    public GroupableItemsView()
    {
    }

    public GroupableItemsView(Action<Microsoft.Maui.Controls.GroupableItemsView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class GroupableItemsViewExtensions
{
    public static T IsGrouped<T>(this T groupableItemsView, bool isGrouped)
        where T : IGroupableItemsView
    {
        groupableItemsView.IsGrouped = isGrouped;
        return groupableItemsView;
    }

    public static T IsGrouped<T>(this T groupableItemsView, Func<bool> isGroupedFunc)
        where T : IGroupableItemsView
    {
        groupableItemsView.IsGrouped = new PropertyValue<bool>(isGroupedFunc);
        return groupableItemsView;
    }
}

public static partial class GroupableItemsViewStyles
{
    public static Action<IGroupableItemsView>? Default { get; set; }
    public static Dictionary<string, Action<IGroupableItemsView>> Themes { get; } = [];
}