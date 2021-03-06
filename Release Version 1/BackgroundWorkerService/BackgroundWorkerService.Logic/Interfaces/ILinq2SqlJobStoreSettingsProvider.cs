﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundWorkerService.Logic.Interfaces
{
	/// <summary>
	/// An interface that is required to provide settings to the Lin2SqlJobStoreProvider.
	/// </summary>
	public interface ILinq2SqlJobStoreSettingsProvider
	{
		/// <summary>
		/// Gets the connection string that will be used to connect to SQL server
		/// </summary>
		string ConnectionString { get; }
	}
}
