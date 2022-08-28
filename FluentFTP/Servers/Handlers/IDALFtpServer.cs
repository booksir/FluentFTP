﻿using System.Threading;
using System.Threading.Tasks;

namespace FluentFTP.Servers.Handlers {

	/// <summary>
	/// Server-specific handling for ABB IDAL FTP servers
	/// </summary>
	internal class IDALFtpServer : FtpBaseServer {

		/// <summary>
		/// Return the FtpServer enum value corresponding to your server, or Unknown if its a custom implementation.
		/// </summary>
		public override FtpServer ToEnum() {
			return FtpServer.IDALFTP;
		}

		/// <summary>
		/// Return true if your server is detected by the given FTP server welcome message.
		/// </summary>
		public override bool DetectByWelcome(string message) {

			// Detect IDAL server
			// Welcome message: "220 Welcome to IDAL FTP server. READY."
			if (message.Contains("IDAL FTP server")) {
				return true;
			}

			return false;
		}

	}
}