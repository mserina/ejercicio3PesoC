namespace ejercicio3PesoC{ 

    /// <summary>
    /// Clase principal de programa
    /// msm - 250124
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo quecontiene el procedimiento de la aplicacion
        /// msm - 250124
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int maximoPeso = 4000;
            int pesoSaco;
            Console.WriteLine("Inserte el peso del saco");
            pesoSaco = Convert.ToInt32(Console.ReadLine());
            int numerosSacos = maximoPeso / pesoSaco;
            Console.WriteLine("Puedes cargar " + numerosSacos + " sacos" );

        }
    }
}