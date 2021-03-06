﻿using System;
using System.Collections.Generic;

namespace Demo.GestaoEscolar.Infra.Data
{
	public class EscolaDto
	{
		public Guid EntityId { get; set; }
		public DateTime DataCriacao { get; set; }

		public string Nome { get; set; }

		public IEnumerable<SalaDto> Salas { get; set; }
	}
}
