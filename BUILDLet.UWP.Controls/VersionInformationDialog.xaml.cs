/***************************************************************************************************
The MIT License (MIT)

Copyright 2021 Daiki Sakamoto

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, 
sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or 
substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT 
NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
***************************************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// コンテンツ ダイアログの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace BUILDLet.UWP.Controls
{
    /// <summary>
    /// バージョン情報 ダイアログを実装します。
    /// </summary>
    public sealed partial class VersionInformationDialog : ContentDialog
    {
        /// <summary>
        /// このインスタンスの View Model を取得します。
        /// </summary>
        public VersionInformationViewModel ViewModel { get; }


        /// <summary>
        /// <see cref="VersionInformationDialog"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="viewModel">
        /// このインスタンスの View Model として設定する <see cref="VersionInformationViewModel"/> を指定します。
        /// </param>
        public VersionInformationDialog(VersionInformationViewModel viewModel)
        {
            // Initialize Component
            this.InitializeComponent();

            // SET ViewModel
            this.ViewModel = viewModel;

            // Remove "Version" text if ViewModel.Version is empty
            if (string.IsNullOrWhiteSpace(this.ViewModel.Version))
            {
                this.VersionLabel.Text = string.Empty;
            }
        }
    }
}
