public class Main {
    public static void main(String[] args)
    {
        Client cliente = new Client();
        cliente.setName("FERNANDO");
        cliente.setAge(23);
        cliente.setPhone("1111-4444");
        cliente.setCredit(100.23f);

        Worker trabajador = new Worker();
        trabajador.setName("MARIANO");
        trabajador.setAge(37);
        trabajador.setPhone("2222-6666");
        trabajador.setWages(1500.78f);

        System.out.println("CLIENTE:");
        System.out.print("NOMBRE: ");
        System.out.println(cliente.getName());
        System.out.print("EDAD: ");
        System.out.println(cliente.getAge());
        System.out.print("TELEFONO: ");
        System.out.println(cliente.getPhone());
        System.out.print("CREDITO: $");
        System.out.println(cliente.getCredit());
        System.out.println("\nTRABAJADOR:");
        System.out.print("NOMBRE: ");
        System.out.println(trabajador.getName());
        System.out.print("EDAD: ");
        System.out.println(trabajador.getAge());
        System.out.print("TELEFONO: ");
        System.out.println(trabajador.getPhone());
        System.out.print("SALARIO: $");
        System.out.println(trabajador.getWages());
    }
    static class Person
    {
        private int age;
        private String name;
        private String phone;

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setPhone(String phone)
        {
            this.phone = phone;
        }

        public int getAge()
        {
            return age;
        }

        public String getName()
        {
            return name;
        }

        public String getPhone()
        {
            return phone;
        }
    }
    static class Client extends Person
    {
        private float credit;

        public void setCredit(float credit) {
            this.credit = credit;
        }

        public float getCredit() {
            return credit;
        }
    }
    static class Worker extends Person {
        private float wages;

        public void setWages(float wages) {
            this.wages = wages;
        }

        public float getWages() {
            return wages;
        }
    }
}