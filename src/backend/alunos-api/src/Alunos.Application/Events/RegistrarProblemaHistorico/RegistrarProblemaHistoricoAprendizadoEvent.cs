using Core.Messages;

namespace Alunos.Application.Events.RegistrarProblemaHistorico;

public class RegistrarProblemaHistoricoAprendizadoEvent : EventRaiz
{
    public Guid AlunoId { get; init; }
    public Guid MatriculaCursoId { get; init; }
    public Guid AulaId { get; init; }
    public DateTime? DataTermino { get; private set; }
    public string MensagemErro { get; init; }

    public RegistrarProblemaHistoricoAprendizadoEvent(Guid alunoId, Guid matriculaCursoId, Guid aulaId, DateTime? dataTermino, string mensagemErro)
    {
        DefinirRaizAgregacao(matriculaCursoId);

        MatriculaCursoId = matriculaCursoId;
        AlunoId = alunoId;
        AulaId = aulaId;
        DataTermino = dataTermino;
        MensagemErro = mensagemErro;
    }
}
