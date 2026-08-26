namespace CyberTime
{
    internal class Program
    {   
        static void Main()
        {
            MachineModel maq1 = new MachineModel( MachineModel.MachineStatus.Received, MachineModel.MachineType.Notebook,  "teste");
            Console.WriteLine("Máquina 1");
            Console.WriteLine(maq1.Id);
            Console.WriteLine(maq1.Status);
            Console.WriteLine(maq1.Type);
            Console.WriteLine(maq1.Description);
            
            MachineModel maq2 = new MachineModel( MachineModel.MachineStatus.Received, MachineModel.MachineType.Pc,  "debugando");
            Console.WriteLine("Máquina 2");
            Console.WriteLine(maq2.Id);
            Console.WriteLine(maq2.Status);
            Console.WriteLine(maq2.Type);
            Console.WriteLine(maq2.Description);
            
            MachineModel maq3 = new MachineModel( MachineModel.MachineStatus.InMaintenance, MachineModel.MachineType.Other,  "teste 3");

            ClientModel c1 = new ClientModel("123.456.789-11", "lucas", "91234-5678");
            Console.WriteLine("Cliente 1");
            Console.WriteLine(c1.Cpf);
            Console.WriteLine(c1.Name);
            Console.WriteLine(c1.Phone);

            maq3.Description = "alterado";
            Console.WriteLine(maq1.Description);
            Console.WriteLine(maq2.Description);
            Console.WriteLine(maq3.Description);
            // espero que apareça maq 3 alterado
            // realmente apareceu, cada description é um valor diferente
        }
    }
}