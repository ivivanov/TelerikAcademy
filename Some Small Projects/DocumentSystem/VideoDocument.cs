using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VideoDocument : MultimediaDocument
{
    public int? FrameRate { get; set; }

    public VideoDocument(string name, string content = "", int? size = null, int? lengthSeconds = null, int? frameRate = null) : base(name, content, size, lengthSeconds)
    {
        this.FrameRate = frameRate;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "framerate")
            this.FrameRate = int.Parse(value);
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        base.SaveAllProperties(output);
    }
}