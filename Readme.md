<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/DistinguishingTwoPages/Default.aspx) (VB: [Default.aspx](./VB/DistinguishingTwoPages/Default.aspx))
* [Default.aspx.cs](./CS/DistinguishingTwoPages/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/DistinguishingTwoPages/Default.aspx.vb))
<!-- default file list end -->
# How to distinguish between instances of the same page opened in different tabs
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1365/)**
<!-- run online end -->


<p>A user can open the same page twice or more in a new tab or browser window. Your task may require differentiating between the page instances. In this case, the URL and Session are the same. The solution is to use the <a href="http://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxHiddenFieldASPxHiddenFieldtopic">ASPxHiddenField</a> component, to store a unique ID of a given page instance.</p>

<br/>


