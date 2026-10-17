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
        private int _colIni;
        private int _linFin;

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

        public bool BuscarCodigo(string matricula)
        {
            bool encontrei = false;

            for (int i = 0; i < this._colecaoAlunos.Count; i++)
            {
                if (this._colecaoAlunos[i].Matricula == matricula)
                {
                    this._posicao = i;
                    encontrei = true;
                    break;
                }
            }

            return encontrei;
        }

        public void ExecutarCRUD()
        {
            AlunoView view = new AlunoView();
            AlunoModel aluno = new AlunoModel();
            string resp;
            //mostart tela 
            view.MostrarFormulario();
            //pergunta o codigo
            view.EntrarDados("PK", aluno);
            //busca pelo codigo
            bool achei =  this.BuscarCodigo(aluno.Matricula);
            //se NAO ACHOU 
            if (!achei)
            {
                //avisa que nao achou e pergunta se deseja cadastrar
                resp = view.Perguntar("Matricula nao encontrada. Deseja cadastrar (S/N) : ");
                //se SIM
                if (resp == "S")
                {
                    //pergunta os outros dados do aluno
                    view.EntrarDados("DT", aluno);
                    
                    //pergunta se confirma o cadastro
                    resp = view.Perguntar("Confirma o cadastro (S/N) : ");
                    //se SIM
                    if(resp == "s")
                    {
                        //adiciona o novo aluno à coleção
                        this._colecaoAlunos.Add(aluno);
                    }
                   
                }
            }
            //se ACHOU
            else
            {
                //mostra os dados do aluno
                view.MostrarDados(this._colecaoAlunos[this._posicao]);
                //pergunta se deseja alterar/excluir/voltar
                resp = view.Perguntar("Deseja alterar/excluir/voltar (A/E/V) : ");
                
                //se ALTERAR
                if (resp == "A")
                {
                    //pergunta os novos dados
                    view.EntrarDados("DT", aluno);
                    
                    //pergunta se confirma alteração
                    resp = view.Perguntar("Confirma alteração (S/N) : ");
                    
                    //se SIM
                    if (resp == "S")
                    {
                        //atualiza os daods do aluno na coleção
                        this._colecaoAlunos[this._posicao] = aluno;
                    }
                }
                //se EXCLUIR
                else if (resp == "E")
                {
                    //pergunta se confirma exclusao
                    resp = view.Perguntar("Confirma exclusão (S/N) : ");
                    //se SIM
                    if (resp == "S")
                    {
                        //apaga o aluno da coleção
                        this._colecaoAlunos.RemoveAt(this._posicao);
                    }
                }
            }
        }
    }
}
