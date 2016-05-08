using System;
using System.Threading;

namespace Turnover.Common
{
    /// <summary>
    /// http://csharptest.net/1250/why-guid-primary-keys-are-a-databases-worst-nightmare/
    /// </summary>
    public static class SequentialGuidGenerator
    {
        static int _sequenced = (int)DateTime.UtcNow.Ticks;
        
        private static readonly System.Security.Cryptography.RNGCryptoServiceProvider _random = new System.Security.Cryptography.RNGCryptoServiceProvider();
        
        private static readonly byte[] _buffer = new byte[6];

        public static Guid NewGuid()
        {
            long ticks = DateTime.UtcNow.Ticks;
            int sequenceNum = Interlocked.Increment(ref _sequenced);
            lock (_buffer)
            {
                _random.GetBytes(_buffer);

                return new Guid(
                    (int)(ticks >> 32),
                    (short)(ticks >> 16),
                    (short)ticks,
                    (byte)(sequenceNum >> 8),
                    (byte)sequenceNum,
                    _buffer[0],
                    _buffer[1],
                    _buffer[2],
                    _buffer[3],
                    _buffer[4],
                    _buffer[5]
                );
            }
        }
    }
}
