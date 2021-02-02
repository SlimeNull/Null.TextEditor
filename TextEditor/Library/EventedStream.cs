using System;
using System.IO;

namespace Null.Library.EventedStream
{
    class ReadStreamEventArgs : EventArgs
    {
        public byte[] Buffer;
        public int Offset, Count;

        public bool Denied = false;
    }
    class WriteStreamEventArgs : EventArgs
    {
        public byte[] Buffer;
        public int Offset, Count;

        public bool Denied = false;
    }
    public class FlushStreamEventArgs : EventArgs
    {
        public bool Denied = false;
    }
    public class SetStreamLengthEventArgs : EventArgs
    {
        public long Value;

        public bool Denied = false;
    }
    public class SeekStreamEventArgs : EventArgs
    {
        public long Offset;
        public SeekOrigin SeekOrigin;

        public bool Denied = false;
    }
    class EventedStream : Stream, IDisposable
    {
        MemoryStream baseMemory = new MemoryStream();
        public override bool CanRead => baseMemory.CanRead;

        public override bool CanSeek => baseMemory.CanSeek;

        public override bool CanWrite => baseMemory.CanWrite;

        public override long Length => baseMemory.Length;

        public override long Position { get => baseMemory.Position; set => baseMemory.Position = value; }

        public override void Flush()
        {
            if (PreviewFlush != null)
            {
                FlushStreamEventArgs args = new FlushStreamEventArgs();
                PreviewFlush.Invoke(this, args);
                if (args.Denied)
                    return;
            }

            baseMemory.Flush();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (PreviewRead != null)
            {
                ReadStreamEventArgs args = new ReadStreamEventArgs()
                {
                    Buffer = buffer,
                    Offset = offset,
                    Count = count
                };
                PreviewRead.Invoke(this, args);
                if (args.Denied)
                    return 0;
            }

            return baseMemory.Read(buffer, offset, count);
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            if (PreviewSeek != null)
            {
                SeekStreamEventArgs args = new SeekStreamEventArgs()
                {
                    Offset = offset,
                    SeekOrigin = origin
                };
                PreviewSeek.Invoke(this, args);
                if (args.Denied)
                    return Position;
            }

            return baseMemory.Seek(offset, origin);
        }

        public override void SetLength(long value)
        {
            if (PreviewSetLength != null)
            {
                SetStreamLengthEventArgs args = new SetStreamLengthEventArgs()
                {
                    Value = value
                };
                PreviewSetLength.Invoke(this, args);
                if (args.Denied)
                    return;
            }

            baseMemory.SetLength(value);
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (PreviewWrite != null)
            {
                WriteStreamEventArgs args = new WriteStreamEventArgs()
                {
                    Buffer = buffer,
                    Offset = offset,
                    Count = count
                };
                PreviewWrite.Invoke(this, args);
                if (args.Denied)
                    return;
            }

            baseMemory.Write(buffer, offset, count);
        }
        public new void Dispose()
        {
            baseMemory.Dispose();
        }


        public event EventHandler<FlushStreamEventArgs> PreviewFlush;
        public event EventHandler<SetStreamLengthEventArgs> PreviewSetLength;
        public event EventHandler<SeekStreamEventArgs> PreviewSeek;
        public event EventHandler<WriteStreamEventArgs> PreviewWrite;
        public event EventHandler<ReadStreamEventArgs> PreviewRead;
    }
}
