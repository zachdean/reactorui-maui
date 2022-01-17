﻿using MauiReactor.Internals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiReactor
{
    public partial class ContentPage<T> : TemplatedPage<T>, IContentPage where T : Microsoft.Maui.Controls.ContentPage, new()
    {
        public ContentPage(string title)
            : base(title)
        {

        }
    }

    public partial class ContentPage
    {
        public ContentPage(string title)
            : base(title)
        {

        }

        public ContentPage(VisualNode content)
        {
            _internalChildren.Add(content);
        }

        protected override void OnAddChild(VisualNode widget, BindableObject childControl)
        {
            Validate.EnsureNotNull(NativeControl);

            if (childControl is View view)
                NativeControl.Content = view;
            else if (childControl is ToolbarItem toolbarItem)
                NativeControl.ToolbarItems.Add(toolbarItem);

            base.OnAddChild(widget, childControl);
        }

        protected override void OnRemoveChild(VisualNode widget, BindableObject childControl)
        {
            Validate.EnsureNotNull(NativeControl);

            if (childControl is View)
                NativeControl.Content = null;
            else if (childControl is ToolbarItem toolbarItem)
                NativeControl.ToolbarItems.Remove(toolbarItem);

            base.OnRemoveChild(widget, childControl);
        }

    }
}
