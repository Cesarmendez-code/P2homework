using FluentValidation;
using LavadoAuto.Infretruture.Model;
using LavadoAuto.Infretruture.Data;

namespace LavadoAuto.Aplication.Validation
{
    public class ClienteValidation : AbstractValidator<ClienteModel>
    {
        private readonly LavadoAutosContext _context;

        public ClienteValidation(LavadoAutosContext context)
        {
            _context = context;

            RuleFor(c => c.Nombre)
                .NotEmpty().WithMessage("El nombre del cliente es obligatorio.")
                .MaximumLength(255).WithMessage("El nombre no puede superar los 255 caracteres.");

            RuleFor(c => c.Telefono)
                .NotEmpty().WithMessage("El teléfono es obligatorio.")
                .Matches(@"^\+?\d{7,15}$").WithMessage("El teléfono no tiene un formato válido.");

            RuleFor(c => c.PuntosFidelidad)
                .NotEmpty().WithMessage("Los puntos de fidelidad son obligatorios.")
                .MaximumLength(50).WithMessage("Los puntos de fidelidad no pueden superar los 50 caracteres.");
        }
    }
}
