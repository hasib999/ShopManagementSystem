﻿#pragma checksum "..\..\..\UserLogIn\UserLogIn.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D23C1A9B0A165F6629CE3C6D66A17008F9CF07CCD547CDE9BEF23972B2F104AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ShopManagementSystem.UserLogIn;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ShopManagementSystem.UserLogIn {
    
    
    /// <summary>
    /// UserLogIn
    /// </summary>
    public partial class UserLogIn : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UserLogIn\UserLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginbtn;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\UserLogIn\UserLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitbtn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\UserLogIn\UserLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idtxtbox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\UserLogIn\UserLogIn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passtxtbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShopManagementSystem;component/userlogin/userlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserLogIn\UserLogIn.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.loginbtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\UserLogIn\UserLogIn.xaml"
            this.loginbtn.Click += new System.Windows.RoutedEventHandler(this.loginbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.exitbtn = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\..\UserLogIn\UserLogIn.xaml"
            this.exitbtn.Click += new System.Windows.RoutedEventHandler(this.exitbtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.idtxtbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.passtxtbox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

