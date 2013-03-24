using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class MultimediaDocument : BinaryDocumnet
{
    public int? LengthSeconds { get; set; }

    public MultimediaDocument(string name, string content = "", int? size = null, int? lengthSeconds = null) : base(name, content, size)
    {
        this.LengthSeconds = lengthSeconds;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "length")
            this.LengthSeconds = int.Parse(value);
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("length", this.LengthSeconds));
        base.SaveAllProperties(output);
    }
}