public class Semaforos
{
    static Semaphore SemafotosHilos = new Semaphore(1, 1); // Inicialmente, semáforo en rojo
    
    static void Main(string[] args)
    {
        Thread hiloRojo = new Thread(new ThreadStart(CambiarRojo));
        Thread hiloVerde = new Thread(new ThreadStart(CambiarVerde));
        Thread hiloAmarillo = new Thread(new ThreadStart(CambiarAmarillo));


        hiloRojo.Start();
        hiloVerde.Start();
        hiloAmarillo.Start();

        static void CambiarRojo()
        {
            while (true)
            {
                SemafotosHilos.WaitOne(); // Se adquiere el semáforo
                Console.WriteLine("Semaforo en ROJO");
                Thread.Sleep(1000); // El hilo espera
                SemafotosHilos.Release(); // Se libera el semáforo
            }
        }

        static void CambiarVerde()
        {
            while (true)
            {
                SemafotosHilos.WaitOne(); // Se adquiere el semáforo
                Console.WriteLine("Semaforo en VERDE");
                Thread.Sleep(1000); // El hilo espera
                SemafotosHilos.Release(); // Se libera el semáforo
            }
        }

        static void CambiarAmarillo()
        {
            while (true)
            {
                SemafotosHilos.WaitOne(); // Se adquiere el semáforo
                Console.WriteLine("Semaforo en AMARILLO");
                Thread.Sleep(100); // El hilo espera
                SemafotosHilos.Release(); // Se libera el semáforo
            }
        }
    }
}