﻿using FullControls.Core;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FullControls.Controls
{
    /// <summary>
    /// Represents a pop-up menu that enables a control to expose functionality that is specific to the context of the control.
    /// </summary>
    public class FlatContextMenu : ContextMenu
    {
        /// <summary>
        /// Gets or sets the style of the <see cref="ScrollViewer"/> of the menu.
        /// </summary>
        public Style ScrollViewerStyle
        {
            get => (Style)GetValue(ScrollViewerStyleProperty);
            set => SetValue(ScrollViewerStyleProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ScrollViewerStyle"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ScrollViewerStyleProperty =
            DependencyProperty.Register(nameof(ScrollViewerStyle), typeof(Style), typeof(FlatContextMenu));

        #region Shadow

        /// <summary>
        /// Gets or sets the color of the menu popup shadow.
        /// </summary>
        public Color ShadowColor
        {
            get => (Color)GetValue(ShadowColorProperty);
            set => SetValue(ShadowColorProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ShadowColor"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.Register(nameof(ShadowColor), typeof(Color), typeof(FlatContextMenu));

        /// <summary>
        /// Gets or sets the opacity of the menu popup shadow.
        /// </summary>
        public double ShadowOpacity
        {
            get => (double)GetValue(ShadowOpacityProperty);
            set => SetValue(ShadowOpacityProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ShadowOpacity"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ShadowOpacityProperty =
            DependencyProperty.Register(nameof(ShadowOpacity), typeof(double), typeof(FlatContextMenu));

        /// <summary>
        /// Gets or sets the radius of the menu popup shadow.
        /// </summary>
        public double ShadowRadius
        {
            get => (double)GetValue(ShadowRadiusProperty);
            set => SetValue(ShadowRadiusProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ShadowRadius"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ShadowRadiusProperty =
            DependencyProperty.Register(nameof(ShadowRadius), typeof(double), typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(0d, new PropertyChangedCallback((d, e) => CalculateMarginForShadow(d))));

        /// <summary>
        /// Gets or sets the depth of the menu popup shadow.
        /// </summary>
        public double ShadowDepth
        {
            get => (double)GetValue(ShadowDepthProperty);
            set => SetValue(ShadowDepthProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ShadowDepth"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ShadowDepthProperty =
            DependencyProperty.Register(nameof(ShadowDepth), typeof(double), typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(0d, new PropertyChangedCallback((d, e) => CalculateMarginForShadow(d))));

        #region MarginForShadow

        /// <summary>
        /// Gets the margin used to display the menu popup shadow.
        /// </summary>
        public Thickness MarginForShadow => (Thickness)GetValue(MarginForShadowProperty);

        #region MarginForShadowProperty

        /// <summary>
        /// The <see cref="DependencyPropertyKey"/> for <see cref="MarginForShadow"/> dependency property.
        /// </summary>
        private static readonly DependencyPropertyKey MarginForShadowPropertyKey =
            DependencyProperty.RegisterReadOnly(nameof(MarginForShadow), typeof(Thickness), typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(new Thickness()));

        /// <summary>
        /// Identifies the <see cref="MarginForShadow"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty MarginForShadowProperty = MarginForShadowPropertyKey.DependencyProperty;

        #endregion

        /// <summary>
        /// Calculates the margin used to display the shadow.
        /// </summary>
        private static void CalculateMarginForShadow(DependencyObject d)
        {
            double margin = (double)d.GetValue(ShadowRadiusProperty) / 2;
            double offset = (double)d.GetValue(ShadowDepthProperty);
            d.SetValue(MarginForShadowPropertyKey, new Thickness(Math.Max(0, Math.Ceiling(margin - offset)),
                                                                 Math.Max(0, Math.Ceiling(margin - offset)),
                                                                 Math.Max(0, Math.Ceiling(margin + offset)),
                                                                 Math.Max(0, Math.Ceiling(margin + offset))));
        }

        #endregion

        #endregion

        #region Global properties for child elements

        /// <summary>
        /// Gets or sets the corner radius of the menu popup and items popup.
        /// </summary>
        public CornerRadius PopupCornerRadius
        {
            get => (CornerRadius)GetValue(PopupCornerRadiusProperty);
            set => SetValue(PopupCornerRadiusProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="PopupCornerRadius"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty PopupCornerRadiusProperty =
            FlatMenuItem.PopupCornerRadiusProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(new CornerRadius(), FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the padding of the menu popup and items popup.
        /// </summary>
        public Thickness PopupPadding
        {
            get => (Thickness)GetValue(PopupPaddingProperty);
            set => SetValue(PopupPaddingProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="PopupPadding"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty PopupPaddingProperty =
            FlatMenuItem.PopupPaddingProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(new Thickness(), FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the vertical offset of the items popup.
        /// </summary>
        public double PopupVerticalOffset
        {
            get => (double)GetValue(PopupVerticalOffsetProperty);
            set => SetValue(PopupVerticalOffsetProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="PopupVerticalOffset"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty PopupVerticalOffsetProperty =
            FlatMenuItem.PopupVerticalOffsetProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the horizontal offset of the items popup.
        /// </summary>
        public double PopupHorizontalOffset
        {
            get => (double)GetValue(PopupHorizontalOffsetProperty);
            set => SetValue(PopupHorizontalOffsetProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="PopupHorizontalOffset"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty PopupHorizontalOffsetProperty =
            FlatMenuItem.PopupHorizontalOffsetProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the foreground brush of the items when are highlighted.
        /// </summary>
        public Brush ForegroundOnHighlight
        {
            get => (Brush)GetValue(ForegroundOnHighlightProperty);
            set => SetValue(ForegroundOnHighlightProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ForegroundOnHighlight"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundOnHighlightProperty =
            FlatMenuItem.ForegroundOnHighlightProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(Extra.Brushes.Gray17, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the foreground brush of the items when have subitems and the popup is open.
        /// </summary>
        public Brush ForegroundOnOpen
        {
            get => (Brush)GetValue(ForegroundOnOpenProperty);
            set => SetValue(ForegroundOnOpenProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ForegroundOnOpen"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundOnOpenProperty =
            FlatMenuItem.ForegroundOnOpenProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(Extra.Brushes.Gray17, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the foreground brush of the items when are disabled.
        /// </summary>
        public Brush ForegroundOnDisabled
        {
            get => (Brush)GetValue(ForegroundOnDisabledProperty);
            set => SetValue(ForegroundOnDisabledProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ForegroundOnDisabled"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundOnDisabledProperty =
            FlatMenuItem.ForegroundOnDisabledProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(Extra.Brushes.Gray9, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the brush of the items check icons.
        /// </summary>
        public Brush CheckBrush
        {
            get => (Brush)GetValue(CheckBrushProperty);
            set => SetValue(CheckBrushProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="CheckBrush"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckBrushProperty =
            FlatMenuItem.CheckBrushProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(Extra.Brushes.Gray17, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the brush of the items check icons when are highlighted.
        /// </summary>
        public Brush CheckBrushOnHighlight
        {
            get => (Brush)GetValue(CheckBrushOnHighlightProperty);
            set => SetValue(CheckBrushOnHighlightProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="CheckBrushOnHighlight"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckBrushOnHighlightProperty =
            FlatMenuItem.CheckBrushOnHighlightProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(Extra.Brushes.Gray17, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the brush of the items check icons when have subitems and the popup is open.
        /// </summary>
        public Brush CheckBrushOnOpen
        {
            get => (Brush)GetValue(CheckBrushOnOpenProperty);
            set => SetValue(CheckBrushOnOpenProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="CheckBrushOnOpen"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckBrushOnOpenProperty =
            FlatMenuItem.CheckBrushOnOpenProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(Extra.Brushes.Gray17, FrameworkPropertyMetadataOptions.Inherits));

        /// <summary>
        /// Gets or sets the brush of the items check icons when are disabled.
        /// </summary>
        public Brush CheckBrushOnDisabled
        {
            get => (Brush)GetValue(CheckBrushOnDisabledProperty);
            set => SetValue(CheckBrushOnDisabledProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="CheckBrushOnDisabled"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckBrushOnDisabledProperty =
            FlatMenuItem.CheckBrushOnDisabledProperty.AddOwner(typeof(FlatContextMenu),
                new FrameworkPropertyMetadata(Extra.Brushes.Gray9, FrameworkPropertyMetadataOptions.Inherits));

        #endregion


        static FlatContextMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlatContextMenu), new FrameworkPropertyMetadata(typeof(FlatContextMenu)));
        }

        /// <summary>
        /// Initializes a new instance of <see cref="FlatContextMenu"/>.
        /// </summary>
        public FlatContextMenu() : base()
        {
            Loaded += (o, e) => OnLoaded(e);
        }

        /// <summary>
        /// Called when the element is laid out, rendered, and ready for interaction.
        /// </summary>
        /// <param name="e">Event data.</param>
        protected virtual void OnLoaded(RoutedEventArgs e) { }

        /// <inheritdoc/>
        protected override DependencyObject GetContainerForItemOverride() => new FlatMenuItemContainer();

        /// <inheritdoc/>
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);
            if (item is FlatMenuSeparator) FlatMenuSeparator.PrepareContainer(element as FlatMenuItemContainer, item as FlatMenuSeparator);
            else if (item is FlatMenuSpace) FlatMenuSpace.PrepareContainer(element as FlatMenuItemContainer, item as FlatMenuSpace);
            else if (item is FlatMenuTitle) FlatMenuTitle.PrepareContainer(element as FlatMenuItemContainer, item as FlatMenuTitle);
            else FlatMenuItem.PrepareContainer(element as FlatMenuItemContainer);
        }
    }
}
