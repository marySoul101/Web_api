using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Etudiant
        {
            public int id { get; set; }
            public string nom { get; set; }
            public string prenom { get; set; }
            public string CIN { get; set; }
            public int age { get; set; }


            public Etudiant()
            {

            }
            public Etudiant(int identifiant, string first_name, string last_name, string cin, int age)
            {
                this.id = identifiant;
                this.nom = last_name;
                this.prenom = first_name;
                this.CIN = cin;
                this.age = age;
            }

            public string ToString()
            {
                return "id: " + this.id + ",nom: " + this.nom + ",prenom: " + this.prenom + ",CIN: " + this.CIN + ",age: " + this.age;
            }

            public void affichage()
            {
                Console.WriteLine(this.ToString());
            }
        }
    }


