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
public partial interface ILabel : IView
{
    object? HorizontalTextAlignment { get; set; }

    object? VerticalTextAlignment { get; set; }

    object? TextColor { get; set; }

    object? CharacterSpacing { get; set; }

    object? Text { get; set; }

    object? FontFamily { get; set; }

    object? FontSize { get; set; }

    object? FontAttributes { get; set; }

    object? FontAutoScalingEnabled { get; set; }

    object? TextTransform { get; set; }

    object? TextDecorations { get; set; }

    object? FormattedText { get; set; }

    object? LineBreakMode { get; set; }

    object? LineHeight { get; set; }

    object? MaxLines { get; set; }

    object? Padding { get; set; }

    object? TextType { get; set; }
}

public partial class Label<T> : View<T>, ILabel where T : Microsoft.Maui.Controls.Label, new()
{
    public Label()
    {
    }

    public Label(Action<T?> componentRefAction) : base(componentRefAction)
    {
    }

    object? ILabel.HorizontalTextAlignment { get; set; }

    object? ILabel.VerticalTextAlignment { get; set; }

    object? ILabel.TextColor { get; set; }

    object? ILabel.CharacterSpacing { get; set; }

    object? ILabel.Text { get; set; }

    object? ILabel.FontFamily { get; set; }

    object? ILabel.FontSize { get; set; }

    object? ILabel.FontAttributes { get; set; }

    object? ILabel.FontAutoScalingEnabled { get; set; }

    object? ILabel.TextTransform { get; set; }

    object? ILabel.TextDecorations { get; set; }

    object? ILabel.FormattedText { get; set; }

    object? ILabel.LineBreakMode { get; set; }

    object? ILabel.LineHeight { get; set; }

    object? ILabel.MaxLines { get; set; }

    object? ILabel.Padding { get; set; }

    object? ILabel.TextType { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsILabel = (ILabel)this;
        thisAsILabel.HorizontalTextAlignment = null;
        thisAsILabel.VerticalTextAlignment = null;
        thisAsILabel.TextColor = null;
        thisAsILabel.CharacterSpacing = null;
        thisAsILabel.Text = null;
        thisAsILabel.FontFamily = null;
        thisAsILabel.FontSize = null;
        thisAsILabel.FontAttributes = null;
        thisAsILabel.FontAutoScalingEnabled = null;
        thisAsILabel.TextTransform = null;
        thisAsILabel.TextDecorations = null;
        thisAsILabel.FormattedText = null;
        thisAsILabel.LineBreakMode = null;
        thisAsILabel.LineHeight = null;
        thisAsILabel.MaxLines = null;
        thisAsILabel.Padding = null;
        thisAsILabel.TextType = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsILabel = (ILabel)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.HorizontalTextAlignmentProperty, thisAsILabel.HorizontalTextAlignment);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.VerticalTextAlignmentProperty, thisAsILabel.VerticalTextAlignment);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.TextColorProperty, thisAsILabel.TextColor);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.CharacterSpacingProperty, thisAsILabel.CharacterSpacing);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.TextProperty, thisAsILabel.Text);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.FontFamilyProperty, thisAsILabel.FontFamily);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.FontSizeProperty, thisAsILabel.FontSize);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.FontAttributesProperty, thisAsILabel.FontAttributes);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.FontAutoScalingEnabledProperty, thisAsILabel.FontAutoScalingEnabled);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.TextTransformProperty, thisAsILabel.TextTransform);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.TextDecorationsProperty, thisAsILabel.TextDecorations);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.FormattedTextProperty, thisAsILabel.FormattedText);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.LineBreakModeProperty, thisAsILabel.LineBreakMode);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.LineHeightProperty, thisAsILabel.LineHeight);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.MaxLinesProperty, thisAsILabel.MaxLines);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.PaddingProperty, thisAsILabel.Padding);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Label.TextTypeProperty, thisAsILabel.TextType);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsILabel = (ILabel)this;
        AnimateProperty(Microsoft.Maui.Controls.Label.CharacterSpacingProperty, thisAsILabel.CharacterSpacing);
        AnimateProperty(Microsoft.Maui.Controls.Label.FontSizeProperty, thisAsILabel.FontSize);
        AnimateProperty(Microsoft.Maui.Controls.Label.LineHeightProperty, thisAsILabel.LineHeight);
        AnimateProperty(Microsoft.Maui.Controls.Label.PaddingProperty, thisAsILabel.Padding);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
}

public partial class Label : Label<Microsoft.Maui.Controls.Label>
{
    public Label()
    {
    }

