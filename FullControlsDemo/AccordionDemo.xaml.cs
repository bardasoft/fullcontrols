﻿using FullControls;
using System.Collections.Generic;
using System.Windows;

namespace FullControlsDemo
{
    /// <summary>
    /// Logica di interazione per AccordionDemo.xaml
    /// </summary>
    public partial class AccordionDemo : EWindow
    {
        public AccordionDemo()
        {
            InitializeComponent();
        }

        private void EButton_Click(object sender, RoutedEventArgs e)
        {
            SimpleAccordionItem item = new SimpleAccordionItem();
            item.Header = "HeadX";

            Acc.Items.Add(item);
        }

        private void EButton2_Click(object sender, RoutedEventArgs e)
        {
            SimpleAccordionItem item = new SimpleAccordionItem();
            SimpleAccordionItem item2 = new SimpleAccordionItem();
            SimpleAccordionItem item3 = new SimpleAccordionItem();
            item.Header = "Head1";
            item2.Header = "Head2";
            item3.Header = "Head3";

            AccordionItemCollection accordionItems = new();
            accordionItems.Add(item);
            accordionItems.Add(item2);
            accordionItems.Add(item3);

            Acc.Items = accordionItems;

            Acc.Items.Remove(item2);

            SimpleAccordionItem itemx = new SimpleAccordionItem();
            itemx.Header = "HeadX";
            Acc.Items.Insert(1, itemx);

            SimpleAccordionItem item4 = new SimpleAccordionItem();
            item4.Header = "Head4";
            Acc.Items[1] = item4;


            SimpleAccordionItem item5 = new SimpleAccordionItem();
            SimpleAccordionItem item6 = new SimpleAccordionItem();
            accordionItems.Add(item5);
            accordionItems.Add(item6);

            Acc.Items.Move(1, 3);

            Acc.Items.Clear();
        }

        private void EButton3_Click(object sender, RoutedEventArgs e)
        {
            List<Test> tests = new();
            tests.Add(new Test("I1"));
            tests.Add(new Test("I2"));
            tests.Add(new Test("I3"));
            tests.Add(new Test("I4"));
            tests.Add(new Test("I5"));

            i1.ItemsSource = tests;
        }

        public class Test
        {
            public string Text { get; set; }

            public Test(string text)
            {
                Text = text;
            }
        }
    }
}
