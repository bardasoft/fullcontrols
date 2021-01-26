﻿using FullControls.Core;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace FullControls
{
    /// <summary>
    /// Simple <see cref="AccordionItem"/> with header and content.
    /// </summary>
    [ContentProperty(nameof(Content))]
    [DefaultProperty(nameof(Content))]
    public class SimpleAccordionItem : AccordionItem
    {
        private bool loaded = false;

        /// <summary>
        /// Foreground brush when the mouse is over the control.
        /// </summary>
        public Brush ForegroundOnMouseOver
        {
            get => (Brush)GetValue(ForegroundOnMouseOverProperty);
            set => SetValue(ForegroundOnMouseOverProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ForegroundOnMouseOver"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundOnMouseOverProperty =
            DependencyProperty.Register(nameof(ForegroundOnMouseOver), typeof(Brush), typeof(SimpleAccordionItem));

        /// <summary>
        /// Foreground brush when <see cref="AccordionItem.IsExpanded"/> is <see langword="true"/>.
        /// </summary>
        public Brush ForegroundOnExpanded
        {
            get => (Brush)GetValue(ForegroundOnExpandedProperty);
            set => SetValue(ForegroundOnExpandedProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ForegroundOnExpanded"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundOnExpandedProperty =
            DependencyProperty.Register(nameof(ForegroundOnExpanded), typeof(Brush), typeof(SimpleAccordionItem));

        /// <summary>
        /// Foreground brush when the mouse is over the control and <see cref="AccordionItem.IsExpanded"/> is <see langword="true"/>.
        /// </summary>
        public Brush ForegroundOnMouseOverOnExpanded
        {
            get => (Brush)GetValue(ForegroundOnMouseOverOnExpandedProperty);
            set => SetValue(ForegroundOnMouseOverOnExpandedProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="ForegroundOnMouseOverOnExpanded"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundOnMouseOverOnExpandedProperty =
            DependencyProperty.Register(nameof(ForegroundOnMouseOverOnExpanded), typeof(Brush), typeof(SimpleAccordionItem));

        /// <summary>
        /// Foreground brush when the control is disabled.
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
            DependencyProperty.Register(nameof(ForegroundOnDisabled), typeof(Brush), typeof(SimpleAccordionItem));

        /// <summary>
        /// Actual Foreground brush of the control.
        /// </summary>
        public Brush ActualForeground => (Brush)GetValue(ActualForegroundProperty);

        /// <summary>
        /// Identifies the <see cref="ActualForeground"/> dependency property.
        /// </summary>
        internal static readonly DependencyProperty ActualForegroundProperty =
            DependencyProperty.Register(nameof(ActualForeground), typeof(Brush), typeof(SimpleAccordionItem));

        /// <summary>
        /// FontWeight brush when the mouse is over the control.
        /// </summary>
        public FontWeight FontWeightOnMouseOver
        {
            get => (FontWeight)GetValue(FontWeightOnMouseOverProperty);
            set => SetValue(FontWeightOnMouseOverProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="FontWeightOnMouseOver"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FontWeightOnMouseOverProperty =
            DependencyProperty.Register(nameof(FontWeightOnMouseOver), typeof(FontWeight), typeof(SimpleAccordionItem));

        /// <summary>
        /// FontWeight brush when <see cref="AccordionItem.IsExpanded"/> is <see langword="true"/>.
        /// </summary>
        public FontWeight FontWeightOnExpanded
        {
            get => (FontWeight)GetValue(FontWeightOnExpandedProperty);
            set => SetValue(FontWeightOnExpandedProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="FontWeightOnExpanded"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FontWeightOnExpandedProperty =
            DependencyProperty.Register(nameof(FontWeightOnExpanded), typeof(FontWeight), typeof(SimpleAccordionItem));

        /// <summary>
        /// FontWeight brush when the mouse is over the control and <see cref="AccordionItem.IsExpanded"/> is <see langword="true"/>.
        /// </summary>
        public FontWeight FontWeightOnMouseOverOnExpanded
        {
            get => (FontWeight)GetValue(FontWeightOnMouseOverOnExpandedProperty);
            set => SetValue(FontWeightOnMouseOverOnExpandedProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="FontWeightOnMouseOverOnExpanded"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FontWeightOnMouseOverOnExpandedProperty =
            DependencyProperty.Register(nameof(FontWeightOnMouseOverOnExpanded), typeof(FontWeight), typeof(SimpleAccordionItem));

        /// <summary>
        /// FontWeight brush when the control is disabled.
        /// </summary>
        public FontWeight FontWeightOnDisabled
        {
            get => (FontWeight)GetValue(FontWeightOnDisabledProperty);
            set => SetValue(FontWeightOnDisabledProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="FontWeightOnDisabled"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty FontWeightOnDisabledProperty =
            DependencyProperty.Register(nameof(FontWeightOnDisabled), typeof(FontWeight), typeof(SimpleAccordionItem));

        /// <summary>
        /// Actual FontWeight of the control.
        /// </summary>
        public FontWeight ActualFontWeight => (FontWeight)GetValue(ActualFontWeightProperty);

        /// <summary>
        /// Identifies the <see cref="ActualFontWeight"/> dependency property.
        /// </summary>
        internal static readonly DependencyProperty ActualFontWeightProperty =
            DependencyProperty.Register(nameof(ActualFontWeight), typeof(FontWeight), typeof(SimpleAccordionItem));

        /// <summary>
        /// Vertical alignment of the header.
        /// </summary>
        public VerticalAlignment VerticalHeaderAlignment
        {
            get => (VerticalAlignment)GetValue(VerticalHeaderAlignmentProperty);
            set => SetValue(VerticalHeaderAlignmentProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="VerticalHeaderAlignment"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty VerticalHeaderAlignmentProperty =
            DependencyProperty.Register(nameof(VerticalHeaderAlignment), typeof(VerticalAlignment), typeof(SimpleAccordionItem));

        /// <summary>
        /// Horizontal alignment of the header.
        /// </summary>
        public HorizontalAlignment HorizontalHeaderAlignment
        {
            get => (HorizontalAlignment)GetValue(HorizontalHeaderAlignmentProperty);
            set => SetValue(HorizontalHeaderAlignmentProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="HorizontalHeaderAlignment"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty HorizontalHeaderAlignmentProperty =
            DependencyProperty.Register(nameof(HorizontalHeaderAlignment), typeof(HorizontalAlignment), typeof(SimpleAccordionItem));

        /// <summary>
        /// Duration of the control animation when it changes state.
        /// </summary>
        public TimeSpan AnimationTime
        {
            get => (TimeSpan)GetValue(AnimationTimeProperty);
            set => SetValue(AnimationTimeProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="AnimationTime"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty AnimationTimeProperty =
            DependencyProperty.Register(nameof(AnimationTime), typeof(TimeSpan), typeof(SimpleAccordionItem));

        /// <summary>
        /// Content of the expanding part.
        /// </summary>
        public object Content
        {
            get => GetValue(ContentProperty);
            set => SetValue(ContentProperty, value);
        }

        /// <summary>
        /// Identifies the <see cref="Content"/> dependency property.
        /// </summary>
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register(nameof(Content), typeof(object), typeof(SimpleAccordionItem));


        /// <summary>
        /// Creates a new <see cref="SimpleAccordionItem"/>.
        /// </summary>
        static SimpleAccordionItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SimpleAccordionItem), new FrameworkPropertyMetadata(typeof(SimpleAccordionItem)));
        }

        /// <inheritdoc/>
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            Utility.AnimateBrush(this, ActualForegroundProperty, Foreground, TimeSpan.Zero);
            SetValue(ActualFontWeightProperty, FontWeight);
            loaded = true;
            ReloadBrushes();
        }

        /// <inheritdoc/>
        protected override void OnEnabledChanged(bool enabledState)
        {
            base.OnEnabledChanged(enabledState);
            ReloadBrushes();
        }

        /// <inheritdoc/>
        protected override void OnExpandedChanged(bool newValue)
        {
            base.OnExpandedChanged(newValue);
            ReloadBrushes();
        }

        /// <inheritdoc/>
        protected override void OnHeaderMouseEnter(MouseEventArgs e)
        {
            base.OnHeaderMouseEnter(e);
            ReloadBrushes();
        }

        /// <inheritdoc/>
        protected override void OnHeaderMouseLeave(MouseEventArgs e)
        {
            base.OnHeaderMouseLeave(e);
            ReloadBrushes();
        }

        /// <summary>
        /// Apply the correct brushes to the control, based on its state.
        /// </summary>
        private void ReloadBrushes()
        {
            if (!loaded) return;
            if (!IsEnabled) //Disabled state
            {
                Utility.AnimateBrush(this, ActualForegroundProperty, ForegroundOnDisabled, TimeSpan.Zero);
                SetValue(ActualFontWeightProperty, FontWeightOnDisabled);
            }
            else if (IsMouseOverHeader) //MouseOver state
            {
                if (IsExpanded == true)
                {
                    Utility.AnimateBrush(this, ActualForegroundProperty, ForegroundOnMouseOverOnExpanded, AnimationTime);
                    SetValue(ActualFontWeightProperty, FontWeightOnMouseOverOnExpanded);
                }
                else
                {
                    Utility.AnimateBrush(this, ActualForegroundProperty, ForegroundOnMouseOver, AnimationTime);
                    SetValue(ActualFontWeightProperty, FontWeightOnMouseOver);
                }
            }
            else if (IsExpanded == true) //Expanded state
            {
                Utility.AnimateBrush(this, ActualForegroundProperty, ForegroundOnExpanded, AnimationTime);
                SetValue(ActualFontWeightProperty, FontWeightOnExpanded);
            }
            else //Normal state
            {
                Utility.AnimateBrush(this, ActualForegroundProperty, Foreground, AnimationTime);
                SetValue(ActualFontWeightProperty, FontWeight);
            }
        }
    }
}