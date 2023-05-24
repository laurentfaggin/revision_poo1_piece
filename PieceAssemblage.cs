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
            return (this.Description == ((PieceAssemblage)obj).Description && this.NumeroSerie == ((PieceAssemblage)obj).NumeroSerie
                                                && this.Reference == ((PieceAssemblage)obj).Reference && this.GetType() == ((PieceAssemblage)obj).GetType());
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Description, this.Reference);
        }

        public override string ToString()
        {
            return $"Piece: {this.Description}   part - {this.Reference},  numero serie: #{this.NumeroSerie}";
        }
    }
}