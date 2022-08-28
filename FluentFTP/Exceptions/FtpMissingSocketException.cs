﻿using System;
#if !NETSTANDARD
using System.Runtime.Serialization;
#endif

namespace FluentFTP.Exceptions {
	/// <summary>
	/// Exception is thrown by FtpSocketStream when there is no FTP server socket to connect to.
	/// </summary>
#if !NETSTANDARD
	[Serializable]
#endif
	public class FtpMissingSocketException : FtpException {
		/// <summary>
		/// Creates a new FtpMissingSocketException.
		/// </summary>
		/// <param name="innerException">The original exception.</param>
		public FtpMissingSocketException(Exception innerException)
			: base("Socket is missing", innerException) {
		}

#if !NETSTANDARD
		/// <summary>
		/// Must be implemented so every Serializer can Deserialize the Exception
		/// </summary>
		protected FtpMissingSocketException(SerializationInfo info, StreamingContext context) : base(info, context) {
		}

#endif
	}
}