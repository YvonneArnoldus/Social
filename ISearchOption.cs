using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Social
{
	public interface ISearchOption
	{
		[Required]
		string SlackChannel { get; set; }
	}
}
