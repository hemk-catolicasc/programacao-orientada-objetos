using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class AlunoController
    {
        // atributos
        private List<AlunoModel> _colecaoAlunos;

        private AlunoModel _aluno;
        private AlunoView _alunoView;

        private int _posicao;

        // construtor
        public AlunoController()
        {
            this._alunoView = new AlunoView();
            this._aluno = new AlunoModel();

            this._colecaoAlunos = new List<AlunoModel>();
            // adiciona 1 aluno na coleção para testarmos a consulta posteriormente
            this._colecaoAlunos.Add(
                new AlunoModel("123","Zé Colmeia","zecolmeia@gmail.com","99967-8976")
            );
        }

        public void ExecutarCRUD()
        {
            this._alunoView.MostrarFormulario();
            this._aluno = this._alunoView.EntrarDados("PK");
        }
    }
}
