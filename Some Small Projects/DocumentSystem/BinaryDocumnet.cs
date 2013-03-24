using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class BinaryDocumnet : Document
{
    public int? Size { get; set; }

    public BinaryDocumnet(string name, string content="", int? size=null) : base(name, content)
    {
        this.Size = size;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "size")
            this.Size = int.Parse(value);
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("size", this.Size));
        base.SaveAllProperties(output);
    }
}