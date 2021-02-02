using System;
using System.IO;

namespace Null.Library.TriggerStream
{
    class WriteStreamEventArgs : EventArgs
    {
        public byte[] Buffer;
        public int Offset, Count;
    }
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
                    Buffer = buffer,
                    Offset = offset,
                    Count = count,
                });
        }
        public event EventHandler<WriteStreamEventArgs> PreviewWrite;
    }
}
