    import java.text.DecimalFormat;
    import java.util.*;


    public class ContactsTester {

        public static void main(String[] args) {
            Scanner scanner = new Scanner(System.in);

            int tests = scanner.nextInt();
            Faculty faculty = null;

            int rvalue = 0;
            long rindex = -1;

            DecimalFormat df = new DecimalFormat("0.00");

            for (int t = 0; t < tests; t++) {

                rvalue++;
                String operation = scanner.next();

                switch (operation) {
                    case "CREATE_FACULTY": {
                        String name = scanner.nextLine().trim();
                        int N = scanner.nextInt();

                        Student[] students = new Student[N];

                        for (int i = 0; i < N; i++) {
                            rvalue++;

                            String firstName = scanner.next();
                            String lastName = scanner.next();
                            String city = scanner.next();
                            int age = scanner.nextInt();
                            long index = scanner.nextLong();

                            if ((rindex == -1) || (rvalue % 13 == 0))
                                rindex = index;

                            Student student = new Student(firstName, lastName, city,
                                    age, index);
                            students[i] = student;
                        }

                        faculty = new Faculty(name, students);
                        break;
                    }

                    case "ADD_EMAIL_CONTACT": {
                        long index = scanner.nextInt();
                        String date = scanner.next();
                        String email = scanner.next();

                        rvalue++;

                        if ((rindex == -1) || (rvalue % 3 == 0))
                            rindex = index;

                        faculty.getStudent(index).addEmailContact(date, email);
                        break;
                    }

                    case "ADD_PHONE_CONTACT": {
                        long index = scanner.nextInt();
                        String date = scanner.next();
                        String phone = scanner.next();

                        rvalue++;

                        if ((rindex == -1) || (rvalue % 3 == 0))
                            rindex = index;

                        faculty.getStudent(index).addPhoneContact(date, phone);
                        break;
                    }

                    case "CHECK_SIMPLE": {
                        System.out.println("Average number of contacts: "
                                + df.format(faculty.getAverageNumberOfContacts()));

                        rvalue++;

                        String city = faculty.getStudent(rindex).getCity();
                        System.out.println("Number of students from " + city + ": "
                                + faculty.countStudentsFromCity(city));

                        break;
                    }

                    case "CHECK_DATES": {

                        rvalue++;

                        System.out.print("Latest contact: ");
                        Contact latestContact = faculty.getStudent(rindex)
                                .getLatestContact();
                        if (latestContact.getType().equals("Email"))
                            System.out.println(((EmailContact) latestContact)
                                    .getEmail());
                        if (latestContact.getType().equals("Phone"))
                            System.out.println(((PhoneContact) latestContact)
                                    .getPhone()
                                    + " ("
                                    + ((PhoneContact) latestContact).getOperator()
                                    .toString() + ")");

                        if (faculty.getStudent(rindex).getEmailContacts().length > 0
                                && faculty.getStudent(rindex).getPhoneContacts().length > 0) {
                            System.out.print("Number of email and phone contacts: ");
                            System.out
                                    .println(faculty.getStudent(rindex)
                                            .getEmailContacts().length
                                            + " "
                                            + faculty.getStudent(rindex)
                                            .getPhoneContacts().length);

                            System.out.print("Comparing dates: ");
                            int posEmail = rvalue
                                    % faculty.getStudent(rindex).getEmailContacts().length;
                            int posPhone = rvalue
                                    % faculty.getStudent(rindex).getPhoneContacts().length;

                            System.out.println(faculty.getStudent(rindex)
                                    .getEmailContacts()[posEmail].isNewerThan(faculty
                                    .getStudent(rindex).getPhoneContacts()[posPhone]));
                        }

                        break;
                    }

                    case "PRINT_FACULTY_METHODS": {
                        System.out.println("Faculty: " + faculty.toString());
                        System.out.println("Student with most contacts: "
                                + faculty.getStudentWithMostContacts().toString());
                        break;
                    }

                }

            }

            scanner.close();
        }
    }
    abstract class Contact {
        protected String date;

        public Contact(String date) {
            this.date = date;
        }



        boolean isNewerThan(Contact c) {
            String[] c1Date = date.split("-");
            String[] cDate = c.date.split("-");
            if (new Date(Integer.parseInt(c1Date[0]), Integer.parseInt(c1Date[1]), Integer.parseInt(c1Date[2]))
                    .after(new Date(Integer.parseInt(cDate[0]), Integer.parseInt(cDate[1]), Integer.parseInt(cDate[2]))))
                return true;
            return false;
        }



        abstract String getType();


    }
    class EmailContact extends Contact{
        private String email;

        public EmailContact(String date, String email) {
            super(date);
            this.email = email;
        }

        @Override
        String getType() {
            return "Email";
        }

        public String getEmail() {
            return email;
        }

        @Override
        public String toString() {
            return String.format("\"%s\"",email);
        }
    }
    class PhoneContact extends Contact {
        private String phone;
        private Operator operator;

        public PhoneContact(String date, String phone) {
            super(date);
            this.phone = phone;
            String[] sPhone = phone.split("/");
                if (sPhone[0].charAt(2) == '0' || sPhone[0].charAt(2) == '1' || sPhone[0].charAt(2) == '2')operator=Operator.TMOBILE;
                    if (sPhone[0].charAt(2) == '5' || sPhone[0].charAt(2) == '6')operator=Operator.ONE;
                        if (sPhone[0].charAt(2) == '7' || sPhone[0].charAt(2) == '8')operator=Operator.VIP;
        }

        @Override
        String getType() {
            return "Phone";
        }

        public String getPhone() {
            return phone;
        }

        public Operator getOperator()  {
          return operator;
        }

        @Override
        public String toString() {
            return String.format("\"%s\"",phone);
        }
    }
    class Faculty {
        private String name;
        Student [] students;

        public Faculty(String name, Student[] students) {
            this.name = name;
            this.students = students;
        }
        Student getStudent(long index){
            for(int i=0;i<students.length;i++){
                if(students[i].getIndex()==index)return students[i];
            }
            return null;
        }
        double getAverageNumberOfContacts(){
            int sum=0;
            for(Student s : students){
                sum+=s.getNumContacts();
            }
            return (double) sum/students.length;
        }
        Student getStudentWithMostContacts(){
            Student mStudent = students[0];
            for(Student s : students) {
                if(s.getNumContacts()>mStudent.getNumContacts()) mStudent = s;
                else if(s.getNumContacts()==mStudent.getNumContacts()){
                    if(s.getIndex()>mStudent.getIndex()) mStudent = s;
                }
            }
            return mStudent;
        }

        @Override
        public String toString() {
            return String.format("{\"fakultet\":\"%s\", \"studenti\":%s}",name,Arrays.toString(students));
        }
        int countStudentsFromCity(String cityName){
            int cnt=0;
            for(int i=0;i<students.length;i++){
                if(students[i].getCity().equals(cityName))cnt++;
            }
            return cnt;
        }
    }
    enum Operator {
        VIP,ONE,TMOBILE
    }
    class Student  {
        private String firsName;
        private String lastName;
        private String city;
        private int age;
        private long index;
        List<Contact> sContacs;

        public Student(String firsName, String lastName, String city, int age, long index) {
            this.firsName = firsName;
            this.lastName = lastName;
            this.city = city;
            this.age = age;
            this.index = index;
            sContacs = new ArrayList<>();
        }

        void addEmailContact(String date, String email) {
            sContacs.add(new EmailContact(date, email));
        }

        void addPhoneContact(String date, String phone) {
            sContacs.add(new PhoneContact(date, phone));
        }
        Contact[] addContacts(String type){
            List<Contact> nLists = new ArrayList<>();
            for (int i = 0; i < sContacs.size(); i++) {
                if (sContacs.get(i).getType() == type) {
                    nLists.add(sContacs.get(i));
                }
            }
            Contact[] sContacs = new Contact[nLists.size()];
            sContacs = nLists.toArray(sContacs);
            return sContacs;
        }
        Contact[] getEmailContacts() {
            return addContacts("Email");
        }
        Contact[] getPhoneContacts(){
            return addContacts("Phone");
        }

        public String getCity() {
            return city;
        }

        public long getIndex() {
            return index;
        }
        public String getFullName(){
            StringBuilder s=new StringBuilder();
            s.append(firsName+" "+lastName);
            return s.toString();
        }
        public Contact getLatestContact(){

            Contact [] contacts=new Contact[sContacs.size()];
            contacts=sContacs.toArray(contacts);
            Contact latest=contacts[0];

            for(int i=1;i<contacts.length;i++){
                if(contacts[i].isNewerThan(latest)){
                    latest=contacts[i];
                }
            }
            return latest;
        }
        int getNumContacts(){
            return sContacs.size();
        }

        @Override
        public String toString() {
            return
                    String.format("{\"ime\":\"%s\", \"prezime\":\"%s\", \"vozrast\":%d, \"grad\":\"%s\", \"indeks\":%d, \"telefonskiKontakti\":%s, \"emailKontakti\":%s}",
                            firsName,lastName,age,city,index,Arrays.toString(getPhoneContacts()),Arrays.toString(getEmailContacts()));
        }


        class InvalidOperator extends Throwable {
            private String message;

            public InvalidOperator(String message) {
                this.message = message;
            }

            @Override
            public String toString() {
                return message;
            }
        }}
