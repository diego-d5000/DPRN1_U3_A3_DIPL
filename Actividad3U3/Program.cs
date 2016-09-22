using System;

namespace Actividad3U3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("======= Banco U3A3 ======\n");
			CCuentaBancaria cuentaBancaria = new CCuentaBancaria ();

			Console.WriteLine ("Ingrese su Nombre:");
			cuentaBancaria.nombreTitular = Console.ReadLine ();
			Console.WriteLine ("Ingrese sus Apellidos:");
			cuentaBancaria.apellidosTitular = Console.ReadLine ();

			cuentaBancaria.numeroCuenta = 1421004131;
			cuentaBancaria.saldo = new Random().Next(10000, 20000);

			Console.WriteLine ("Cantidad a Depositar: ");
			cuentaBancaria.deposito (Double.Parse (Console.ReadLine ()));
			Console.WriteLine ("Cantidad a Retirar: ");
			cuentaBancaria.retiro (Double.Parse (Console.ReadLine ()));

			cuentaBancaria.mostrarEstadoDeCuenta ();
		}
	}

	class CCuentaBancaria
	{
		public string nombreTitular;
		public string apellidosTitular;
		public int numeroCuenta;
		public double saldo;

		public CCuentaBancaria()
		{
			Console.WriteLine ("Diego Antonio Plascencia Lara, ES1421004131 \n" +
				"Actividad 3. Programa que utiliza métodos que no devuelve resultados \n" +
				"{0} \n\n", DateTime.Now);
		}

		public void deposito(double cantidad)
		{
			double saldoAnterior = saldo;
			saldo = saldo + cantidad;
			Console.WriteLine ("Saldo Anterior: {0} \nMonto del Deposito: {1} \nSaldo Nuevo: {2} \n", saldoAnterior, cantidad, saldo);
		}

		public void retiro(double cantidad)
		{
			double saldoAnterior = saldo;
			saldo = saldo - cantidad;
			Console.WriteLine ("Saldo Anterior: {0} \nMonto del Retiro: {1} \nSaldo Nuevo: {2}", saldoAnterior, cantidad, saldo);
			double comision = cantidad * 0.015;
			saldo = saldo - comision;
			Console.WriteLine ("Comision del retiro (1.5%) {0} \nSaldo Nuevo: {1}\n", comision, saldo);
		}

		public void mostrarEstadoDeCuenta()
		{
			Console.Write ("Nombre del Titular: {0} \nNumero de Cuenta: {1}\n", nombreTitular + " " + apellidosTitular, numeroCuenta);
			if (saldo < 0) {
				Console.ForegroundColor = ConsoleColor.Red;
			}
			Console.WriteLine ("Saldo Final: {0}", saldo);
			Console.ResetColor ();
		}
	}
}
