import java.util.Scanner;

public class Main {
    public static void main(String[] args)
    {
        Person persona = new Person();
        Scanner read = new Scanner(System.in);
        int inputInt;
        String[] inputStr ={"",""};
        System.out.println("INGRESE LA EDAD DE LA PERSONA:");
        inputInt = read.nextInt();
        persona.setAge(inputInt);
        System.out.println("INGRESE EL NOMBRE DE LA PERSONA:");
        inputStr[0]= read.next();
        persona.setName(inputStr[0]);
        System.out.println("INGRESE EL TELEFONO DE LA PERSONA:");
        inputStr[1]= read.next();
        persona.setPhone(inputStr[1]);

        System.out.println("LA EDAD INGRESADA ES:");
        System.out.println(persona.getAge());
        System.out.println("EL NOMBRE INGRESADO ES:");
        System.out.println(persona.getName());
        System.out.println("EL TELEFONO INGRESADO ES:");
        System.out.println(persona.getPhone());

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
}