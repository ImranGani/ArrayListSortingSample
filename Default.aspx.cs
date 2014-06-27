using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ArrayList al = new ArrayList();
        al.Add("[2][name]");
        al.Add("[0][ID]");
        al.Add("[4][Age]");
        al.Add("[3][Dept]");
        al.Add("[1][Company]");
        al.Add("[15][Profile]");
        al.Add("[3.5][Role]");
        al.Sort();

        ArrayList al1 = new ArrayList();
        al1.Add("[2][name]");
        al1.Add("[0][ID]");
        al1.Add("[4][Age]");
        al1.Add("[3][Dept]");
        al1.Add("[1][Company]");
        al1.Add("[15][Profile]");
        al1.Add("[Role]");
        al1.Sort();

        Hashtable hs = new Hashtable();
        hs.Add("[2]", "[name]");
        hs.Add("[0]", "[ID]");
        hs.Add("[4]", "[Age]");
        hs.Add("[3]", "[Dept]");
        hs.Add("[1]", "[Company]");
        hs.Add("[15]", "[Profile]");
        hs.Add("[3.5]", "[Role]");

        Hashtable hs1 = new Hashtable();
        hs1.Add(2, "[name]");
        hs1.Add(0, "[ID]");
        hs1.Add(4, "[Age]");
        hs1.Add(3, "[Dept]");
        hs1.Add(1, "[Company]");
        hs1.Add(15, "[Profile]");
        hs1.Add(3.5, "[Role]");

        Hashtable hs11 = new Hashtable();
        hs11.Add(2, "[name]");
        hs11.Add(0, "[ID]");
        hs11.Add(4, "[Age]");
        hs11.Add(3, "[Dept]");
        hs11.Add(1, "[Company]");
        hs11.Add(15, "[Profile]");
        hs11.Add(3.5, "[Role]");

        char[] array = { 'z', 'a', 'b' }; // Input array.
        Array.Sort<char>(array); // Sort array.

        string[] a = new string[]
	{
	    "Egyptian",
	    "Indian",
	    "American",
	    "Chinese",
	    "Filipino",
	};
        Array.Sort(a);

        string[] b = new string[]
	{
           "2", 
        "0",
        "4", 
        "3", 
        "1", 
        "15", 
        "3.5",
	    "1",
	    "Indian",
	    "American",
	    "Chinese",
	    "Filipino",
	};
        Array.Sort(b);

        decimal[] i = new decimal[] { 2, 0, 4, 3, 1, 15, 35, 1 };
        Array.Sort(i);
    }

    // testing for githubk
}