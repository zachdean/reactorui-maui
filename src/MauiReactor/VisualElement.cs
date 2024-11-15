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
public partial interface IVisualElement : INavigableElement
{
    object? InputTransparent { get; set; }

    object? IsEnabled { get; set; }

    object? AnchorX { get; set; }

    object? AnchorY { get; set; }

    object? TranslationX { get; set; }

    object? TranslationY { get; set; }

    object? Rotation { get; set; }

    object? RotationX { get; set; }

    object? RotationY { get; set; }

    object? Scale { get; set; }

    object? ScaleX { get; set; }

    object? ScaleY { get; set; }

    object? Visual { get; set; }

    object? IsVisible { get; set; }

    object? Opacity { get; set; }

    object? BackgroundColor { get; set; }

    object? Background { get; set; }

    object? WidthRequest { get; set; }

    object? HeightRequest { get; set; }

    object? MinimumWidthRequest { get; set; }

    object? MinimumHeightRequest { get; set; }

    object? MaximumWidthRequest { get; set; }

    object? MaximumHeightRequest { get; set; }

    object? FlowDirection { get; set; }

    object? ZIndex { get; set; }

    Action? ChildrenReorderedAction { get; set; }

    Action<object?, EventArgs>? ChildrenReorderedActionWithArgs { get; set; }

    Action? FocusedAction { get; set; }

    Action<object?, FocusEventArgs>? FocusedActionWithArgs { get; set; }

    Action? MeasureInvalidatedAction { get; set; }

    Action<object?, EventArgs>? MeasureInvalidatedActionWithArgs { get; set; }

    Action? SizeChangedAction { get; set; }

    Action<object?, EventArgs>? SizeChangedActionWithArgs { get; set; }

    Action? UnfocusedAction { get; set; }

    Action<object?, FocusEventArgs>? UnfocusedActionWithArgs { get; set; }

    Action? LoadedAction { get; set; }

    Action<object?, EventArgs>? LoadedActionWithArgs { get; set; }

    Action? UnloadedAction { get; set; }

    Action<object?, EventArgs>? UnloadedActionWithArgs { get; set; }
}

public abstract partial class VisualElement<T> : NavigableElement<T>, IVisualElement where T : Microsoft.Maui.Controls.VisualElement, new()
{
    protected VisualElement()
    {
        VisualElementStyles.Default?.Invoke(this);
    }

    protected VisualElement(Action<T?> componentRefAction) : base(componentRefAction)
    {
        VisualElementStyles.Default?.Invoke(this);
    }

    object? IVisualElement.InputTransparent { get; set; }

    object? IVisualElement.IsEnabled { get; set; }

    object? IVisualElement.AnchorX { get; set; }

    object? IVisualElement.AnchorY { get; set; }

    object? IVisualElement.TranslationX { get; set; }

    object? IVisualElement.TranslationY { get; set; }

    object? IVisualElement.Rotation { get; set; }

    object? IVisualElement.RotationX { get; set; }

    object? IVisualElement.RotationY { get; set; }

    object? IVisualElement.Scale { get; set; }

    object? IVisualElement.ScaleX { get; set; }

    object? IVisualElement.ScaleY { get; set; }

    object? IVisualElement.Visual { get; set; }

    object? IVisualElement.IsVisible { get; set; }

    object? IVisualElement.Opacity { get; set; }

    object? IVisualElement.BackgroundColor { get; set; }

    object? IVisualElement.Background { get; set; }

    object? IVisualElement.WidthRequest { get; set; }

    object? IVisualElement.HeightRequest { get; set; }

    object? IVisualElement.MinimumWidthRequest { get; set; }

    object? IVisualElement.MinimumHeightRequest { get; set; }

    object? IVisualElement.MaximumWidthRequest { get; set; }

    object? IVisualElement.MaximumHeightRequest { get; set; }

    object? IVisualElement.FlowDirection { get; set; }

    object? IVisualElement.ZIndex { get; set; }