    public Label(Action<Microsoft.Maui.Controls.Label?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class LabelExtensions
{
    public static T HorizontalTextAlignment<T>(this T label, Microsoft.Maui.TextAlignment horizontalTextAlignment)
        where T : ILabel
    {
        label.HorizontalTextAlignment = horizontalTextAlignment;
        return label;
    }

    public static T HorizontalTextAlignment<T>(this T label, Func<Microsoft.Maui.TextAlignment> horizontalTextAlignmentFunc)
        where T : ILabel
    {
        label.HorizontalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(horizontalTextAlignmentFunc);
        return label;
    }

    public static T VerticalTextAlignment<T>(this T label, Microsoft.Maui.TextAlignment verticalTextAlignment)
        where T : ILabel
    {
        label.VerticalTextAlignment = verticalTextAlignment;
        return label;
    }

    public static T VerticalTextAlignment<T>(this T label, Func<Microsoft.Maui.TextAlignment> verticalTextAlignmentFunc)
        where T : ILabel
    {
        label.VerticalTextAlignment = new PropertyValue<Microsoft.Maui.TextAlignment>(verticalTextAlignmentFunc);
        return label;
    }

    public static T TextColor<T>(this T label, Microsoft.Maui.Graphics.Color textColor)
        where T : ILabel
    {
        label.TextColor = textColor;
        return label;
    }

    public static T TextColor<T>(this T label, Func<Microsoft.Maui.Graphics.Color> textColorFunc)
        where T : ILabel
    {
        label.TextColor = new PropertyValue<Microsoft.Maui.Graphics.Color>(textColorFunc);
        return label;
    }

    public static T CharacterSpacing<T>(this T label, double characterSpacing, RxDoubleAnimation? customAnimation = null)
        where T : ILabel
    {
        label.CharacterSpacing = characterSpacing;
        label.AppendAnimatable(Microsoft.Maui.Controls.Label.CharacterSpacingProperty, customAnimation ?? new RxDoubleAnimation(characterSpacing), v => label.CharacterSpacing = new PropertyValue<double>(v.CurrentValue()));
        return label;
    }

    public static T CharacterSpacing<T>(this T label, Func<double> characterSpacingFunc)
        where T : ILabel
    {
        label.CharacterSpacing = new PropertyValue<double>(characterSpacingFunc);
        return label;
    }

    public static T Text<T>(this T label, string text)
        where T : ILabel
    {
        label.Text = text;
        return label;
    }

    public static T Text<T>(this T label, Func<string> textFunc)
        where T : ILabel
    {
        label.Text = new PropertyValue<string>(textFunc);
        return label;
    }

    public static T FontFamily<T>(this T label, string fontFamily)
        where T : ILabel
    {
        label.FontFamily = fontFamily;
        return label;
    }

    public static T FontFamily<T>(this T label, Func<string> fontFamilyFunc)
        where T : ILabel
    {
        label.FontFamily = new PropertyValue<string>(fontFamilyFunc);
        return label;
    }

    public static T FontSize<T>(this T label, double fontSize, RxDoubleAnimation? customAnimation = null)
        where T : ILabel
    {
        label.FontSize = fontSize;
        label.AppendAnimatable(Microsoft.Maui.Controls.Label.FontSizeProperty, customAnimation ?? new RxDoubleAnimation(fontSize), v => label.FontSize = new PropertyValue<double>(v.CurrentValue()));
        return label;
    }

    public static T FontSize<T>(this T label, Func<double> fontSizeFunc)
        where T : ILabel
    {
        label.FontSize = new PropertyValue<double>(fontSizeFunc);
        return label;
    }

    public static T FontAttributes<T>(this T label, Microsoft.Maui.Controls.FontAttributes fontAttributes)
        where T : ILabel
    {
        label.FontAttributes = fontAttributes;
        return label;
    }

    public static T FontAttributes<T>(this T label, Func<Microsoft.Maui.Controls.FontAttributes> fontAttributesFunc)
        where T : ILabel
    {
        label.FontAttributes = new PropertyValue<Microsoft.Maui.Controls.FontAttributes>(fontAttributesFunc);
        return label;
    }

    public static T FontAutoScalingEnabled<T>(this T label, bool fontAutoScalingEnabled)
        where T : ILabel
    {
        label.FontAutoScalingEnabled = fontAutoScalingEnabled;
        return label;
    }

    public static T FontAutoScalingEnabled<T>(this T label, Func<bool> fontAutoScalingEnabledFunc)
        where T : ILabel
    {
        label.FontAutoScalingEnabled = new PropertyValue<bool>(fontAutoScalingEnabledFunc);
        return label;
    }

    public static T TextTransform<T>(this T label, Microsoft.Maui.TextTransform textTransform)
        where T : ILabel
    {
        label.TextTransform = textTransform;
        return label;
    }

    public static T TextTransform<T>(this T label, Func<Microsoft.Maui.TextTransform> textTransformFunc)
        where T : ILabel
    {
        label.TextTransform = new PropertyValue<Microsoft.Maui.TextTransform>(textTransformFunc);
        return label;
    }

    public static T TextDecorations<T>(this T label, Microsoft.Maui.TextDecorations textDecorations)
        where T : ILabel
    {
        label.TextDecorations = textDecorations;
        return label;
    }

    public static T TextDecorations<T>(this T label, Func<Microsoft.Maui.TextDecorations> textDecorationsFunc)
        where T : ILabel
    {
        label.TextDecorations = new PropertyValue<Microsoft.Maui.TextDecorations>(textDecorationsFunc);
        return label;
    }

    public static T FormattedText<T>(this T label, Microsoft.Maui.Controls.FormattedString formattedText)
        where T : ILabel
    {
        label.FormattedText = formattedText;
        return label;
    }

    public static T FormattedText<T>(this T label, Func<Microsoft.Maui.Controls.FormattedString> formattedTextFunc)
        where T : ILabel
    {
        label.FormattedText = new PropertyValue<Microsoft.Maui.Controls.FormattedString>(formattedTextFunc);
        return label;
    }

    public static T LineBreakMode<T>(this T label, Microsoft.Maui.LineBreakMode lineBreakMode)
        where T : ILabel
    {
        label.LineBreakMode = lineBreakMode;
        return label;
    }

    public static T LineBreakMode<T>(this T label, Func<Microsoft.Maui.LineBreakMode> lineBreakModeFunc)
        where T : ILabel
    {
        label.LineBreakMode = new PropertyValue<Microsoft.Maui.LineBreakMode>(lineBreakModeFunc);
        return label;
    }

    public static T LineHeight<T>(this T label, double lineHeight, RxDoubleAnimation? customAnimation = null)
        where T : ILabel
    {
        label.LineHeight = lineHeight;
        label.AppendAnimatable(Microsoft.Maui.Controls.Label.LineHeightProperty, customAnimation ?? new RxDoubleAnimation(lineHeight), v => label.LineHeight = new PropertyValue<double>(v.CurrentValue()));
        return label;
    }

    public static T LineHeight<T>(this T label, Func<double> lineHeightFunc)
        where T : ILabel
    {
        label.LineHeight = new PropertyValue<double>(lineHeightFunc);
        return label;
    }

    public static T MaxLines<T>(this T label, int maxLines)
        where T : ILabel
    {
        label.MaxLines = maxLines;
        return label;
    }

    public static T MaxLines<T>(this T label, Func<int> maxLinesFunc)
        where T : ILabel
    {
        label.MaxLines = new PropertyValue<int>(maxLinesFunc);
        return label;
    }

    public static T Padding<T>(this T label, Microsoft.Maui.Thickness padding, RxThicknessAnimation? customAnimation = null)
        where T : ILabel
    {
        label.Padding = padding;
        label.AppendAnimatable(Microsoft.Maui.Controls.Label.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(padding), v => label.Padding = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
        return label;
    }

    public static T Padding<T>(this T label, Func<Microsoft.Maui.Thickness> paddingFunc)
        where T : ILabel
    {
        label.Padding = new PropertyValue<Microsoft.Maui.Thickness>(paddingFunc);
        return label;
    }

    public static T Padding<T>(this T label, double leftRight, double topBottom, RxThicknessAnimation? customAnimation = null)
        where T : ILabel
    {
        label.Padding = new Thickness(leftRight, topBottom);
        label.AppendAnimatable(Microsoft.Maui.Controls.Label.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(leftRight, topBottom)), v => label.Padding = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
        return label;
    }

    public static T Padding<T>(this T label, double uniformSize, RxThicknessAnimation? customAnimation = null)
        where T : ILabel
    {
        label.Padding = new Thickness(uniformSize);
        label.AppendAnimatable(Microsoft.Maui.Controls.Label.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(uniformSize)), v => label.Padding = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
        return label;
    }

    public static T Padding<T>(this T label, double left, double top, double right, double bottom, RxThicknessAnimation? customAnimation = null)
        where T : ILabel
    {
        label.Padding = new Thickness(left, top, right, bottom);
        label.AppendAnimatable(Microsoft.Maui.Controls.Label.PaddingProperty, customAnimation ?? new RxSimpleThicknessAnimation(new Thickness(left, top, right, bottom)), v => label.Padding = new PropertyValue<Microsoft.Maui.Thickness>(v.CurrentValue()));
        return label;
    }

    public static T TextType<T>(this T label, Microsoft.Maui.TextType textType)
        where T : ILabel
    {
        label.TextType = textType;
        return label;
    }

    public static T TextType<T>(this T label, Func<Microsoft.Maui.TextType> textTypeFunc)
        where T : ILabel
    {
        label.TextType = new PropertyValue<Microsoft.Maui.TextType>(textTypeFunc);
        return label;
    }
}