using Livraria.Data.Context;
using Livraria.Models;

namespace Livraria.Data.Repositories
{
    public class LogErroRepository
    {
        private LivrariaContext _ctx;

        public LogErroRepository(LivrariaContext ctx)
        {
            _ctx = ctx;
        }

        public void Adicionar(Exception ex)
        {
            var logBase = new LogErro();

            logBase.InnerException = ex.InnerException?.ToString();
            logBase.StackTrace = ex.StackTrace;
            logBase.Mensagem = ex.Message;
            logBase.DataHoraRegistro = DateTime.Now;

            _ctx.LogErros.Add(logBase);
            _ctx.SaveChanges();
        }
    }
}
