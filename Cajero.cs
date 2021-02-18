using System;
					
public class cajero
{
	public static void Main()
	{
		/*18 billetes de 1,000
		19 billetes de 500
		23 billetes de 200
		50 billetes de 100
		El cajero debe solicitar Banco y monto a retirar. Si el banco es FDP INVERSMENTS el limite de retiro es 20,000 y 10,000 pesos por transacción en caso contrario.
		El cajero debe informar si el monto solicitado no puede ser dispensado o si excede el límite de transacción. Y debe hacer la distribución de los billetes de acuerdo al monto. */
		int billete_1000=1000;
		int billete_500=500;
		int billete_200=200;
		int billete_100=100;
		Console.WriteLine("A qué banco pertenece su cuenta?");
		Console.WriteLine("********************************");
		Console.WriteLine("********************************");
		Console.WriteLine("*1-FDP Inversments    2-Popular*");
		Console.WriteLine("********************************");
		Console.WriteLine("********************************");
		int x=Convert.ToInt32(Console.ReadLine());
		if(x==1){
			Console.WriteLine("\n");
			Console.WriteLine("Su limite de transacción es de 20,000 pesos");
			Console.WriteLine("Ingrese el monto que desea retirar: ");
			int y=Convert.ToInt32(Console.ReadLine());
			while(y>20000){
				Console.WriteLine("\n"+"Su monto a retirar no puede superar los 20,000 pesos");
				Console.WriteLine("Ingrese su monto a retirar nuevamente:");
				y=Convert.ToInt32(Console.ReadLine());
			}
			int billete1=y%billete_1000;
			billete_1000=y/billete_1000;
			int billete2=y%billete_500;
			billete_500=billete1/billete_500;
			int billete3=y%billete_200;
			billete_200=billete2/billete_200;
			billete_100=billete3/billete_100;
			Console.WriteLine("Le serán entregados "+billete_1000+" billetes de 1000, "+billete_500+" billetes de 500, "+billete_200+" billetes de 200 y "+billete_100+" billetes de 100.");
		}
		else if(x==2){
			Console.WriteLine("\n");
			Console.WriteLine("Su limite de transacción es de 10,000 pesos");
			Console.WriteLine("Ingrese el monto que desea retirar: ");
			int y=Convert.ToInt32(Console.ReadLine());
			while(y>10000){
				Console.WriteLine("\n"+"Su monto a retirar no puede superar los 10,000 pesos");
				Console.WriteLine("Ingrese su monto a retirar nuevamente:");
				y=Convert.ToInt32(Console.ReadLine());
			}
			int billete1=y%billete_1000;
			billete_1000=y/billete_1000;
			int billete2=y%billete_500;
			billete_500=billete1/billete_500;
			int billete3=y%billete_200;
			billete_200=billete2/billete_200;
			billete_100=billete3/billete_100;
			Console.WriteLine("Le serán entregados "+billete_1000+" billetes de 1000, "+billete_500+" billetes de 500, "+billete_200+" billetes de 200 y "+billete_100+" billetes de 100.");
		}
	}
}