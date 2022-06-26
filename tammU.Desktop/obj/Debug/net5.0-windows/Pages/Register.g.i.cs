﻿#pragma checksum "..\..\..\..\Pages\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3628A222A996A254E43FE80533648E43ACF6AADD"
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
using tammU.Desktop.Pages;


namespace tammU.Desktop.Pages {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FnameBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LnameBox;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BirthdayBox;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenderBox;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UsernameBox;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailBox;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox1;
        
        #line default
        #line hidden
        
        
        #line 248 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordBox2;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\..\..\Pages\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Registration;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/tammU.Desktop;V1.0.0.0;component/pages/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FnameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.LnameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.BirthdayBox = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.GenderBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.UsernameBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.EmailBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PasswordBox1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 8:
            this.PasswordBox2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            
            #line 263 "..\..\..\..\Pages\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Submit);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 273 "..\..\..\..\Pages\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Reset);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 283 "..\..\..\..\Pages\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Login);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Registration = ((System.Windows.Controls.Frame)(target));
            
            #line 292 "..\..\..\..\Pages\Register.xaml"
            this.Registration.Navigated += new System.Windows.Navigation.NavigatedEventHandler(this.Registration_Navigated);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

