using FluentValidation;
using LavadoAuto.Infretruture.Model;
using LavadoAuto.Infretruture.Data;

namespace LavadoAuto.Aplication.Validation
{
    public class EmpleadoValidation : AbstractValidator<EmpleadoModel>
    {
        private readonly LavadoAutosContext _context;

        public EmpleadoValidation(LavadoAutosContext context)
        {
            _context = context;

            RuleFor(e => e.Nombre)
                .NotEmpty().WithMessage("El nombre del empleado es obligatorio.")
                .MaximumLength(255).WithMessage("El nombre no puede superar los 255 caracteres.");

            RuleFor(e => e.Puesto)
                .NotEmpty().WithMessage("El puesto del empleado es obligatorio.")
                .MaximumLength(100).WithMessage("El puesto no puede superar los 100 caracteres.");

            RuleFor(e => e.SueldoPorHora)
                .GreaterThan(0).WithMessage("El sueldo por hora debe ser mayor que 0.");
        }
    }
}
