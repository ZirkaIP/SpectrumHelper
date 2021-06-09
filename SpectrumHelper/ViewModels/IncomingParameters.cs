using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpectrumHelper.ViewModels
{
	public class IncomingParameters
	{
		[Display (Name = "Нижняя частота")]
		[Required (ErrorMessage = "Поле не может быть пустым")]
		public decimal LowerFrequency { get; set; }

		[Display (Name = "Верхняя частота")]
		[Required(ErrorMessage = "Поле не может быть пустым")]
		public decimal UpperFrequency { get; set; }

		[Display(Name = "Шаг")]
		public decimal step { get; set; }
	}
}
