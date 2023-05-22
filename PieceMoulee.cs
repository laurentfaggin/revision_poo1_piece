using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceMoulee: Piece
    {
        public PieceMoulee(string p_description, string p_reference, int p_numero_serie): base(p_description, p_reference, p_numero_serie)
        {
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
            return $"Piece: {this.GetDescription}   part - {this.GetReference},  numero serie: #{this.GetNumeroSerie}";
        }

        
    }
}