    Action? IVisualElement.ChildrenReorderedAction { get; set; }

    Action<object?, EventArgs>? IVisualElement.ChildrenReorderedActionWithArgs { get; set; }

    Action? IVisualElement.FocusedAction { get; set; }

    Action<object?, FocusEventArgs>? IVisualElement.FocusedActionWithArgs { get; set; }

    Action? IVisualElement.MeasureInvalidatedAction { get; set; }

    Action<object?, EventArgs>? IVisualElement.MeasureInvalidatedActionWithArgs { get; set; }

    Action? IVisualElement.SizeChangedAction { get; set; }

    Action<object?, EventArgs>? IVisualElement.SizeChangedActionWithArgs { get; set; }

    Action? IVisualElement.UnfocusedAction { get; set; }

    Action<object?, FocusEventArgs>? IVisualElement.UnfocusedActionWithArgs { get; set; }

    Action? IVisualElement.LoadedAction { get; set; }

    Action<object?, EventArgs>? IVisualElement.LoadedActionWithArgs { get; set; }

    Action? IVisualElement.UnloadedAction { get; set; }

    Action<object?, EventArgs>? IVisualElement.UnloadedActionWithArgs { get; set; }

    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIVisualElement = (IVisualElement)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.InputTransparentProperty, thisAsIVisualElement.InputTransparent);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.IsEnabledProperty, thisAsIVisualElement.IsEnabled);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.AnchorXProperty, thisAsIVisualElement.AnchorX);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.AnchorYProperty, thisAsIVisualElement.AnchorY);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.TranslationXProperty, thisAsIVisualElement.TranslationX);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.TranslationYProperty, thisAsIVisualElement.TranslationY);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationProperty, thisAsIVisualElement.Rotation);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationXProperty, thisAsIVisualElement.RotationX);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.RotationYProperty, thisAsIVisualElement.RotationY);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ScaleProperty, thisAsIVisualElement.Scale);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ScaleXProperty, thisAsIVisualElement.ScaleX);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ScaleYProperty, thisAsIVisualElement.ScaleY);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.VisualProperty, thisAsIVisualElement.Visual);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.IsVisibleProperty, thisAsIVisualElement.IsVisible);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.OpacityProperty, thisAsIVisualElement.Opacity);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.BackgroundColorProperty, thisAsIVisualElement.BackgroundColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.BackgroundProperty, thisAsIVisualElement.Background);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.WidthRequestProperty, thisAsIVisualElement.WidthRequest);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.HeightRequestProperty, thisAsIVisualElement.HeightRequest);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MinimumWidthRequestProperty, thisAsIVisualElement.MinimumWidthRequest);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty, thisAsIVisualElement.MinimumHeightRequest);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MaximumWidthRequestProperty, thisAsIVisualElement.MaximumWidthRequest);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.MaximumHeightRequestProperty, thisAsIVisualElement.MaximumHeightRequest);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.FlowDirectionProperty, thisAsIVisualElement.FlowDirection);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.VisualElement.ZIndexProperty, thisAsIVisualElement.ZIndex);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (ThemeKey != null && VisualElementStyles.Themes.TryGetValue(ThemeKey, out var styleAction))
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
        var thisAsIVisualElement = (IVisualElement)this;
        if (thisAsIVisualElement.ChildrenReorderedAction != null || thisAsIVisualElement.ChildrenReorderedActionWithArgs != null)
        {
            NativeControl.ChildrenReordered += NativeControl_ChildrenReordered;
        }

        if (thisAsIVisualElement.FocusedAction != null || thisAsIVisualElement.FocusedActionWithArgs != null)
        {
            NativeControl.Focused += NativeControl_Focused;
        }

        if (thisAsIVisualElement.MeasureInvalidatedAction != null || thisAsIVisualElement.MeasureInvalidatedActionWithArgs != null)
        {
            NativeControl.MeasureInvalidated += NativeControl_MeasureInvalidated;
        }

        if (thisAsIVisualElement.SizeChangedAction != null || thisAsIVisualElement.SizeChangedActionWithArgs != null)
        {
            NativeControl.SizeChanged += NativeControl_SizeChanged;
        }

        if (thisAsIVisualElement.UnfocusedAction != null || thisAsIVisualElement.UnfocusedActionWithArgs != null)
        {
            NativeControl.Unfocused += NativeControl_Unfocused;
        }

        if (thisAsIVisualElement.LoadedAction != null || thisAsIVisualElement.LoadedActionWithArgs != null)
        {
            NativeControl.Loaded += NativeControl_Loaded;
        }

        if (thisAsIVisualElement.UnloadedAction != null || thisAsIVisualElement.UnloadedActionWithArgs != null)
        {
            NativeControl.Unloaded += NativeControl_Unloaded;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_ChildrenReordered(object? sender, EventArgs e)
    {
        var thisAsIVisualElement = (IVisualElement)this;
        thisAsIVisualElement.ChildrenReorderedAction?.Invoke();
        thisAsIVisualElement.ChildrenReorderedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_Focused(object? sender, FocusEventArgs e)
    {
        var thisAsIVisualElement = (IVisualElement)this;
        thisAsIVisualElement.FocusedAction?.Invoke();
        thisAsIVisualElement.FocusedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_MeasureInvalidated(object? sender, EventArgs e)
    {
        var thisAsIVisualElement = (IVisualElement)this;
        thisAsIVisualElement.MeasureInvalidatedAction?.Invoke();
        thisAsIVisualElement.MeasureInvalidatedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_SizeChanged(object? sender, EventArgs e)
    {
        var thisAsIVisualElement = (IVisualElement)this;
        thisAsIVisualElement.SizeChangedAction?.Invoke();
        thisAsIVisualElement.SizeChangedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_Unfocused(object? sender, FocusEventArgs e)
    {
        var thisAsIVisualElement = (IVisualElement)this;
        thisAsIVisualElement.UnfocusedAction?.Invoke();
        thisAsIVisualElement.UnfocusedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_Loaded(object? sender, EventArgs e)
    {
        var thisAsIVisualElement = (IVisualElement)this;
        thisAsIVisualElement.LoadedAction?.Invoke();
        thisAsIVisualElement.LoadedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_Unloaded(object? sender, EventArgs e)
    {
        var thisAsIVisualElement = (IVisualElement)this;
        thisAsIVisualElement.UnloadedAction?.Invoke();
        thisAsIVisualElement.UnloadedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.ChildrenReordered -= NativeControl_ChildrenReordered;
            NativeControl.Focused -= NativeControl_Focused;
            NativeControl.MeasureInvalidated -= NativeControl_MeasureInvalidated;
            NativeControl.SizeChanged -= NativeControl_SizeChanged;
            NativeControl.Unfocused -= NativeControl_Unfocused;
            NativeControl.Loaded -= NativeControl_Loaded;
            NativeControl.Unloaded -= NativeControl_Unloaded;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public static partial class VisualElementExtensions
{
    static object? SetAnchorX(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).AnchorX = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetAnchorY(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).AnchorY = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetTranslationX(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).TranslationX = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetTranslationY(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).TranslationY = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetRotation(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).Rotation = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetRotationX(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).RotationX = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetRotationY(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).RotationY = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetScale(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).Scale = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetScaleX(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).ScaleX = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetScaleY(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).ScaleY = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetOpacity(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).Opacity = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetWidthRequest(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).WidthRequest = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetHeightRequest(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).HeightRequest = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetMinimumWidthRequest(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).MinimumWidthRequest = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetMinimumHeightRequest(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).MinimumHeightRequest = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetMaximumWidthRequest(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).MaximumWidthRequest = ((RxDoubleAnimation)animation).CurrentValue();
    static object? SetMaximumHeightRequest(object visualElement, RxAnimation animation) => ((IVisualElement)visualElement).MaximumHeightRequest = ((RxDoubleAnimation)animation).CurrentValue();
    public static T InputTransparent<T>(this T visualElement, bool inputTransparent)
        where T : IVisualElement
    {
        visualElement.InputTransparent = inputTransparent;
        return visualElement;
    }

    public static T InputTransparent<T>(this T visualElement, Func<bool> inputTransparentFunc)
        where T : IVisualElement
    {
        visualElement.InputTransparent = new PropertyValue<bool>(inputTransparentFunc);
        return visualElement;
    }

    public static T IsEnabled<T>(this T visualElement, bool isEnabled)
        where T : IVisualElement
    {
        visualElement.IsEnabled = isEnabled;
        return visualElement;
    }

    public static T IsEnabled<T>(this T visualElement, Func<bool> isEnabledFunc)
        where T : IVisualElement
    {
        visualElement.IsEnabled = new PropertyValue<bool>(isEnabledFunc);
        return visualElement;
    }

    public static T AnchorX<T>(this T visualElement, double anchorX, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.AnchorX = anchorX;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.AnchorXProperty, customAnimation ?? new RxDoubleAnimation(anchorX), SetAnchorX);
        return visualElement;
    }

    public static T AnchorX<T>(this T visualElement, Func<double> anchorXFunc)
        where T : IVisualElement
    {
        visualElement.AnchorX = new PropertyValue<double>(anchorXFunc);
        return visualElement;
    }

    public static T AnchorY<T>(this T visualElement, double anchorY, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.AnchorY = anchorY;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.AnchorYProperty, customAnimation ?? new RxDoubleAnimation(anchorY), SetAnchorY);
        return visualElement;
    }

    public static T AnchorY<T>(this T visualElement, Func<double> anchorYFunc)
        where T : IVisualElement
    {
        visualElement.AnchorY = new PropertyValue<double>(anchorYFunc);
        return visualElement;
    }

    public static T TranslationX<T>(this T visualElement, double translationX, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.TranslationX = translationX;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.TranslationXProperty, customAnimation ?? new RxDoubleAnimation(translationX), SetTranslationX);
        return visualElement;
    }

    public static T TranslationX<T>(this T visualElement, Func<double> translationXFunc)
        where T : IVisualElement
    {
        visualElement.TranslationX = new PropertyValue<double>(translationXFunc);
        return visualElement;
    }

    public static T TranslationY<T>(this T visualElement, double translationY, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.TranslationY = translationY;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.TranslationYProperty, customAnimation ?? new RxDoubleAnimation(translationY), SetTranslationY);
        return visualElement;
    }

    public static T TranslationY<T>(this T visualElement, Func<double> translationYFunc)
        where T : IVisualElement
    {
        visualElement.TranslationY = new PropertyValue<double>(translationYFunc);
        return visualElement;
    }

    public static T Rotation<T>(this T visualElement, double rotation, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.Rotation = rotation;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.RotationProperty, customAnimation ?? new RxDoubleAnimation(rotation), SetRotation);
        return visualElement;
    }

    public static T Rotation<T>(this T visualElement, Func<double> rotationFunc)
        where T : IVisualElement
    {
        visualElement.Rotation = new PropertyValue<double>(rotationFunc);
        return visualElement;
    }

    public static T RotationX<T>(this T visualElement, double rotationX, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.RotationX = rotationX;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.RotationXProperty, customAnimation ?? new RxDoubleAnimation(rotationX), SetRotationX);
        return visualElement;
    }

    public static T RotationX<T>(this T visualElement, Func<double> rotationXFunc)
        where T : IVisualElement
    {
        visualElement.RotationX = new PropertyValue<double>(rotationXFunc);
        return visualElement;
    }

    public static T RotationY<T>(this T visualElement, double rotationY, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.RotationY = rotationY;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.RotationYProperty, customAnimation ?? new RxDoubleAnimation(rotationY), SetRotationY);
        return visualElement;
    }

    public static T RotationY<T>(this T visualElement, Func<double> rotationYFunc)
        where T : IVisualElement
    {
        visualElement.RotationY = new PropertyValue<double>(rotationYFunc);
        return visualElement;
    }

    public static T Scale<T>(this T visualElement, double scale, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.Scale = scale;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.ScaleProperty, customAnimation ?? new RxDoubleAnimation(scale), SetScale);
        return visualElement;
    }

    public static T Scale<T>(this T visualElement, Func<double> scaleFunc)
        where T : IVisualElement
    {
        visualElement.Scale = new PropertyValue<double>(scaleFunc);
        return visualElement;
    }

    public static T ScaleX<T>(this T visualElement, double scaleX, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.ScaleX = scaleX;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.ScaleXProperty, customAnimation ?? new RxDoubleAnimation(scaleX), SetScaleX);
        return visualElement;
    }

    public static T ScaleX<T>(this T visualElement, Func<double> scaleXFunc)
        where T : IVisualElement
    {
        visualElement.ScaleX = new PropertyValue<double>(scaleXFunc);
        return visualElement;
    }

    public static T ScaleY<T>(this T visualElement, double scaleY, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.ScaleY = scaleY;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.ScaleYProperty, customAnimation ?? new RxDoubleAnimation(scaleY), SetScaleY);
        return visualElement;
    }

    public static T ScaleY<T>(this T visualElement, Func<double> scaleYFunc)
        where T : IVisualElement
    {
        visualElement.ScaleY = new PropertyValue<double>(scaleYFunc);
        return visualElement;
    }

    public static T Visual<T>(this T visualElement, Microsoft.Maui.Controls.IVisual visual)
        where T : IVisualElement
    {
        visualElement.Visual = visual;
        return visualElement;
    }

    public static T Visual<T>(this T visualElement, Func<Microsoft.Maui.Controls.IVisual> visualFunc)
        where T : IVisualElement
    {
        visualElement.Visual = new PropertyValue<Microsoft.Maui.Controls.IVisual>(visualFunc);
        return visualElement;
    }

    public static T IsVisible<T>(this T visualElement, bool isVisible)
        where T : IVisualElement
    {
        visualElement.IsVisible = isVisible;
        return visualElement;
    }

    public static T IsVisible<T>(this T visualElement, Func<bool> isVisibleFunc)
        where T : IVisualElement
    {
        visualElement.IsVisible = new PropertyValue<bool>(isVisibleFunc);
        return visualElement;
    }

    public static T Opacity<T>(this T visualElement, double opacity, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.Opacity = opacity;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.OpacityProperty, customAnimation ?? new RxDoubleAnimation(opacity), SetOpacity);
        return visualElement;
    }

    public static T Opacity<T>(this T visualElement, Func<double> opacityFunc)
        where T : IVisualElement
    {
        visualElement.Opacity = new PropertyValue<double>(opacityFunc);
        return visualElement;
    }

    public static T BackgroundColor<T>(this T visualElement, Microsoft.Maui.Graphics.Color backgroundColor)
        where T : IVisualElement
    {
        visualElement.BackgroundColor = backgroundColor;
        return visualElement;
    }

    public static T BackgroundColor<T>(this T visualElement, Func<Microsoft.Maui.Graphics.Color> backgroundColorFunc)
        where T : IVisualElement
    {
        visualElement.BackgroundColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(backgroundColorFunc);
        return visualElement;
    }

    public static T Background<T>(this T visualElement, Microsoft.Maui.Controls.Brush background)
        where T : IVisualElement
    {
        visualElement.Background = background;
        return visualElement;
    }

    public static T Background<T>(this T visualElement, Func<Microsoft.Maui.Controls.Brush> backgroundFunc)
        where T : IVisualElement
    {
        visualElement.Background = new PropertyValue<Microsoft.Maui.Controls.Brush>(backgroundFunc);
        return visualElement;
    }

    public static T WidthRequest<T>(this T visualElement, double widthRequest, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.WidthRequest = widthRequest;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.WidthRequestProperty, customAnimation ?? new RxDoubleAnimation(widthRequest), SetWidthRequest);
        return visualElement;
    }

    public static T WidthRequest<T>(this T visualElement, Func<double> widthRequestFunc)
        where T : IVisualElement
    {
        visualElement.WidthRequest = new PropertyValue<double>(widthRequestFunc);
        return visualElement;
    }

    public static T HeightRequest<T>(this T visualElement, double heightRequest, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.HeightRequest = heightRequest;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.HeightRequestProperty, customAnimation ?? new RxDoubleAnimation(heightRequest), SetHeightRequest);
        return visualElement;
    }

    public static T HeightRequest<T>(this T visualElement, Func<double> heightRequestFunc)
        where T : IVisualElement
    {
        visualElement.HeightRequest = new PropertyValue<double>(heightRequestFunc);
        return visualElement;
    }

    public static T MinimumWidthRequest<T>(this T visualElement, double minimumWidthRequest, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.MinimumWidthRequest = minimumWidthRequest;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MinimumWidthRequestProperty, customAnimation ?? new RxDoubleAnimation(minimumWidthRequest), SetMinimumWidthRequest);
        return visualElement;
    }

    public static T MinimumWidthRequest<T>(this T visualElement, Func<double> minimumWidthRequestFunc)
        where T : IVisualElement
    {
        visualElement.MinimumWidthRequest = new PropertyValue<double>(minimumWidthRequestFunc);
        return visualElement;
    }

    public static T MinimumHeightRequest<T>(this T visualElement, double minimumHeightRequest, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.MinimumHeightRequest = minimumHeightRequest;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MinimumHeightRequestProperty, customAnimation ?? new RxDoubleAnimation(minimumHeightRequest), SetMinimumHeightRequest);
        return visualElement;
    }

    public static T MinimumHeightRequest<T>(this T visualElement, Func<double> minimumHeightRequestFunc)
        where T : IVisualElement
    {
        visualElement.MinimumHeightRequest = new PropertyValue<double>(minimumHeightRequestFunc);
        return visualElement;
    }

    public static T MaximumWidthRequest<T>(this T visualElement, double maximumWidthRequest, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.MaximumWidthRequest = maximumWidthRequest;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MaximumWidthRequestProperty, customAnimation ?? new RxDoubleAnimation(maximumWidthRequest), SetMaximumWidthRequest);
        return visualElement;
    }

    public static T MaximumWidthRequest<T>(this T visualElement, Func<double> maximumWidthRequestFunc)
        where T : IVisualElement
    {
        visualElement.MaximumWidthRequest = new PropertyValue<double>(maximumWidthRequestFunc);
        return visualElement;
    }

    public static T MaximumHeightRequest<T>(this T visualElement, double maximumHeightRequest, RxDoubleAnimation? customAnimation = null)
        where T : IVisualElement
    {
        visualElement.MaximumHeightRequest = maximumHeightRequest;
        visualElement.AppendAnimatable(Microsoft.Maui.Controls.VisualElement.MaximumHeightRequestProperty, customAnimation ?? new RxDoubleAnimation(maximumHeightRequest), SetMaximumHeightRequest);
        return visualElement;
    }

    public static T MaximumHeightRequest<T>(this T visualElement, Func<double> maximumHeightRequestFunc)
        where T : IVisualElement
    {
        visualElement.MaximumHeightRequest = new PropertyValue<double>(maximumHeightRequestFunc);
        return visualElement;
    }

    public static T FlowDirection<T>(this T visualElement, Microsoft.Maui.FlowDirection flowDirection)
        where T : IVisualElement
    {
        visualElement.FlowDirection = flowDirection;
        return visualElement;
    }

    public static T FlowDirection<T>(this T visualElement, Func<Microsoft.Maui.FlowDirection> flowDirectionFunc)
        where T : IVisualElement
    {
        visualElement.FlowDirection = new PropertyValue<Microsoft.Maui.FlowDirection>(flowDirectionFunc);
        return visualElement;
    }

    public static T ZIndex<T>(this T visualElement, int zIndex)
        where T : IVisualElement
    {
        visualElement.ZIndex = zIndex;
        return visualElement;
    }

    public static T ZIndex<T>(this T visualElement, Func<int> zIndexFunc)
        where T : IVisualElement
    {
        visualElement.ZIndex = new PropertyValue<int>(zIndexFunc);
        return visualElement;
    }

    public static T OnChildrenReordered<T>(this T visualElement, Action? childrenReorderedAction)
        where T : IVisualElement
    {
        visualElement.ChildrenReorderedAction = childrenReorderedAction;
        return visualElement;
    }

    public static T OnChildrenReordered<T>(this T visualElement, Action<object?, EventArgs>? childrenReorderedActionWithArgs)
        where T : IVisualElement
    {
        visualElement.ChildrenReorderedActionWithArgs = childrenReorderedActionWithArgs;
        return visualElement;
    }

    public static T OnFocused<T>(this T visualElement, Action? focusedAction)
        where T : IVisualElement
    {
        visualElement.FocusedAction = focusedAction;
        return visualElement;
    }

    public static T OnFocused<T>(this T visualElement, Action<object?, FocusEventArgs>? focusedActionWithArgs)
        where T : IVisualElement
    {
        visualElement.FocusedActionWithArgs = focusedActionWithArgs;
        return visualElement;
    }

    public static T OnMeasureInvalidated<T>(this T visualElement, Action? measureInvalidatedAction)
        where T : IVisualElement
    {
        visualElement.MeasureInvalidatedAction = measureInvalidatedAction;
        return visualElement;
    }

    public static T OnMeasureInvalidated<T>(this T visualElement, Action<object?, EventArgs>? measureInvalidatedActionWithArgs)
        where T : IVisualElement
    {
        visualElement.MeasureInvalidatedActionWithArgs = measureInvalidatedActionWithArgs;
        return visualElement;
    }

    public static T OnSizeChanged<T>(this T visualElement, Action? sizeChangedAction)
        where T : IVisualElement
    {
        visualElement.SizeChangedAction = sizeChangedAction;
        return visualElement;
    }

    public static T OnSizeChanged<T>(this T visualElement, Action<object?, EventArgs>? sizeChangedActionWithArgs)
        where T : IVisualElement
    {
        visualElement.SizeChangedActionWithArgs = sizeChangedActionWithArgs;
        return visualElement;
    }

    public static T OnUnfocused<T>(this T visualElement, Action? unfocusedAction)
        where T : IVisualElement
    {
        visualElement.UnfocusedAction = unfocusedAction;
        return visualElement;
    }

    public static T OnUnfocused<T>(this T visualElement, Action<object?, FocusEventArgs>? unfocusedActionWithArgs)
        where T : IVisualElement
    {
        visualElement.UnfocusedActionWithArgs = unfocusedActionWithArgs;
        return visualElement;
    }

    public static T OnLoaded<T>(this T visualElement, Action? loadedAction)
        where T : IVisualElement
    {
        visualElement.LoadedAction = loadedAction;
        return visualElement;
    }

    public static T OnLoaded<T>(this T visualElement, Action<object?, EventArgs>? loadedActionWithArgs)
        where T : IVisualElement
    {
        visualElement.LoadedActionWithArgs = loadedActionWithArgs;
        return visualElement;
    }

    public static T OnUnloaded<T>(this T visualElement, Action? unloadedAction)
        where T : IVisualElement
    {
        visualElement.UnloadedAction = unloadedAction;
        return visualElement;
    }

    public static T OnUnloaded<T>(this T visualElement, Action<object?, EventArgs>? unloadedActionWithArgs)
        where T : IVisualElement
    {
        visualElement.UnloadedActionWithArgs = unloadedActionWithArgs;
        return visualElement;
    }
}

public static partial class VisualElementStyles
{
    public static Action<IVisualElement>? Default { get; set; }
    public static Dictionary<string, Action<IVisualElement>> Themes { get; } = [];
}