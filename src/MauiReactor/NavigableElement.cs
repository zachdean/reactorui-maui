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
    public partial interface INavigableElement : IElement
    {
        PropertyValue<Microsoft.Maui.Controls.Style>? Style { get; set; }


    }
    public abstract partial class NavigableElement<T> : Element<T>, INavigableElement where T : Microsoft.Maui.Controls.NavigableElement, new()
    {
        protected NavigableElement()
        {

        }

        protected NavigableElement(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }

        PropertyValue<Microsoft.Maui.Controls.Style>? INavigableElement.Style { get; set; }


        protected override void OnUpdate()
        {
            OnBeginUpdate();

            Validate.EnsureNotNull(NativeControl);
            var thisAsINavigableElement = (INavigableElement)this;
            SetPropertyValue(NativeControl, Microsoft.Maui.Controls.NavigableElement.StyleProperty, thisAsINavigableElement.Style);


            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }


    public static partial class NavigableElementExtensions
    {
        public static T Style<T>(this T navigableelement, Microsoft.Maui.Controls.Style style) where T : INavigableElement
        {
            navigableelement.Style = new PropertyValue<Microsoft.Maui.Controls.Style>(style);
            return navigableelement;
        }
        public static T Style<T>(this T navigableelement, Func<Microsoft.Maui.Controls.Style> styleFunc) where T : INavigableElement
        {
            navigableelement.Style = new PropertyValue<Microsoft.Maui.Controls.Style>(styleFunc);
            return navigableelement;
        }




    }
}
