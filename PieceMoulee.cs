using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceMoulee: Piece
    {
        public PieceMoulee(string p_description, int p_numero_serie, string p_reference, int p_quantite): base(p_description, p_numero_serie, p_reference)
        {
            this.SetQuantite = p_quantite;
        }

        
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is PieceMoulee))
            {
                return false;
            }
            return (this.GetDescription == ((PieceMoulee)obj).GetDescription && this.GetNumeroSerie == ((PieceMoulee)obj).GetNumeroSerie
                                                && this.GetReference == ((PieceMoulee)obj).GetReference && this.GetType() == ((PieceMoulee)obj).GetType());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.GetDescription, this.GetReference);
        }

        public override string ToString()
        {
            return $"Piece: {this.GetDescription}  Numero de serie: {this.GetNumeroSerie}  Reference: {this.GetReference}";
        }

        
    }
}