using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor.Shapes
{
    public partial interface IGeometry : IVisualNode
    {


    }
    public abstract partial class Geometry<T> : VisualNode<T>, IGeometry where T : Microsoft.Maui.Controls.Shapes.Geometry, new()
    {
        protected Geometry()
        {

        }

        protected Geometry(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }



        protected override void OnUpdate()
        {
            OnBeginUpdate();

            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class GeometryExtensions
    {

    }
}
