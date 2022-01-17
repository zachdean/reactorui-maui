using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor
{
    public partial interface IView : IVisualElement
    {
        PropertyValue<Microsoft.Maui.Thickness>? Margin { get; set; }


    }
    public abstract partial class View<T> : VisualElement<T>, IView where T : Microsoft.Maui.Controls.View, new()
    {
        protected View()
        {

        }

        protected View(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Thickness>? IView.Margin { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsIView = (IView)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.View.MarginProperty, thisAsIView.Margin);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class ViewExtensions
    {
        public static T Margin<T>(this T view, Microsoft.Maui.Thickness margin) where T : IView
        {
            view.Margin = new PropertyValue<Microsoft.Maui.Thickness>(margin);
            return view;
        }
        public static T Margin<T>(this T view, Func<Microsoft.Maui.Thickness> marginFunc) where T : IView
        {
            view.Margin = new PropertyValue<Microsoft.Maui.Thickness>(marginFunc);
            return view;
        }
        public static T Margin<T>(this T view, double leftRight, double topBottom) where T : IView
        {
            view.Margin = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(leftRight, topBottom));
            return view;
        }
        public static T Margin<T>(this T view, double uniformSize) where T : IView
        {
            view.Margin = new PropertyValue<Microsoft.Maui.Thickness>(new Thickness(uniformSize));
            return view;
        }




    }
}
