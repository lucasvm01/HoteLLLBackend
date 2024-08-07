namespace HoteLLLBackend.Domain.Entities.Quartos
{
    public partial class Quarto
    {
        public void ReservarQuarto()
        {
            IsReservado = true;
        }

        public void CancelarReservaQuarto()
        {
            IsReservado = false;
        }

        public void OcuparQuarto()
        {
            IsOcupado = true;
            IsReservado = false;
        }

        public void DesocuparQuarto()
        {
            IsOcupado = false;
        }

        public void AtivarQuarto()
        {
            IsAtivo = true;
        }

        public void InativarQuarto()
        {
            IsAtivo = false;
        }

    }
}
