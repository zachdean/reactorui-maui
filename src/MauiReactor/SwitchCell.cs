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
public partial interface ISwitchCell : ICell
{
    object? On { get; set; }

    object? Text { get; set; }

    object? OnColor { get; set; }

    Action? OnChangedAction { get; set; }

    Action<object?, ToggledEventArgs>? OnChangedActionWithArgs { get; set; }
}

public partial class SwitchCell<T> : Cell<T>, ISwitchCell where T : Microsoft.Maui.Controls.SwitchCell, new()
{
    public SwitchCell()
    {
    }

    public SwitchCell(Action<T?> componentRefAction) : base(componentRefAction)
    {
    }

    object? ISwitchCell.On { get; set; }

    object? ISwitchCell.Text { get; set; }

    object? ISwitchCell.OnColor { get; set; }

    Action? ISwitchCell.OnChangedAction { get; set; }

    Action<object?, ToggledEventArgs>? ISwitchCell.OnChangedActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsISwitchCell = (ISwitchCell)this;
        thisAsISwitchCell.On = null;
        thisAsISwitchCell.Text = null;
        thisAsISwitchCell.OnColor = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsISwitchCell = (ISwitchCell)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SwitchCell.OnProperty, thisAsISwitchCell.On);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SwitchCell.TextProperty, thisAsISwitchCell.Text);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.SwitchCell.OnColorProperty, thisAsISwitchCell.OnColor);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsISwitchCell = (ISwitchCell)this;
        if (thisAsISwitchCell.OnChangedAction != null || thisAsISwitchCell.OnChangedActionWithArgs != null)
        {
            NativeControl.OnChanged += NativeControl_OnChanged;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_OnChanged(object? sender, ToggledEventArgs e)
    {
        var thisAsISwitchCell = (ISwitchCell)this;
        thisAsISwitchCell.OnChangedAction?.Invoke();
        thisAsISwitchCell.OnChangedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.OnChanged -= NativeControl_OnChanged;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class SwitchCell : SwitchCell<Microsoft.Maui.Controls.SwitchCell>
{
    public SwitchCell()
    {
    }

    public SwitchCell(Action<Microsoft.Maui.Controls.SwitchCell?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class SwitchCellExtensions
{
    public static T On<T>(this T switchCell, bool on)
        where T : ISwitchCell
    {
        switchCell.On = on;
        return switchCell;
    }

    public static T On<T>(this T switchCell, Func<bool> onFunc)
        where T : ISwitchCell
    {
        switchCell.On = new PropertyValue<bool>(onFunc);
        return switchCell;
    }

    public static T Text<T>(this T switchCell, string text)
        where T : ISwitchCell
    {
        switchCell.Text = text;
        return switchCell;
    }

    public static T Text<T>(this T switchCell, Func<string> textFunc)
        where T : ISwitchCell
    {
        switchCell.Text = new PropertyValue<string>(textFunc);
        return switchCell;
    }

    public static T OnColor<T>(this T switchCell, Microsoft.Maui.Graphics.Color onColor)
        where T : ISwitchCell
    {
        switchCell.OnColor = onColor;
        return switchCell;
    }

    public static T OnColor<T>(this T switchCell, Func<Microsoft.Maui.Graphics.Color> onColorFunc)
        where T : ISwitchCell
    {
        switchCell.OnColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(onColorFunc);
        return switchCell;
    }

    public static T OnOnChanged<T>(this T switchCell, Action? onChangedAction)
        where T : ISwitchCell
    {
        switchCell.OnChangedAction = onChangedAction;
        return switchCell;
    }

    public static T OnOnChanged<T>(this T switchCell, Action<object?, ToggledEventArgs>? onChangedActionWithArgs)
        where T : ISwitchCell
    {
        switchCell.OnChangedActionWithArgs = onChangedActionWithArgs;
        return switchCell;
    }
}