using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Library.TriggerStream
{
    class TriggerStream : Stream
    {
        public override bool CanRead => false;

        public override bool CanSeek => false;

        public override bool CanWrite => true;

        public override long Length => 0;

        public override long Position { get => 0; set {  } }

        public override void Flush() { }

        public override int Read(byte[] buffer, int offset, int count)
        {
            return 0;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            return 0;
        }

        public override void SetLength(long value) { }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (PreviewWrite != null)
                PreviewWrite.Invoke(this, new WriteStreamEventArgs()
                {
                    buffer = buffer,
                    offset = offset,
                    count = count,
                });
        }
        public event EventHandler<WriteStreamEventArgs> PreviewWrite;
    }
}
