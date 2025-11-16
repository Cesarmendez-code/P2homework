using FluentValidation;
using LavadoAuto.Infretruture.Model;
using LavadoAuto.Infretruture.Data;

namespace LavadoAuto.Aplication.Validation
{
    public class VehiculoValidation : AbstractValidator<VehiculoModel>
    {
        private readonly LavadoAutosContext _context;

        public VehiculoValidation(LavadoAutosContext context)
        {
            _context = context;

            RuleFor(v => v.Placa)
                .NotEmpty().WithMessage("La placa es obligatoria.")
                .MaximumLength(10).WithMessage("La placa no puede superar los 10 caracteres.");

            RuleFor(v => v.Marca)
                .NotEmpty().WithMessage("La marca es obligatoria.")
                .MaximumLength(50).WithMessage("La marca no puede superar los 50 caracteres.");

            RuleFor(v => v.Modelo)
                .NotEmpty().WithMessage("El modelo es obligatorio.")
                .MaximumLength(50).WithMessage("El modelo no puede superar los 50 caracteres.");

            RuleFor(v => v.Tipo)
                .NotEmpty().WithMessage("El tipo de vehículo es obligatorio.")
                .MaximumLength(50).WithMessage("El tipo no puede superar los 50 caracteres.");
            RuleFor(v => v.IdCliente)
                .GreaterThan(0).WithMessage("Debe asociar un cliente al vehículo.");
            
        }
    }
}
