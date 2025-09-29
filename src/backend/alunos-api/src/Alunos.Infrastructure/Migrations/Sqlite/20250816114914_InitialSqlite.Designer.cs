using System;
using Alunos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alunos.Infrastructure.Migrations.Sqlite
{
    [DbContext(typeof(AlunoDbContext))]
    [Migration("20250816114914_InitialSqlite")]
    partial class InitialSqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.7");

            modelBuilder.Entity("Alunos.Domain.Entities.Aluno", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("UniqueIdentifier")
                        .HasColumnName("AlunoId");

                    b.Property<bool>("Ativo")
                        .HasColumnType("Bit")
                        .HasColumnName("Ativo");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("Varchar")
                        .HasColumnName("Cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("Varchar")
                        .HasColumnName("Cidade");

                    b.Property<Guid>("CodigoUsuarioAutenticacao")
                        .HasColumnType("UniqueIdentifier")
                        .HasColumnName("CodigoUsuarioAutenticacao");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .HasColumnType("Varchar")
                        .HasColumnName("Cpf");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("DataCriacao");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("SmallDateTime")
                        .HasColumnName("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar")
                        .HasColumnName("Email");

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .HasColumnType("Varchar")
                        .HasColumnName("Estado");

                    b.Property<string>("Foto")
                        .HasMaxLength(1024)
                        .HasColumnType("Varchar")
                        .HasColumnName("Foto");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("Varchar")
                        .HasColumnName("Genero");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .HasMaxLength(25)
                        .HasColumnType("Varchar")
                        .HasColumnName("Telefone");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("DataAlteracao");

                    b.HasKey("Id")
                        .HasName("AlunosPK");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("AlunosEmailUK");

                    b.HasIndex("Nome")
                        .HasDatabaseName("AlunosNomeIDX");

                    b.ToTable("Alunos", (string)null);
                });

            modelBuilder.Entity("Alunos.Domain.Entities.Certificado", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("UniqueIdentifier")
                        .HasColumnName("CertificadoId");

                    b.Property<short>("CargaHoraria")
                        .HasColumnType("SmallInt")
                        .HasColumnName("CargaHoraria");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("DataCriacao");

                    b.Property<DateTime?>("DataEmissao")
                        .HasColumnType("SmallDateTime")
                        .HasColumnName("DataEmissao");

                    b.Property<DateTime>("DataSolicitacao")
                        .HasColumnType("SmallDateTime")
                        .HasColumnName("DataSolicitacao");

                    b.Property<Guid>("MatriculaCursoId")
                        .HasColumnType("UniqueIdentifier")
                        .HasColumnName("MatriculaCursoId");

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("Varchar")
                        .HasColumnName("NomeCurso");

                    b.Property<string>("NomeInstrutor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar")
                        .HasColumnName("NomeInstrutor");

                    b.Property<decimal>("NotaFinal")
                        .HasColumnType("TinyInt")
                        .HasColumnName("NotaFinal");

                    b.Property<string>("PathCertificado")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("Varchar")
                        .HasColumnName("PathCertificado");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("DataAlteracao");

                    b.HasKey("Id")
                        .HasName("CertificadosPK");

                    b.HasIndex("MatriculaCursoId")
                        .IsUnique()
                        .HasDatabaseName("CertificadosMatriculaCursoIdIDX");

                    b.ToTable("Certificados", (string)null);
                });

            modelBuilder.Entity("Alunos.Domain.Entities.MatriculaCurso", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("UniqueIdentifier")
                        .HasColumnName("MatriculaCursoId");

                    b.Property<Guid>("AlunoId")
                        .HasColumnType("UniqueIdentifier")
                        .HasColumnName("AlunoId");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("DataCriacao");

                    b.Property<Guid>("CursoId")
                        .HasColumnType("UniqueIdentifier")
                        .HasColumnName("CursoId");

                    b.Property<DateTime?>("DataConclusao")
                        .HasColumnType("SmallDateTime")
                        .HasColumnName("DataConclusao");

                    b.Property<DateTime>("DataMatricula")
                        .HasColumnType("SmallDateTime")
                        .HasColumnName("DataMatricula");

                    b.Property<int>("EstadoMatricula")
                        .HasColumnType("TinyInt")
                        .HasColumnName("EstadoMatricula");

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("Varchar")
                        .HasColumnName("NomeCurso");

                    b.Property<string>("Observacao")
                        .HasMaxLength(2000)
                        .HasColumnType("Varchar")
                        .HasColumnName("Observacao");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("DataAlteracao");

                    b.Property<decimal>("Valor")
                        .HasPrecision(10, 2)
                        .HasColumnType("Money")
                        .HasColumnName("Valor");

                    b.HasKey("Id")
                        .HasName("MatriculasCursosPK");

                    b.HasIndex("AlunoId")
                        .HasDatabaseName("MatriculasCursosAlunoIdIDX");

                    b.HasIndex("CursoId")
                        .HasDatabaseName("MatriculasCursosCursoIdIDX");

                    b.ToTable("MatriculasCursos", (string)null);
                });

            modelBuilder.Entity("Alunos.Domain.Entities.Certificado", b =>
                {
                    b.HasOne("Alunos.Domain.Entities.MatriculaCurso", "MatriculaCurso")
                        .WithOne("Certificado")
                        .HasForeignKey("Alunos.Domain.Entities.Certificado", "MatriculaCursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("MatriculasCursosCertificadosFK");

                    b.Navigation("MatriculaCurso");
                });

            modelBuilder.Entity("Alunos.Domain.Entities.MatriculaCurso", b =>
                {
                    b.HasOne("Alunos.Domain.Entities.Aluno", "Aluno")
                        .WithMany("MatriculasCursos")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("MatriculasCursosAlunosFK");

                    b.OwnsMany("Alunos.Domain.ValueObjects.HistoricoAprendizado", "HistoricoAprendizado", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("UniqueIdentifier")
                                .HasColumnName("HistoricoAprendizadoId");

                            b1.Property<Guid>("AulaId")
                                .HasColumnType("UniqueIdentifier");

                            b1.Property<int>("CargaHoraria")
                                .HasColumnType("Int");

                            b1.Property<Guid>("CursoId")
                                .HasColumnType("UniqueIdentifier");

                            b1.Property<DateTime>("DataInicio")
                                .HasColumnType("SmallDateTime");

                            b1.Property<DateTime?>("DataTermino")
                                .HasColumnType("SmallDateTime");

                            b1.Property<Guid>("MatriculaCursoId")
                                .HasColumnType("UniqueIdentifier")
                                .HasColumnName("MatriculaCursoId");

                            b1.Property<string>("NomeAula")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("Varchar");

                            b1.HasKey("Id")
                                .HasName("HistoricoAprendizadoPK");

                            b1.HasIndex("AulaId")
                                .HasDatabaseName("HistoricosAprendizadoAulaIdIDX");

                            b1.HasIndex("CursoId")
                                .HasDatabaseName("HistoricosAprendizadoCursoIdIDX");

                            b1.HasIndex("MatriculaCursoId");

                            b1.ToTable("HistoricosAprendizado", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("MatriculaCursoId");
                        });

                    b.Navigation("Aluno");

                    b.Navigation("HistoricoAprendizado");
                });

            modelBuilder.Entity("Alunos.Domain.Entities.Aluno", b =>
                {
                    b.Navigation("MatriculasCursos");
                });

            modelBuilder.Entity("Alunos.Domain.Entities.MatriculaCurso", b =>
                {
                    b.Navigation("Certificado");
                });
#pragma warning restore 612, 618
        }
    }
}
