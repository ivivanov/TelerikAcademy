using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class OfficeDocument : EncryptableBinaryDocument
{
    public string Version { get; set; }

    public OfficeDocument(string name, string content = "", int? size = null, string version = "") : base(name, content, size)
    {
        this.Version = version;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "version")
            this.Version = value;
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("version", this.Version));
        base.SaveAllProperties(output);
    }
}