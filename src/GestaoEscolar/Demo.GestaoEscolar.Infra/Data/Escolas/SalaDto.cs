﻿using System;

namespace Demo.GestaoEscolar.Infra.Data
{
	public class SalaDto
	{
		public Guid EntityId { get; set; }
		public string FaseAno { get; set; }
		public string Turno { get; set; }
		public int QtdAlunos { get; set; }
	}
}
