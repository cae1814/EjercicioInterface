using EjercicioInterfaces;

Retirable cuentaRetirable = new Retirable();
cuentaRetirable.Depositos = "Si acepta";
cuentaRetirable.Retiros = "Si acepta";
cuentaRetirable.Intereses = 1.15;
cuentaRetirable.SaldoMinimo = 500;

Aportaciones cuentaAportaciones = new Aportaciones();
cuentaAportaciones.Depositos = "Si acepta";
cuentaAportaciones.Retiros = "NO acepta";
cuentaAportaciones.Intereses = 1.95;
cuentaAportaciones.SaldoMinimo = 1000;

cuentaRetirable.ListarOperaciones();
cuentaAportaciones.ListarOperaciones();
