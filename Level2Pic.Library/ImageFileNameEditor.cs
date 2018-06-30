// <copyright file="ImageFileNameEditor.cs" company="NZoid154 Softwares">
// Copyright (c) 2010 - 2011
// </copyright>

namespace Level2Pic.Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Represents an editor that allows the property grid to retrieve image files from an OpenFileDialog.
    /// </summary>
    internal class ImageFileNameEditor : System.Drawing.Design.UITypeEditor
    {
        /// <summary>
        /// The file dialog that will be used to get an image path.
        /// </summary>
        private OpenFileDialog dialogImage;

        /// <summary>
        /// Initializes a new instance of the ImageFileNameEditor class.
        /// </summary>
        internal ImageFileNameEditor()
        {
            this.dialogImage = new OpenFileDialog();
        }

        /// <summary>
        /// Edits the specified object's value using the editor style indicated by the GetEditStyle method.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information. </param>
        /// <param name="provider">An IServiceProvider that this editor can use to obtain services. </param>
        /// <param name="value">The object to edit. </param>
        /// <returns>The new value of the object. If the value of the object has not changed, this should return the same object it was passed.</returns>
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            this.dialogImage.FileName = value.ToString();
            this.dialogImage.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg, *.jpg)|*.jpeg; *.jpg|Bitmap Files (*.bmp)|*.bmp|GIF Files (*.gif)|*.gif|TIFF Files (*.tiff, *.tif)|*.tif; *tiff";

            if (this.dialogImage.ShowDialog() == DialogResult.OK)
            {
                return this.dialogImage.FileName;
            }

            return base.EditValue(context, provider, value);
        }

        /// <summary>
        /// Gets the editor style used by the EditValue method.
        /// </summary>
        /// <param name="context">An ITypeDescriptorContext that can be used to gain additional context information. </param>
        /// <returns>A UITypeEditorEditStyle value that indicates the style of editor used by the EditValue method. If the UITypeEditor does not support this method, then GetEditStyle will return None.</returns>
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return System.Drawing.Design.UITypeEditorEditStyle.Modal;
        }
    }
}
