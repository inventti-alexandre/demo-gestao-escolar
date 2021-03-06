﻿using Demo.GestaoEscolar.Domain.Aggregates.PessoasFisicas;
using Demo.GestaoEscolar.Domain.Repositories.PessoasFisicas;
using Demo.GestaoEscolar.Domain.Services.PessoasFisicas;
using System;
using System.Threading.Tasks;

namespace Demo.GestaoEscolar.Infra.EF.Services.PessoasFisicas
{
	public class PessoaFisicaService : IPessoaFisicaService
	{
		private readonly IPessoaFisicaRepository _pessoasFisicaRepository;

		public PessoaFisicaService(IPessoaFisicaRepository pessoaFisicaRepository)
		{
			_pessoasFisicaRepository = pessoaFisicaRepository;
		}

		public async Task CriarAsync(Guid id, string nome, string cpf, string nomeSocial, string sexo, DateTime dataNascimento)
		{
			var pessoaFisica = new PessoaFisica(id, nome, cpf, nomeSocial, sexo, dataNascimento);
			await _pessoasFisicaRepository.AddAsync(pessoaFisica);
		}
	}
}
