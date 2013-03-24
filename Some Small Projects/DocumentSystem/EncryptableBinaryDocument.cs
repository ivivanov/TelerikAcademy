using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class EncryptableBinaryDocument : BinaryDocumnet, IEncryptable
{
    private bool isEncrypted;

    public EncryptableBinaryDocument(string name, string content = "", int? size = null) : base(name, content, size)
    {
    }

    public bool IsEncrypted
    {
        get
        {
            return this.isEncrypted;
        }
    }

    public virtual void Encrypt()
    {
        this.isEncrypted = true;
    }
        
    public virtual void Decrypt()
    {
        this.isEncrypted = false;
    }

    public override string ToString()
    {
        if (isEncrypted)
        {
            return this.GetType().Name + "[encrypted]";
        }

        return base.ToString();
    }
}