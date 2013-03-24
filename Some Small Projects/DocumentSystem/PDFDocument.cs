using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PDFDocument : EncryptableBinaryDocument
{
    public int? PageCount { get; set; }

    public PDFDocument(string name, string content="", int? size=null, int? pageCount=null) : base(name,content,size)
    {
        this.PageCount = pageCount;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "pages")
            this.PageCount = int.Parse(value);
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("pages", this.PageCount));
        base.SaveAllProperties(output);
    }
}