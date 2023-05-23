using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceAssemblage: Piece
    {
        public PieceAssemblage(string p_description, string p_reference, int p_numero_serie): base(p_description, p_reference, p_numero_serie)
        {
        }

       
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is PieceAssemblage))
            {
                return false;
            }
            return (this.GetDescription == ((PieceAssemblage)obj).GetDescription && this.GetNumeroSerie == ((PieceAssemblage)obj).GetNumeroSerie
                                                && this.GetReference == ((PieceAssemblage)obj).GetReference && this.GetType() == ((PieceAssemblage)obj).GetType());
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