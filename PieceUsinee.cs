using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceUsinee: Piece
    {

        public PieceUsinee(string p_description, string p_reference, int p_numero_serie): base(p_description, p_reference, p_numero_serie)
        {     
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is PieceUsinee))
            {
                return false;
            }
            return (this.Description == ((PieceUsinee)obj).Description && this.NumeroSerie == ((PieceUsinee)obj).NumeroSerie
                                                && this.Reference == ((PieceUsinee)obj).Reference && this.GetType() == ((PieceUsinee)obj).GetType());
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