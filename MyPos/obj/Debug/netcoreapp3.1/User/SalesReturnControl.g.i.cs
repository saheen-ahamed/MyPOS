﻿#pragma checksum "..\..\..\..\User\SalesReturnControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9F8AAA22B9382EFD9E706D3D847DA9A925FCA6DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using MyPos;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MyPos {
    
    
    /// <summary>
    /// SalesReturnControl
    /// </summary>
    public partial class SalesReturnControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbillNo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFind;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDate;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdBill;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtQuantityReturn;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAdd;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnconfirm;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdReturnDetails;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\..\User\SalesReturnControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBack;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyPos;component/user/salesreturncontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\User\SalesReturnControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtbillNo = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\..\..\User\SalesReturnControl.xaml"
            this.txtbillNo.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnFind = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\User\SalesReturnControl.xaml"
            this.btnFind.Click += new System.Windows.RoutedEventHandler(this.btnFind_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtDate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.grdBill = ((System.Windows.Controls.DataGrid)(target));
            
            #line 42 "..\..\..\..\User\SalesReturnControl.xaml"
            this.grdBill.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grdBill_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtQuantityReturn = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\User\SalesReturnControl.xaml"
            this.txtQuantityReturn.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRemove = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\..\User\SalesReturnControl.xaml"
            this.btnRemove.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\User\SalesReturnControl.xaml"
            this.btnAdd.Click += new System.Windows.RoutedEventHandler(this.btnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnconfirm = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\User\SalesReturnControl.xaml"
            this.btnconfirm.Click += new System.Windows.RoutedEventHandler(this.btnConfirm_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.grdReturnDetails = ((System.Windows.Controls.DataGrid)(target));
            
            #line 87 "..\..\..\..\User\SalesReturnControl.xaml"
            this.grdReturnDetails.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grdReturnDetails_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnBack = ((System.Windows.Controls.Button)(target));
            
            #line 107 "..\..\..\..\User\SalesReturnControl.xaml"
            this.btnBack.Click += new System.Windows.RoutedEventHandler(this.btnBack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

