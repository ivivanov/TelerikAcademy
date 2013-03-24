using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WordDocument : OfficeDocument, IEditable
{
    public int? CharacterCount { get; set; }

    public WordDocument(string name, string content = "", int? size = null, string version = "", int? characterCount = null) : base(name, content, size, version)
    {
        this.CharacterCount = characterCount;
    }

    public void ChangeContent(string newContent)
    {
        this.Content = newContent;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "chars")
            this.CharacterCount = int.Parse(value);
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("chars", this.CharacterCount));
        base.SaveAllProperties(output);
    }
}