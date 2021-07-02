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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUILDLet.UWP.Controls
{
    /// <summary>
    /// <see cref="VersionInformationDialog"/> に設定する View Model を実装します。
    /// </summary>
    public class VersionInformationViewModel
    {
        /// <summary>
        /// <see cref="VersionInformationDialog"/> ダイアログに表示する製品名を取得または設定します。
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// <see cref="VersionInformationDialog"/> ダイアログに表示するバージョンを文字列として取得または設定します。
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// <see cref="VersionInformationDialog"/> ダイアログに表示する Copyright を取得または設定します。
        /// </summary>
        public string Copyright { get; set; }


        /// <summary>
        /// <see cref="VersionInformationViewModel"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        public VersionInformationViewModel() { }

        /// <summary>
        /// <inheritdoc cref="VersionInformationViewModel()"/>
        /// </summary>
        /// <param name="product">
        /// <see cref="VersionInformationDialog"/> ダイアログに表示する製品名 (<see cref="ProductName"/>) を指定します。
        /// </param>
        /// <param name="version">
        /// <see cref="VersionInformationDialog"/> ダイアログに表示するバージョン (<see cref="Version"/>) を指定します。
        /// </param>
        /// <param name="copyright">
        /// <see cref="VersionInformationDialog"/> ダイアログに表示する Copyright (<see cref="Copyright"/>) を指定します。
        /// </param>
        public VersionInformationViewModel(string product, string version, string copyright = null)
        {
            this.ProductName = product;
            this.Version = version;
            this.Copyright = copyright;
        }
    }
}
