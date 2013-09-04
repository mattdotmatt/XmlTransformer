using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using XsltTransformer.Properties;

namespace XsltTransformer
{
    public partial class Transformer : Form
    {
        private const string RESULT_HTML = "result.html";

        public Transformer()
        {
            InitializeComponent();
        }

        private void BtnTransformClick(object p_sender, EventArgs p_e)
        {
            try
            {
                var xmlDocument = GetXmlFromForm();

                var myXslTrans = GetTransformFromForm();

                TransformXml(myXslTrans, xmlDocument);

                ShowHtml();
            }
            catch
            {
                MessageBox.Show(Resources.ERROR_TRANSFORMING);
            }
        }

        private static void ShowHtml()
        {
            System.Diagnostics.Process.Start(RESULT_HTML);
        }

        private static void TransformXml(XslCompiledTransform p_xslTrans, XmlDocument p_xmlDocument)
        {
            XmlTextWriter myWriter = new XmlTextWriter(RESULT_HTML, null);
            p_xslTrans.Transform(p_xmlDocument, null, myWriter);
        }

        private XslCompiledTransform GetTransformFromForm()
        {
            using (XmlReader xrt = XmlReader.Create(new StringReader(rtbXsl.Text)))
            {
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(xrt);
                return transform;
            }
        }

        private XmlDocument GetXmlFromForm()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(rtbXml.Text);
            return xmlDocument;
        }
    }
}
