using FluentValidation;
using LavadoAuto.Infretruture.Model;
using LavadoAuto.Infretruture.Data;

namespace LavadoAuto.Aplication.Validation
{
    public class ServicioValidation : AbstractValidator<ServicioModel>
    {
        private readonly LavadoAutosContext _context;

        public ServicioValidation(LavadoAutosContext context)
        {
            _context = context;

            RuleFor(s => s.Nombre)
                .NotEmpty().WithMessage("El nombre del servicio es obligatorio.")
                .MaximumLength(100).WithMessage("El nombre no puede superar los 100 caracteres.");

            RuleFor(s => s.Tipo)
                .NotEmpty().WithMessage("El tipo de servicio es obligatorio.")
                .Must(t => t == "Básico" || t == "Premium" || t == "Full")
                .WithMessage("El tipo de servicio debe ser Básico, Premium o Full.");

            RuleFor(s => s.Precio)
                .GreaterThan(0).WithMessage("El precio debe ser mayor que 0.");

            RuleFor(s => s.DuracionEstimada)
                .NotEmpty().WithMessage("La duración estimada es obligatoria.");
        }
    }
}
