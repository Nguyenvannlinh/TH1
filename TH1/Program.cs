
using System.Text;

namespace lmao
{
    class point
    {
        private double x; private double y;
        public point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void input()
        {
            Console.Write("nhập tọa độ điểm x :");
            x = double.Parse(Console.ReadLine());
            Console.Write("nhập tọa độ điểm y :");
            y = double.Parse(Console.ReadLine());
        }
        public double Distance(point d2)
        {
            double distance = Math.Sqrt(Math.Pow(x - d2.x, 2) + Math.Pow(y - d2.y, 2));
            return distance;
        }
        public string show()
        {
            return $"đồ thị x:{x}, y: {y}";
        }

    }
    class Employee
    {
        public int id;
        public string name;
        public int yearofbirth;
        public double salarylevel;
        public double basicsalary;
        public Employee(int id, string name, int yearofbirth, double salarylevel, double basicsalary)
        {
            this.id = id;
            this.name = name;
            this.yearofbirth = yearofbirth;
            this.salarylevel = salarylevel;
            this.basicsalary = basicsalary;
        }
        public int getID()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getYearofbirth()
        {
            return yearofbirth;
        }
        public double Income()
        {
            double x = salarylevel * basicsalary;
            return x;
        }
        public string display()
        {
            return $"ID: {id},Tên: {name}, Năm sinh: {yearofbirth}, Lương cơ bản: {basicsalary}, Thu nhập {Income()}";
        }
        public void setsalarylevel(double x)
        {
            salarylevel = x;
        }
        public void setbasicsalary(double y)
        {
            basicsalary = y;
        }

    }
    class Matran
    {
        private int hang, cot;
        private int[,] matrix;
        public Matran(int hang, int cot)
        {
            this.hang = hang;
            this.cot = cot;
            matrix = new int[hang, cot];
        }
        public void nhap()
        {
            for (int i = 0; i < hang; i++)
            {
                Console.WriteLine($"Nhập dữ liệu cho hàng {i + 1}");
                for (int j = 0; j < cot; j++)
                {
                    Console.WriteLine($"Nhập giá trị cho cột {j + 1}");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void print(int[,] matran)
        {
            int[,] x = new int[hang, cot];
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    Console.Write($"{matran[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
        public int[,] cong(Matran p)
        {
            int[,] x = new int[hang, cot];
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    x[i, j] = this.matrix[i, j] + p.matrix[i, j];
                }
            }
            return x;
        }
        public int[,] hieu(Matran p)
        {
            int[,] x = new int[hang, cot];
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    x[i, j] = this.matrix[i, j] - p.matrix[i, j];
                }
            }
            return x;
        }
        public int[,] doidau()
        {
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    matrix[i, j] = -matrix[i, j];
                }
            }
            return matrix;
        }
        public int[,] chuyenvi()
        {
            int[,] cv = new int[cot, hang];
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    cv[j,i] = matrix[i, j];
                }
            }
            return cv;
        }
        public int[,] tich(Matran p)
        {
            int[,] x = new int[hang, cot];
            for (int i = 0; i < hang; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    x[i, j] = this.matrix[i, j] * p.matrix[i, j];
                }
            }
            return x;
        }
        public bool tuongthich(Matran p)
        {
            return this.hang == p.hang && this.cot == p.cot;
        }
        public bool matranvuong()
        {
            return hang == cot;
        }
    }

    class complexNumber
    {
        private int m, n;
        public complexNumber(int m, int n)
        {
            this.m = m;
            this.n = n;
        }
        public complexNumber() { }
        public void nhap()
        {
            Console.Write("nhập số thực :");
            n = int.Parse(Console.ReadLine());
            Console.Write("nhập số ảo :");
            m = int.Parse(Console.ReadLine());
        }
        public string show(complexNumber c)
        {
            return $"{c.n}+{c.m}i";
        }
        public complexNumber cong(complexNumber c)
        {
            complexNumber b = new complexNumber();
            b.m = this.m + c.m;
            b.n = this.n + c.n;
            return b;
        }
        public complexNumber tru(complexNumber c)
        {
            complexNumber b = new complexNumber();
            b.m = this.m - c.m;
            b.n = this.n - c.n;
            return b;
        }

    }


    class Phanso
    {
        private int ts;
        private int ms;
        public Phanso()
        {
            
        }
        
        public Phanso(int ts, int ms)
        {
            this.ts = ts;
            this.ms = ms;
        }
        public void nhap()
        {
            Console.Write("tử số :");
            ts = int.Parse(Console.ReadLine());
            Console.Write("Mẫu số :");
            ms = int.Parse(Console.ReadLine());
        }
        public string show(Phanso p)
        {
            return $"{p.ts}/{p.ms} \t";
        }
        public int ucln(int x, int y)
        {
            x = Math.Abs(x); y = Math.Abs(y);
            while(x != y)
            {
                if (x > y) x = x - y;
                if (y > x) y = y - x;
            }
            return x;
        }
        public Phanso rutgon()
        {
            int uoc = ucln(this.ts, this.ms);
            this.ts = this.ts/uoc;
            this.ms = this.ms/uoc;
            return this;
        }

        public Phanso cong(Phanso p2)
        {
            Phanso p = new Phanso();
            p.ts = this.ts*p2.ms + this.ms*p2.ts;
            p.ms = this.ms * p2.ms;
            return p.rutgon();
        }
        public Phanso tru(Phanso p2)
        {
            Phanso p = new Phanso();
            p.ts = this.ts * p2.ms - this.ms * p2.ts;
            p.ms = this.ms * p2.ms;
            return p.rutgon();
        }
        public Phanso tru1so(int n)
        {
            Phanso p = new Phanso(n, 1);
            return tru(p);
        }
        public Phanso cong1so(int n)
        {
            Phanso p = new Phanso(n, 1);
            return cong(p);
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("nhập số từ 1-5 để chọn bài tập");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Nhập thông tin cho điểm 1:");
                        point point1 = new point(0, 0);
                        point1.input();
                        Console.WriteLine("Nhập thông tin cho điểm 2:");
                        point point2 = new point(0, 0);
                        point2.input();
                        Console.WriteLine($"Khoảng cách giữa hai điểm là: {point1.Distance(point2)}");
                        Console.WriteLine($"tọa độ điểm 1: {point1.show()}");
                        Console.WriteLine($"tọa độ điểm 2: {point2.show()}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Employee employee = new Employee(123, "linh", 2004, 120000, 300000);
                        Console.WriteLine($"Định danh: {employee.getID()}");
                        Console.WriteLine($"Tên: {employee.getName()}");
                        Console.WriteLine($"Năm sinh: {employee.getYearofbirth()}");
                        Console.WriteLine($"Hiển thị\n{employee.display()}\n");
                        employee.setsalarylevel(200000);
                        employee.setbasicsalary(400000);
                        Console.WriteLine($"Hiển thị sau thay đổi\n{employee.display()}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        complexNumber com = new complexNumber();
                        Console.WriteLine("Số phức 1");
                        com.nhap();
                        complexNumber com1 = new complexNumber();
                        Console.WriteLine("Số phức 2");
                        com1.nhap();
                        Console.WriteLine($"Số phức 1: {com.show(com)}");
                        Console.WriteLine($"Số phức 2: {com1.show(com1)}");
                        Console.WriteLine($"cộng 2 số phức {com.show(com.cong(com1))}");
                        Console.WriteLine($"trừ 2 số phức {com.show(com.tru(com1))}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("ma trận 1");
                        Matran matran = new Matran(3, 3);
                        matran.nhap();
                        Console.WriteLine("ma trận 2");
                        Matran matran2 = new Matran(3, 3);
                        matran2.nhap();
                        Console.Clear();
                        Console.WriteLine("tổng 2 ma trận:");
                        matran.print(matran.cong(matran2));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("hiệu 2 ma trận:");
                        matran.print(matran.hieu(matran2));
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("đổi dấu ma trận 1:");
                        matran.print(matran.doidau());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("chuyển vị ma trận 1");
                        matran.print(matran.chuyenvi());
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("tích 2 ma trận:");
                        matran.print(matran.tich(matran2));
                        Console.ReadKey();
                        Console.Clear();
                        if (matran.tuongthich(matran2))
                        {
                            Console.WriteLine("Ma trận tương thích");
                        }
                        else { Console.WriteLine("Ma trận không tương thích"); }
                        if (matran.matranvuong()) { Console.WriteLine("Là ma trận vuông"); }
                        else { Console.WriteLine("Không phải là ma trận vuông"); }
                        break;
                    case 5:
                        Console.WriteLine("phân số 1");
                        Phanso phanso = new Phanso();
                        phanso.nhap();
                        Console.WriteLine("phân số 2");
                        Phanso phanso2 = new Phanso();
                        phanso2.nhap();
                        Console.Write("nhập n để cộng trừ 1 số nguyên");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine($"cộng 2 phân số : {phanso.show(phanso.cong(phanso2))} ");
                        Console.WriteLine($"trừ 2 phân số : {phanso.show(phanso.tru(phanso2))} ");
                        Console.WriteLine($"cộng 1 phân số với 1 số nguyên : {phanso.show(phanso.cong1so(x))} ");
                        Console.WriteLine($"trừ 1 phân số với 1 số nguyên : {phanso.show(phanso.tru1so(x))} ");
                        Console.ReadKey();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}