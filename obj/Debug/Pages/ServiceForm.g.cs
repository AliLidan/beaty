﻿#pragma checksum "..\..\..\Pages\ServiceForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D3EA8A1F6683F332BDDA3507B0AE46C308CF554AEB465EF29613049F09D37DBF"
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
    /// ServiceForm
    /// </summary>
    public partial class ServiceForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PanelID;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBID;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBTitle;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBCost;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBTime;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBDescription;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBDiscount;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image PhotoMainPreview;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\ServiceForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LBPhoto;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfBeauty;component/pages/serviceform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ServiceForm.xaml"
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
            this.PanelID = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.TBID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TBTitle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TBCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TBTime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TBDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TBDiscount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.PhotoMainPreview = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            
            #line 46 "..\..\..\Pages\ServiceForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonSelectMainImage_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.LBPhoto = ((System.Windows.Controls.ListBox)(target));
            return;
            case 11:
            
            #line 63 "..\..\..\Pages\ServiceForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnAddPhoto_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 64 "..\..\..\Pages\ServiceForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnRemovePhoto_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 80 "..\..\..\Pages\ServiceForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

