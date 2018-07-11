﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PessoasFisicas.Domain.Aggregates;

namespace PessoasFisicas.Infra.EF.Mappings
{
	public class PessoaFisicaMap : IEntityTypeConfiguration<PessoaFisica>
	{
		public void Configure(EntityTypeBuilder<PessoaFisica> builder)
		{
			builder.ToTable("PessoaFisica", "PFIS");

			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).ValueGeneratedOnAdd();

			builder.Property(x => x.DataCriacao);
			builder.Property(x => x.Nome);
			builder.Property(x => x.Cpf);
			builder.Property(x => x.NomeSocial);
			builder.Property(x => x.Sexo);
			builder.Property(x => x.DataNascimento);
		}
	}
}