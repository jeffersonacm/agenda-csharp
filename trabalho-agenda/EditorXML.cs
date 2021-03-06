﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace trabalho_agenda
{
    class EditorXML<T>
    {
        public void Serializar(List<T> lista, string arquivo)
        {
            lista.AddRange(Deserializar(arquivo));
            Criar(arquivo);
            TextWriter writer = new StreamWriter(arquivo);
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            serializer.Serialize(writer, lista);
            writer.Close();
        }

        public void Serializar(T objeto, string arquivo)
        {
            List<T> aux = new List<T>();
            aux.Add(objeto);
            Serializar(lista: aux, arquivo: arquivo);
        }

        public void Serializar(List<T> lista, string arquivo, bool append)
        {
            Criar(arquivo);
            TextWriter writer = new StreamWriter(arquivo);
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            serializer.Serialize(writer, lista);
            writer.Close();
        }

        public List<T> Deserializar(string arquivo)
        {
            Criar(arquivo);
            List<T> lista = new List<T>();
            FileStream fileStream = new FileStream(arquivo, FileMode.Open);
            fileStream.Position = 0;
            XmlSerializer serializer = new XmlSerializer(lista.GetType());
            try
            {
                lista = (List<T>)serializer.Deserialize(fileStream);
            }
            catch (Exception)
            {
                lista = new List<T>();
            }
            fileStream.Close();
            return lista;
        }

        public void Criar(string arquivo)
        {
            FileStream fileStream = new FileStream(arquivo, FileMode.OpenOrCreate);
            fileStream.Close();
        }

    }
}
