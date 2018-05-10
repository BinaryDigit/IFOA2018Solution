using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segreteria.Data
{
    public abstract class PersonaBase: IPremi
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascina { get; set; }
        public ushort AnnoNascita { get; set; }

        public string NomePremio
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public DateTime DataPremio
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual PersonaBase GetPersonaByDataPremio(DateTime dataPremio)
        {
            throw new NotImplementedException();
        }

        public virtual List<PersonaBase> GetAllPersonaWithPremio()
        {
            List<PersonaBase> lstPB = new List<PersonaBase>();
            lstPB.Add(new Alunni());
            lstPB.Add(new Docenti());
            lstPB.Add(new Rettori());
            throw new NotImplementedException();
        }

        public virtual void Telefona()
        {
        }
    }

    public class Alunni: PersonaBase
    {
        public long Matricola;
        public new void Telefona()
        {
            // Telefona dalla cabina telefonica
        }
    }

    public class Docenti : Alunni
    {
        public string Cattedra;


        public new PersonaBase GetPersonaByDataPremio(DateTime dataPremio)
        {
            throw new NotImplementedException();
        }

        public new void Telefona()
        {
            // Telefona dall'uffio universita
        }
    }

    public interface IPremi
    {
        string NomePremio { get; set; }
        DateTime DataPremio { get; set; }

        PersonaBase GetPersonaByDataPremio( DateTime dataPremio);

        List<PersonaBase> GetAllPersonaWithPremio();
    }

    

    public class Rettori : Docenti
    {
        public new PersonaBase GetPersonaByDataPremio(DateTime dataPremio)
        {
            throw new NotImplementedException();
        }

        public new void Telefona()
        {
            // Telefona con smartphone
        }
    }

    public class test
    {
        public test()
        {
            Docenti DocenteUno = new Docenti();
            Docenti DocenteDue = new Docenti();
            Rettori RettoreUno = new Data.Rettori();

            DocenteUno.Nome = "Ciccio";
            Rettori RettoreTre = (Rettori)RettoreUno.GetPersonaByDataPremio(DateTime.Now.AddYears(-10));

            Alunni Persona = new Alunni();

            PersonaBase ciccio = Persona.GetAllPersonaWithPremio().FindAll(p => p.GetType().IsInstanceOfType(typeof(Rettori))).First();

            ciccio.Telefona();
        }
    }
}
