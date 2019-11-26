using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace trabalho_agenda
{
    [Serializable]
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataNasc { get; set; }
        public Endereco Endereço { get; set; }

        public bool cpfExiste()
        {
            EditorXML<Usuario> editorXML = new EditorXML<Usuario>();
            foreach (Usuario x in (List<Usuario>)editorXML.Deserializar("usuarios.xml"))
            {
                if (this.CPF == x.CPF)
                    return true;
            }
            return false;
        }
    }
    public struct Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
    }


}
