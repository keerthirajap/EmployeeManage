﻿using Microsoft.AspNetCore.ResponseCompression;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCore.Infrastructure
{
    public class BrotliCompressionProvider : ICompressionProvider
    {
        public string EncodingName => "br";
        public bool SupportsFlush => true;
        public Stream CreateStream(Stream outputStream)
        {
            return new BrotliStream(outputStream, CompressionMode.Compress);
        }
    }
}
