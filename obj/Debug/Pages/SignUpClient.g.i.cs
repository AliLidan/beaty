﻿#pragma checksum "..\..\..\Pages\SignUpClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B85B5AAB22830122AA6ED7D983F972605CCCB5B23CEDF072411CB2E021B51033"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfBeauty.Pages;


namespace WpfBeauty.Pages {
    
    
    /// <summary>
    /// SignUpClient
    /// </summary>
    public partial class SignUpClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\SignUpClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBTitle;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\SignUpClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBTime;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\SignUpClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClientComboBox;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\SignUpClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DPService;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\SignUpClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBStartTime;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\SignUpClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBEndTime;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfBeauty;component/pages/signupclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\SignUpClient.xaml"
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
            this.TBTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TBTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ClientComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.DPService = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.TBStartTime = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\..\Pages\SignUpClient.xaml"
            this.TBStartTime.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBStartTime_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TBEndTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 55 "..\..\..\Pages\SignUpClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSignUp_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

