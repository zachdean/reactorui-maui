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
public partial interface IContentView : ITemplatedView
{
}

public partial class ContentView<T> : TemplatedView<T>, IContentView where T : Microsoft.Maui.Controls.ContentView, new()
{
    public ContentView()
    {
        ContentViewStyles.Default?.Invoke(this);
    }

    public ContentView(Action<T?> componentRefAction) : base(componentRefAction)
    {
        ContentViewStyles.Default?.Invoke(this);
    }

    internal override void Reset()
    {
        base.Reset();
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && ContentViewStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class ContentView : ContentView<Microsoft.Maui.Controls.ContentView>
{
    public ContentView()
    {
    }

    public ContentView(Action<Microsoft.Maui.Controls.ContentView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class ContentViewExtensions
{
}

public static partial class ContentViewStyles
{
    public static Action<IContentView>? Default { get; set; }
    public static Dictionary<string, Action<IContentView>> Themes { get; } = [];
}