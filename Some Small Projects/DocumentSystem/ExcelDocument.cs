using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ExcelDocument : OfficeDocument
{
    public int? RowCount { get; set; }

    public int? ColumnCount { get; set; }

    public ExcelDocument(string name, string content = "", int? size = null, string version = "", int? rowCount = null, int? columnCount = null) : base(name, content, size, version)
    {
        this.RowCount = rowCount;
        this.ColumnCount = columnCount;
    }

    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
            this.RowCount = int.Parse(value);
        else if (key == "cols")
            this.ColumnCount = int.Parse(value);
        else
            base.LoadProperty(key, value);
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        output.Add(new KeyValuePair<string, object>("rows", this.RowCount));
        output.Add(new KeyValuePair<string, object>("cols", this.ColumnCount));
        base.SaveAllProperties(output);
    }
}