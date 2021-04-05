﻿namespace Cosmos.Security.Verification.MessageDigest
{
    public class MdConfig
    {
        /// <summary>
        /// Length of the produced Message Digest value, in bits.
        /// </summary>
        public int HashSizeInBits { get; internal set; }

        /// <summary>
        /// Message Digest Algorithm type of the value.
        /// </summary>
        public MdTypes Type { get; internal set; }

        /// <summary>
        /// Mode control, [0, 64], be used for MD6
        /// </summary>
        public uint ModeControl { get; internal set; }

        /// <summary>
        /// Number of Round, be used for MD6 <br />
        /// default value: <br /> without key = 40 + d/4 <br /> with key = max(80, 40 + d/4)
        /// </summary>
        public uint NumberOfRound { get; internal set; }

        /// <summary>
        /// Key, be used for MD6
        /// </summary>
        public string Key { get; set; } = "";

        /// <summary>
        /// To flag the value of key is HEX string or not, be used for MD6
        /// </summary>
        public bool IsHexString { get; set; } = false;
    }
}