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
public partial interface IPath : Shapes.IShape
{
    object? RenderTransform { get; set; }
}

public sealed partial class Path : Shapes.Shape<Microsoft.Maui.Controls.Shapes.Path>, IPath
{
    public Path()
    {
    }

    public Path(Action<Microsoft.Maui.Controls.Shapes.Path?> componentRefAction) : base(componentRefAction)
    {
    }

    object? IPath.RenderTransform { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIPath = (IPath)this;
        thisAsIPath.RenderTransform = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIPath = (IPath)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Path.RenderTransformProperty, thisAsIPath.RenderTransform);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
}

public static partial class PathExtensions
{
    public static T RenderTransform<T>(this T path, Microsoft.Maui.Controls.Shapes.Transform renderTransform)
        where T : IPath
    {
        path.RenderTransform = renderTransform;
        return path;
    }

    public static T RenderTransform<T>(this T path, Func<Microsoft.Maui.Controls.Shapes.Transform> renderTransformFunc)
        where T : IPath
    {
        path.RenderTransform = new PropertyValue<Microsoft.Maui.Controls.Shapes.Transform>(renderTransformFunc);
        return path;
    }
}