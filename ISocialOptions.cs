using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Social
{
	public interface ISocialOptions
	{
		[Required]
		string ApplicationName { get; set; }

		[Required]
		string ApiKey { get; set; }
	}
}
