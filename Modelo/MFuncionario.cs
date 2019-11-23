using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class MFuncionario
    {
        public int CodigoFuncionario { get; set; }
        public String NomeFuncionario { get; set; }
        public String UsuarioFuncionario { get; set; }
        public String SenhaFuncionario { get; set; }
        public String CpfFuncionario { get; set; }
        public String RgFuncionario { get; set; }
        public DateTime DataNascimentoFuncionario { get; set; }
        public String SexoFuncionario { get; set; }
        public String EstadoCivilFuncionario { get; set; }
        public String CelularFuncionario { get; set; }
        public String FuncaoExercidaFuncionario { get; set; }
        public DateTime AdmissaoFuncionario { get; set; }
        public DateTime DemissaoFuncionario { get; set; }
        public Double SalarioBaseFuncionario { get; set; }
        public String BancoNomeFuncionario { get; set; }
        public String BancoAgenciaFuncionario { get; set; }
        public String BancoContaFuncionario { get; set; }
        public int CodigoEndereco { get; set; }
        public MFuncionario()
        {
            this.CodigoFuncionario = 0;
            this.NomeFuncionario = "";
            this.UsuarioFuncionario = "";
            this.SenhaFuncionario = "";
            this.CpfFuncionario = "";
            this.RgFuncionario = "";
            this.DataNascimentoFuncionario = default(DateTime);
            this.SexoFuncionario = "";
            this.EstadoCivilFuncionario = "";
            this.CelularFuncionario = "";
            this.FuncaoExercidaFuncionario = "";
            this.AdmissaoFuncionario = default(DateTime);
            this.DemissaoFuncionario = default(DateTime);
            this.SalarioBaseFuncionario = 0;
            this.BancoNomeFuncionario = "";
            this.BancoAgenciaFuncionario = "";
            this.BancoContaFuncionario = "";
            this.CodigoEndereco = 0;

        }

        public MFuncionario(string nomeFuncionario, string usuarioFuncionario, string senhaFuncionario, string cpfFuncionario, string rgFuncionario, DateTime dataNascimentoFuncionario, string sexoFuncionario, string estadoCivilFuncionario, string celularFuncionario, string funcaoExercidaFuncionario, DateTime admissaoFuncionario, double salarioBaseFuncionario, string bancoNomeFuncionario, string bancoAgenciaFuncionario, string bancoContaFuncionario)
        {
            NomeFuncionario = nomeFuncionario;
            UsuarioFuncionario = usuarioFuncionario;
            SenhaFuncionario = senhaFuncionario;
            CpfFuncionario = cpfFuncionario;
            RgFuncionario = rgFuncionario;
            DataNascimentoFuncionario = dataNascimentoFuncionario;
            SexoFuncionario = sexoFuncionario;
            EstadoCivilFuncionario = estadoCivilFuncionario;
            CelularFuncionario = celularFuncionario;
            FuncaoExercidaFuncionario = funcaoExercidaFuncionario;
            AdmissaoFuncionario = admissaoFuncionario;
            SalarioBaseFuncionario = salarioBaseFuncionario;
            BancoNomeFuncionario = bancoNomeFuncionario;
            BancoAgenciaFuncionario = bancoAgenciaFuncionario;
            BancoContaFuncionario = bancoContaFuncionario;
        }
    }
}
