public class Main {
    public static void main(String[] args)
    {
        int resultado;
        resultado = sumaTresValores(10,11,12);
        System.out.println("El resultado es:");
        System.out.println(resultado);
    }
    public static int sumaTresValores (int numeroUno, int numeroDos, int numeroTres)
    {
        int rtn = numeroUno + numeroDos + numeroTres;
        return rtn;
    }
}