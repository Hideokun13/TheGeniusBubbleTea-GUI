﻿#pragma checksum "..\..\..\SizeSelectorPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99DBF154D400B023927DDFF5B3A0F2E66AFC04B7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TheGenuisBubbleTea_GUI;


namespace TheGenuisBubbleTea_GUI {
    
    
    /// <summary>
    /// SizeSelectorPage
    /// </summary>
    public partial class SizeSelectorPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\SizeSelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HomeButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\SizeSelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderButton;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\SizeSelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrderStatusButton;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\SizeSelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MemberButton;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\..\SizeSelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackButton;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\SizeSelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TheGenuisBubbleTea-GUI;component/sizeselectorpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SizeSelectorPage.xaml"
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
            this.HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\SizeSelectorPage.xaml"
            this.HomeButton.Click += new System.Windows.RoutedEventHandler(this.HomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.OrderButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.OrderStatusButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\SizeSelectorPage.xaml"
            this.OrderStatusButton.Click += new System.Windows.RoutedEventHandler(this.OrderStatusButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MemberButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\SizeSelectorPage.xaml"
            this.MemberButton.Click += new System.Windows.RoutedEventHandler(this.MemberButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 99 "..\..\..\SizeSelectorPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SizeSButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 113 "..\..\..\SizeSelectorPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SizeMButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 127 "..\..\..\SizeSelectorPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SizeLButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 141 "..\..\..\SizeSelectorPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SizeXLButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\..\SizeSelectorPage.xaml"
            this.BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.NextButton = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\..\SizeSelectorPage.xaml"
            this.NextButton.Click += new System.Windows.RoutedEventHandler(this.NextButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

