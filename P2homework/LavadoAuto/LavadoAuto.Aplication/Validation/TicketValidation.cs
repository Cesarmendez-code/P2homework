using FluentValidation;
using LavadoAuto.Infretruture.Model;
using LavadoAuto.Infretruture.Data;

namespace LavadoAuto.Aplication.Validation
{
    public class TicketValidation : AbstractValidator<TicketModel>
    {
        private readonly LavadoAutosContext _context;

        public TicketValidation(LavadoAutosContext context)
        {
            _context = context;

            RuleFor(t => t.Fecha)
                .NotEmpty().WithMessage("La fecha del ticket es obligatoria.");

            RuleFor(t => t.Total)
                .GreaterThan(0).WithMessage("El total debe ser mayor que 0.");

            RuleFor(t => t.IdVehiculo)
                .GreaterThan(0).WithMessage("Debe asociar un vehículo al ticket.");

            RuleFor(t => t.IdEmpleado)
                .GreaterThan(0).WithMessage("Debe asociar un empleado al ticket.");

            RuleFor(t => t.IdServicio)
                .GreaterThan(0).WithMessage("Debe asociar un servicio al ticket.");
        }
    }
}
