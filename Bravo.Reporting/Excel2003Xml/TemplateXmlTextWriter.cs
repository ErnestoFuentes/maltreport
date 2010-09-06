﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace Bravo.Reporting.Xml
{
    internal class TemplateXmlTextWriter : XmlTextWriter
    {
        private string currentElementName = null;

        public TemplateXmlTextWriter(Stream inStream)
            : base(inStream, Encoding.UTF8)
        {
        }

        public override void WriteStartElement(string prefix, string localName, string ns)
        {
            currentElementName = localName;
            base.WriteStartElement(prefix, localName, ns);
        }

        /// <summary>
        /// 只允许 Cell 或 Data
        /// </summary>
        /// <param name="text"></param>
        public override void WriteString(string text)
        {
            if (text != null &&
                this.currentElementName != "Cell" &&
                this.currentElementName != "Data")
            {
                text = VelocityEscapeTool.EscapeDirective(text);
            }

            base.WriteString(text);
        }
    }
}
