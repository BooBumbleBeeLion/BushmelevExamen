﻿#pragma checksum "..\..\..\Pages\PageProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47BE0526F604CF0FA4A2C610309A0682E374ECF6E589C15FE503D24FF76C1DE8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BushmelevExamen.Pages;
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


namespace BushmelevExamen.Pages {
    
    
    /// <summary>
    /// PageProduct
    /// </summary>
    public partial class PageProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockItemsCount;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmBoxSort;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmBoxFilter;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxProducts;
        
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
            System.Uri resourceLocater = new System.Uri("/BushmelevExamen;component/pages/pageproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageProduct.xaml"
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
            this.txtBlockItemsCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtBoxSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\Pages\PageProduct.xaml"
            this.txtBoxSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBoxSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmBoxSort = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\Pages\PageProduct.xaml"
            this.cmBoxSort.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmBoxSort_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmBoxFilter = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\..\Pages\PageProduct.xaml"
            this.cmBoxFilter.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmBoxFilter_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.listBoxProducts = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

