using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace revision_poo1_piece
{
    public class PieceUsinee: Piece
    {

        public PieceUsinee(string p_description, int p_numero_serie, string p_reference): base(p_description, p_numero_serie, p_reference)
        {
        }

        
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is PieceUsinee))
            {
                return false;
            }
            return (this.GetDescription == ((PieceUsinee)obj).GetDescription && this.GetNumeroSerie == ((PieceUsinee)obj).GetNumeroSerie
                                                && this.GetReference == ((PieceUsinee)obj).GetReference && this.GetType() == ((PieceUsinee)obj).GetType());
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