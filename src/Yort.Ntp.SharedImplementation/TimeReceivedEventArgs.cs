﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yort.Ntp
{
	/// <summary>
	/// Event arguments for the <see cref="NtpClient.TimeReceived"/> event, providing the updated time.
	/// </summary>
	public class NtpTimeReceivedEventArgs : EventArgs
	{
		private readonly DateTime _CurrentTime;
		private readonly DateTime _SysTime;

		/// <summary>
		/// Full constructor.
		/// </summary>
		/// <param name="currentTime">The date and time just received from the NTP server.</param>
		/// <param name="sysTime">The date and time of the local system at reception.</param>
		public NtpTimeReceivedEventArgs(DateTime currentTime, DateTime sysTime)
		{
			_CurrentTime = currentTime;
			_SysTime = sysTime;
		}

		/// <summary>
		/// Returns the (UTC) time returned by the NTP server.
		/// </summary>
		public DateTime CurrentTime
		{
			get
			{
				return _CurrentTime;
			}
		}

		/// <summary>
		/// Returns the (UTC) time of the local system as at the moment <see cref="CurrentTime"/> was received from the NTP server.
		/// </summary>
		public DateTime SysTime
		{
			get
			{
				return _SysTime;
			}
		}
	}
}