using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AudioDocument : MultimediaDocument
{
    public int? SampleRateHz { get; set; }

    public AudioDocument(string name, string content = "", int? size = null, int? lengthSeconds = null, int? sampleRateHz = null) : base(name, content, size, lengthSeconds)
    {
        this.SampleRateHz = sampleRateHz;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
            this.SampleRateHz = int.Parse(value);
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRateHz));
        base.SaveAllProperties(output);
    }
}