using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Diagnostics;

namespace DistinguishingTwoPages {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            if(!IsPostBack && !IsCallback) {
                Guid newId = Guid.NewGuid();
                ASPxHiddenField1.Add("PageID", newId);
            }
        }
        protected void Page_Load(object sender, EventArgs e) {
            object pageID = ASPxHiddenField1["PageID"];
            ASPxLabel1.Text = string.Format("Page ID: {0}", pageID);

            if(IsPostBack || IsCallback)
                Debug.WriteLine(string.Format("Page: {0}, Value: {1}", pageID, ASPxTextBox1.Text));
        }
    }
}
