using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Document : IDocument
{
    public string Name { get; protected set; }

    public string Content { get; protected set; }

    public Document(string name, string content="")
    {
        this.Name = name;
        this.Content = content;
    }

    public Document(string name) : this(name, String.Empty)
    {
    }

    public virtual void LoadProperty(string key, string value)
    {
        if (key == "name")
            this.Name = value;
        else if (key == "content")
            this.Content = value;
        else
            throw new ArgumentException("Invalid key");
    }

    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("name", this.Name));
        output.Add(new KeyValuePair<string, object>("content", this.Content));
    }

    public override string ToString()
    {
        List<KeyValuePair<string, object>> output = new List<KeyValuePair<string, object>>();
        SaveAllProperties(output);
        var sortedAttr = String.Join(";", from attr in output
                                          where attr.Value != "" && attr.Value != null
                                          orderby (attr.Key) ascending
                                          select attr.Key + "=" + attr.Value);
        return this.GetType().Name + "[" + sortedAttr + "]";
    }
}