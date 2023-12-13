// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.KernelMemory;

public static class MemoryDocumentExtensions
{
    public static MemoryDocument ToDocument(this string str)
    {
        // Implement logic to create and return a Document object from the string
        var result = new MemoryDocument();
        result.AddPage(str);
        return result;
    }
}
