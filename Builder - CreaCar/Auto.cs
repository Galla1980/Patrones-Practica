using System;

namespace Builder___CreaCar
{
    internal class Auto
    {
        private string _marca;
        private string _modelo;
        private Motor _motor;
        private int _cantPuertas;

        //defino los setter necesarios para configurar las partes del auto.
        public void ConfigurarMarca(string marca)
        {
            _marca = marca;
            Console.WriteLine($"Marca configurada: {_marca}");
        }

        public void ArmarModelo(string modelo)
        {
            _modelo = modelo;
            Console.WriteLine($"Modelo armado: {_modelo}");
        }

        public void InstalarMotor(Motor motor)
        {
            _motor = motor;
            Console.WriteLine($"Motor instalado: {_motor.Numero} con potencia de {_motor.Potencia} HP");
        }

        public void AgregarPuertas(int cantPuertas)
        {
            _cantPuertas = cantPuertas;
            Console.WriteLine($"Se agregarón {_cantPuertas} puertas");
        }

        public override string ToString() 
        {
            return $"Auto: {_marca} {_modelo}, Motor: {_motor.Numero} con potencia de {_motor.Potencia} HP, Cantidad de puertas: {_cantPuertas}";
        }

    }
}
