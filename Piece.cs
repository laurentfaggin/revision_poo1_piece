using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace revision_poo1_piece
{
    public class Piece
    {
        private string m_description;
        private int m_numero_serie;
        private string m_reference;
        private List<Piece> m_liste_Piece;
        private List<Piece> m_liste_aplatie;
        protected int count;
        public string Description
        {
            get { return this.m_description; }
            private set {this.m_description=value; }
        }       
        public int NumeroSerie
        {
            get { return this.m_numero_serie; }
            private set { this.m_numero_serie = value; }
        }
        public string Reference
        {
            get { return this.m_reference; }
            private set { this.m_reference = value; }
        }
        public int Count
        {
            get {return count;}
            set {count = value;}
        }
        public List<Piece> ListeAplatie
        {
            get {return new List<Piece>(){this};}
        }
        public Piece(string p_description, string p_reference, int p_numero_serie)
        {
            this.m_description = p_description;
            this.m_reference = p_reference;
            this.m_numero_serie = p_numero_serie;
            this.m_liste_Piece = new List<Piece>();
            this.m_liste_aplatie = new List<Piece>();
        }
        public virtual void RemplirListeAplatie()
        {
            foreach (Piece p in m_liste_Piece)
            {
                p.RemplirListeAplatie();               
                ListeAplatie.AddRange(p.ListeAplatie); 
            }
        }
        public string Bom()
        {
            string bom = string.Format($"{"Description", -30} {"Reference", -15} {"Quantite", -10}\n");
            var tri = m_liste_aplatie.OrderBy(p => p.NumeroSerie);     
            var descriptions = tri.Select(x => x.Description).Distinct();     
            foreach (var desc in descriptions)
            {
                int num_serie = tri.First(x => x.Description == desc).NumeroSerie;
                int count = tri.Count(x => x.Description == desc);
                bom += $"{desc, -30} {num_serie, -15} {count, -10}\n";
            }
            return bom;
        }
        public virtual string AfficheListeAplatie()
        {
            string affiche = "";
            var tri = m_liste_aplatie.OrderBy(p => p.NumeroSerie);
            foreach (Piece p in tri)
            {
                 affiche += $"\n{p.Description}";
            }
            return affiche;
        }
        public virtual void AjouterPiece(Piece p_sousEnsemble)
        {
            this.m_liste_Piece.Add(p_sousEnsemble);
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Piece))
            {
                return false;
            }
            return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.m_description, this.m_reference, this.m_numero_serie);
        }

        public override string ToString()
        {
            string message="";
            foreach (Piece p in this.m_liste_Piece)
            {
                message +=$"  {p.ToString()}\n"; 
            }
            
            return $"Piece: {this.m_description} part - #{this.m_reference} numero serie: #{this.m_numero_serie}\n{message}";
        }
    }
}