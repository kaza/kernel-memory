// Copyright (c) Microsoft. All rights reserved.

using System.Collections.Generic;
using System.Text;

namespace Microsoft.KernelMemory;

public class MemoryDocument
{
    public List<MemoryDocumentPage> Pages { get; set; } = new List<MemoryDocumentPage>();

    public string CompleteContent
    {
        get
        {
            var sb = new StringBuilder();
            foreach (MemoryDocumentPage page in this.Pages)
            {
                sb.Append(page.Text);
            }

            return sb.ToString();
        }
    }

    public void AddPage(string str)
    {
        var page = new MemoryDocumentPage();
        page.Text = str;
        page.PageNumber = this.Pages.Count + 1;
        this.Pages.Add(page);
    }
}
